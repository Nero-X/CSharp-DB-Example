using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class PartsPurchaseForm : Form
    {
        private float Total = 0;

        public PartsPurchaseForm()
        {
            InitializeComponent();
        }

        private void PartsPurchaseForm_Load(object sender, EventArgs e)
        {
            parts_warehouseTableAdapter.Fill(service_centerDataSet.parts_warehouse);
            repair_partsTableAdapter.Fill(service_centerDataSet.repair_parts);
            devicesTableAdapter.Fill(service_centerDataSet.devices);
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
                else if (e.ColumnIndex == 3) // col_findPart
                {
                    dataTable = service_centerDataSet.repair_parts;
                }
                if (dataTable != null)
                {
                    ReferenceForm referenceForm = new ReferenceForm(dataTable);
                    if (referenceForm.ShowDialog() == DialogResult.OK) ((DataGridViewComboBoxCell)dgv[e.ColumnIndex - 1, e.RowIndex]).Value = referenceForm.SelectedValue;
                    referenceForm.Dispose();
                }
            }
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5) // col_quantity or col_price
                {
                    row.Cells["col_sum"].Value = Convert.ToSingle(row.Cells["col_price"].Value) * Convert.ToInt32(row.Cells["col_quantity"].Value);
                    calculateTotal();
                }
            }
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
                    var parts = new List<string>();
                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        int devId = (int)dgv["col_device", i].Value;
                        int partId = (int)dgv["col_part", i].Value;
                        int quantity = Convert.ToInt32(dgv["col_quantity", i].Value);
                        float sum = Convert.ToSingle(dgv["col_sum", i].Value);
                        var partWH = service_centerDataSet.parts_warehouse.FindByDev_idPart_id(devId, partId);
                        if(partWH != null)
                        {
                            command.CommandText = $"UPDATE parts_warehouse SET PartWH_count = PartWH_count + @quantity, PartWH_sum = PartWH_sum + @sum WHERE Dev_id = @devId AND Part_id = @partId;";
                            command.Parameters.AddWithValue("@quantity", quantity);
                            command.Parameters.AddWithValue("@devId", devId);
                            command.Parameters.AddWithValue("@partId", partId);
                            command.Parameters.AddWithValue("@sum", sum);
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                        else parts.Add($"('{devId}', '{partId}', '{quantity}', '{sum}')");
                    }
                    if (parts.Count > 0)
                    {
                        command.CommandText = "INSERT INTO parts_warehouse (Dev_id, Part_id, PartWH_count, PartWH_sum) VALUES " + string.Join(", ", parts);
                        command.ExecuteNonQuery();
                    }

                    command.Transaction.Commit();
                    MessageBox.Show($"Запчасти успешно добавлены", "Закупка запчастей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Transaction.Rollback();
                }
            }
            else MessageBox.Show("Добавьте запчасти", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateTotal()
        {
            Total = dgv.CalculateTotal("col_sum");
            tb_total.Text = Total.ToString("N2");
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculateTotal();
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 3) && e.RowIndex >= 0) e.PaintImage(Properties.Resources.search);
        }
    }
}
