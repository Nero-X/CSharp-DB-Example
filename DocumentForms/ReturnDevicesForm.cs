using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class ReturnDevicesForm : Form
    {
        public ReturnDevicesForm()
        {
            InitializeComponent();
        }

        private void ReturnDevicesForm_Load(object sender, EventArgs e)
        {
            servicesTableAdapter.Fill(service_centerDataSet.services);
            order_devicesTableAdapter.Fill(service_centerDataSet.order_devices);
            ordersTableAdapter.Fill(service_centerDataSet.orders);
            clientsTableAdapter.Fill(service_centerDataSet.clients);
            devicesTableAdapter.Fill(service_centerDataSet.devices);
            var clients = service_centerDataSet.clients.Select(x => new
            {
                Id = x.Client_id,
                FullName = $"{x.Client_surname} {x.Client_name} {x.Client_second_name}"
            });
            if (clients.Count() > 0)
            {
                cb_client.DataSource = new BindingSource(clients, null);
                cb_client.DisplayMember = "FullName";
                cb_client.ValueMember = "Id";
                cb_client.SelectedItem = null;
            }
            else MessageBox.Show("Отсутствуют клиенты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var clientsSource = new AutoCompleteStringCollection();
            foreach (var client in clients)
            {
                clientsSource.Add(client.FullName);
            }
            cb_client.AutoCompleteCustomSource = clientsSource;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 1)
            {
                var connection = new MySqlConnection(Properties.Settings.Default.service_centerConnectionString);
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.Transaction = connection.BeginTransaction();
                try
                {
                    int ordId = (int)cb_order.SelectedValue;
                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        int devId = (int)dgv["col_device", i].Value;
                        int servId = (int)dgv["col_service", i].Value;
                        int йuantity = Convert.ToInt32(dgv["col_quantity", i].Value);
                        service_centerDataSet.order_devices.HandleOperation(command, ordId, devId, servId, йuantity, true);
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

        private void cb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_client.SelectedValue is int clientId)
            {
                var currentOrders = (from o in service_centerDataSet.orders
                                     join d in service_centerDataSet.order_devices on o.Ord_id equals d.Ord_id
                                     where o.Client_id == clientId && d.OrdDev_fixed == true && d.OrdDev_returned == false
                                     select new
                                     {
                                         Id = o.Ord_id,
                                         Name = $"Заказ {o.Ord_id} от {o.Ord_datetime}"
                                     }).Distinct();
                if (currentOrders.Count() > 0)
                {
                    cb_order.DataSource = new BindingSource(currentOrders, null);
                    cb_order.DisplayMember = "Name";
                    cb_order.ValueMember = "Id";
                    cb_order.SelectedItem = null;
                }
            }
        }

        private void btn_findClient_Click(object sender, EventArgs e)
        {
            ReferenceForm referenceForm = new ReferenceForm(service_centerDataSet.clients);
            if (referenceForm.ShowDialog() == DialogResult.OK) cb_client.SelectedValue = referenceForm.SelectedValue;
            referenceForm.Dispose();
        }

        private void cb_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_order.SelectedValue is int id)
            {
                var orderDevices = service_centerDataSet.orders.FindByOrd_id(id).Getorder_devicesRows();
                dgv.Rows.Clear();
                foreach (var device in orderDevices)
                {
                    if (device.OrdDev_fixed == true && device.OrdDev_returned == false) dgv.Rows.Add(device.Dev_id, device.Serv_id, device.OrdDev_count);
                }
            }
        }
    }
}
