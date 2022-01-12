using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class OrderForm : Form
    {
        private float Total = 0;

        public OrderForm()
        {
            InitializeComponent();
            dgv.DataError += Utility.DataGridView_SupressDataError;
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 4) && e.RowIndex >= 0) e.PaintImage(Properties.Resources.search);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dataTable = null;
                if (e.ColumnIndex == 1) // col_findDevice
                {
                    dataTable = service_centerDataSet.devices;
                }
                else if(e.ColumnIndex == 4) // col_findService
                {
                    dataTable = service_centerDataSet.services;
                }
                if (dataTable != null)
                {
                    ReferenceForm referenceForm = new ReferenceForm(dataTable);
                    if (referenceForm.ShowDialog() == DialogResult.OK) ((DataGridViewComboBoxCell)dgv[e.ColumnIndex - 1, e.RowIndex]).Value = referenceForm.SelectedValue;
                    referenceForm.Dispose();
                }
            }
        }

        private void btn_findClient_Click(object sender, EventArgs e)
        {
            ReferenceForm referenceForm = new ReferenceForm(service_centerDataSet.clients);
            if (referenceForm.ShowDialog() == DialogResult.OK) cb_client.SelectedValue = referenceForm.SelectedValue;
            referenceForm.Dispose();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(dgv.RowCount > 1)
            {
                var connection = new MySqlConnection(Properties.Settings.Default.service_centerConnectionString);
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.Transaction = connection.BeginTransaction();
                try
                {
                    command.CommandText = $"INSERT INTO orders (Client_id, Empl_id, Ord_sum) VALUES (@clientId, @emplId, @ordSum)";
                    command.Parameters.AddWithValue("@clientId", cb_client.SelectedValue);
                    command.Parameters.AddWithValue("@emplId", cb_employee.SelectedValue);
                    command.Parameters.AddWithValue("@ordSum", Total);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    long ordId = command.LastInsertedId;

                    var devices = new List<string>();
                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        devices.Add($"('{ordId}', " +
                            $"'{dgv["col_device", i].Value}', " +
                            $"'{dgv["col_service", i].Value}', " +
                            $"'{dgv["col_quantity", i].Value}', " +
                            $"'{dgv["col_price", i].Value}')");
                    }
                    command.CommandText = "INSERT INTO order_devices (Ord_id, Dev_id, Serv_id, OrdDev_count, OrdDev_price) VALUES " + string.Join(", ", devices);
                    command.ExecuteNonQuery();

                    command.Transaction.Commit();
                    MessageBox.Show($"Заказ № {ordId} успешно добавлен", "Заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void calculateTotal()
        {
            Total = dgv.CalculateTotal("col_sum");
            tb_total.Text = Total.ToString("N2");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            employeesTableAdapter.Fill(service_centerDataSet.employees);
            clientsTableAdapter.Fill(service_centerDataSet.clients);
            servicesTableAdapter.Fill(service_centerDataSet.services);
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
            }
            else MessageBox.Show("Отсутствуют клиенты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var clientsSource = new AutoCompleteStringCollection();
            foreach (var client in clients)
            {
                clientsSource.Add(client.FullName);
            }
            cb_client.AutoCompleteCustomSource = clientsSource;
            var employees = service_centerDataSet.employees.Select(x => new
            {
                Id = x.Empl_id,
                FullName = $"{x.Empl_surname} {x.Empl_name} {x.Empl_second_name}"
            });
            if (employees.Count() > 0)
            {
                cb_employee.DataSource = new BindingSource(employees, null);
                cb_employee.DisplayMember = "FullName";
                cb_employee.ValueMember = "Id";
            }
            else MessageBox.Show("Отсутствуют сотрудники", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var employeesSource = new AutoCompleteStringCollection();
            foreach (var employee in employees)
            {
                employeesSource.Add(employee.FullName);
            }
            cb_employee.AutoCompleteCustomSource = employeesSource;
        }

        private void btn_findEmployee_Click(object sender, EventArgs e)
        {
            ReferenceForm referenceForm = new ReferenceForm(service_centerDataSet.employees);
            if (referenceForm.ShowDialog() == DialogResult.OK) cb_employee.SelectedValue = referenceForm.SelectedValue;
            referenceForm.Dispose();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];
                if (e.ColumnIndex == 3) // col_service
                    row.Cells["col_price"].Value = service_centerDataSet.services.FindByServ_id((int)row.Cells["col_service"].Value)["Serv_price"];
                if (e.ColumnIndex == 2 || e.ColumnIndex == 5) // col_quantity or col_price
                {
                    row.Cells["col_sum"].Value = Convert.ToSingle(row.Cells["col_price"].Value) * Convert.ToInt32(row.Cells["col_quantity"].Value);
                    calculateTotal();
                }
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculateTotal();
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculateTotal();
        }
    }
}
