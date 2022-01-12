using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class ExecuteOrderForm : Form
    {
        private float Total = 0;
        private float PartsSum = 0;

        public ExecuteOrderForm()
        {
            InitializeComponent();
        }

        private void ExecuteOrderForm_Load(object sender, EventArgs e)
        {
            order_partsTableAdapter.Fill(service_centerDataSet.order_parts);
            order_devicesTableAdapter.Fill(service_centerDataSet.order_devices);
            servicesTableAdapter.Fill(service_centerDataSet.services);
            required_partsTableAdapter.Fill(service_centerDataSet.required_parts);
            repair_partsTableAdapter.Fill(service_centerDataSet.repair_parts);
            parts_warehouseTableAdapter.Fill(service_centerDataSet.parts_warehouse);
            devicesTableAdapter.Fill(service_centerDataSet.devices);
            ordersTableAdapter.Fill(service_centerDataSet.orders);
            employeesTableAdapter.Fill(service_centerDataSet.employees);
            clientsTableAdapter.Fill(service_centerDataSet.clients);
            var currentOrders = (from o in service_centerDataSet.orders
                                 join d in service_centerDataSet.order_devices on o.Ord_id equals d.Ord_id
                                 where d.OrdDev_fixed == false
                                 select new
                                 {
                                     Id = o.Ord_id,
                                     Name = $"Заказ {o.Ord_id} от {o.Ord_datetime}"
                                 }).Distinct();
            if(currentOrders.Count() > 0)
            {
                cb_order.DataSource = new BindingSource(currentOrders, null);
                cb_order.DisplayMember = "Name";
                cb_order.ValueMember = "Id";
                cb_order.SelectedItem = null;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (dgv_devices.RowCount > 1)
            {
                tabControl1.SelectedIndex = 1;
                var connection = new MySqlConnection(Properties.Settings.Default.service_centerConnectionString);
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.Transaction = connection.BeginTransaction();
                try
                {
                    int ordId = (int)cb_order.SelectedValue;
                    command.CommandText = "UPDATE orders SET Ord_sum = Ord_sum + @partsSum WHERE Ord_id = @ordId;";
                    command.Parameters.AddWithValue("@partsSum", PartsSum);
                    command.Parameters.AddWithValue("@ordId", ordId);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    var parts = new List<string>();
                    foreach (DataGridViewRow partRow in dgv_parts.Rows)
                    {
                        int devId = (int)partRow.Cells["col_part_device"].Value;
                        int partId = (int)partRow.Cells["col_part_part"].Value;
                        int quantity = Convert.ToInt32(partRow.Cells["col_part_quantity"].Value);
                        float price = Convert.ToSingle(partRow.Cells["col_part_price"].Value);
                        command.Parameters.AddWithValue("@devId", devId);
                        command.Parameters.AddWithValue("@partId", partId);
                        int partWH_count = (int)partRow.Cells["col_part_WH"].Value - quantity;
                        if (partWH_count < 0) throw new Exception($"Не хватает {partRow.Cells["col_part_part"].FormattedValue} для {partRow.Cells["col_part_device"].FormattedValue} в размере {partWH_count * -1} штук");
                        if (partWH_count == 0) command.CommandText = "DELETE FROM parts_warehouse WHERE Dev_id = @devId AND Part_id = @partId;";
                        else
                        {
                            command.CommandText = "UPDATE parts_warehouse SET PartWH_count = @partWH_count, PartWH_sum = PartWH_sum - @partSum WHERE Dev_id = @devId AND Part_id = @partId";
                            command.Parameters.AddWithValue("@partWH_count", partWH_count);
                            command.Parameters.AddWithValue("@partSum", (float)partRow.Cells["col_part_sum"].Value);
                        }
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();

                        var orderPart = service_centerDataSet.order_parts.FindByOrd_idDev_idPart_idOrdPart_price(ordId, devId, partId, price);
                        if (orderPart != null)
                        {
                            command.CommandText = $"UPDATE order_parts SET OrdPart_count = OrdPart_count + @quantity WHERE Ord_id = @ordId AND Dev_id = @devId AND Part_id = @partId AND OrdPart_price = @price;";
                            command.Parameters.AddWithValue("@quantity", quantity);
                            command.Parameters.AddWithValue("@ordId", ordId);
                            command.Parameters.AddWithValue("@devId", devId);
                            command.Parameters.AddWithValue("@partId", partId);
                            command.Parameters.AddWithValue("@price", price);
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                        else parts.Add($"('{ordId}', '{devId}', '{partId}', '{price}', '{quantity}')");
                    }
                    if (parts.Count > 0)
                    {
                        command.CommandText = "INSERT INTO order_parts (Ord_id, Dev_id, Part_id, OrdPart_price, OrdPart_count) VALUES " + string.Join(", ", parts);
                        command.ExecuteNonQuery();
                    }

                    for (int i = 0; i < dgv_devices.RowCount - 1; i++)
                    {
                        int devId = (int)dgv_devices["col_dev_device", i].Value;
                        int servId = (int)dgv_devices["col_dev_service", i].Value;
                        int deviceQuantity = Convert.ToInt32(dgv_devices["col_dev_quantity", i].Value);
                        service_centerDataSet.order_devices.HandleOperation(command, ordId, devId, servId, deviceQuantity, false);
                    }

                    command.Transaction.Commit();
                    MessageBox.Show($"Заказ № {ordId} обработан успешно", "Заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Transaction.Rollback();
                }
            }
            else MessageBox.Show("Добавьте технику", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                dgv_parts.Rows.Clear();
                parts_warehouseTableAdapter.Fill(service_centerDataSet.parts_warehouse);
                for(int i = 0; i < dgv_devices.RowCount - 1; i++)
                {
                    var deviceRow = dgv_devices.Rows[i];
                    var requiredParts = service_centerDataSet.services.FindByServ_id((int)deviceRow.Cells["col_dev_service"].Value).Getrequired_partsRows();
                    foreach (var part in requiredParts)
                    {
                        int devId = (int)deviceRow.Cells["col_dev_device"].Value;
                        int partQuantity = part.Req_count * Convert.ToInt32(deviceRow.Cells["col_dev_quantity"].Value);
                        var partsWarehouse = service_centerDataSet.parts_warehouse.FindByDev_idPart_id(devId, part.Part_id);
                        float? partPrice = partsWarehouse?.PartWH_sum / partsWarehouse?.PartWH_count;
                        dgv_parts.Rows.Add(devId, part.Part_id, partQuantity, partsWarehouse?.PartWH_count ?? 0, partPrice, partQuantity * partPrice);
                    }
                }
                calculateTotal();
            }
        }

        private void dgv_devices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_devices.Rows[e.RowIndex];
                if (e.ColumnIndex == 1) // col_quantity
                {
                    row.Cells["col_dev_sum"].Value = Convert.ToSingle(row.Cells["col_dev_price"].Value) * Convert.ToInt32(row.Cells["col_dev_quantity"].Value);
                    calculateTotal();
                }
            }
        }

        private void cb_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_order.SelectedValue is int id)
            {
                tabControl1.SelectedIndex = 0;
                var orderRow = service_centerDataSet.orders.FindByOrd_id(id);
                var clientRow = orderRow.clientsRow;
                tb_client.Text = $"{clientRow.Client_surname} {clientRow.Client_name} {clientRow.Client_second_name}";
                var employeeRow = orderRow.employeesRow;
                tb_employee.Text = $"{employeeRow.Empl_surname} {employeeRow.Empl_name} {employeeRow.Empl_second_name}";
                var orderDevices = orderRow.Getorder_devicesRows();
                dgv_devices.Rows.Clear();
                foreach (var device in orderDevices)
                {
                    if(device.OrdDev_fixed == false) dgv_devices.Rows.Add(device.Dev_id, device.OrdDev_count, device.Serv_id, device.OrdDev_price, device.OrdDev_count * device.OrdDev_price);
                }
            }
        }

        private void calculateTotal()
        {
            Total = dgv_devices.CalculateTotal("col_dev_sum");
            PartsSum = dgv_parts.CalculateTotal("col_part_sum");
            Total += PartsSum;
            tb_total.Text = Total.ToString("N2");
        }

        private void dgv_devices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculateTotal();
        }

        private void dgv_devices_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculateTotal();
        }
    }
}
