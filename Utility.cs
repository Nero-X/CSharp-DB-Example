using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BBD_lab1
{
    public static class Utility
    {
        public static void DataGridViewCellVisibility(this DataGridViewCell cell, bool visible)
        {
            cell.Style = visible ?
                  new DataGridViewCellStyle { Padding = new Padding(0, 0, 0, 0) } :
                  new DataGridViewCellStyle { Padding = new Padding(cell.OwningColumn.Width, 0, 0, 0) };

            cell.ReadOnly = !visible;
        }

        public static void SetHeaderTextsFromDataColumnCaptions(this DataGridView dataGridView, DataTable dataTable)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderText = dataTable.Columns[column.DataPropertyName].Caption;
            }
        }

        public static void PaintImage(this DataGridViewCellPaintingEventArgs e, Image image)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;

            e.Graphics.DrawImage(Properties.Resources.search, new Rectangle(x, y, image.Width, image.Height));
            e.Handled = true;
        }

        public static float CalculateTotal(this DataGridView dataGridView, string columnName)
        {
            float total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                total += Convert.ToSingle(row.Cells[columnName].Value);
            }
            return total;
        }

        public static void DataGridView_SupressDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Данный обработчик необходим для подавления DataError, возникающего при закрытии формы из-за бага, связанного со свойством DataGridView.AutoSize
            // Подробнее: https://www.cyberforum.ru/windows-forms/thread1340064.html
        }

        public static void HandleOperation(this service_centerDataSet.order_devicesDataTable order_devices, MySqlCommand command, int ordId, int devId, int servId, int quantity, bool returning)
        {
            var from = order_devices.FindByOrd_idDev_idServ_idOrdDev_fixedOrdDev_returned(ordId, devId, servId, returning, false);
            var to = order_devices.FindByOrd_idDev_idServ_idOrdDev_fixedOrdDev_returned(ordId, devId, servId, true, returning);
            command.Parameters.AddWithValue("@ordId", ordId);
            command.Parameters.AddWithValue("@devId", devId);
            command.Parameters.AddWithValue("@servId", servId);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@OrdDev_price", from.OrdDev_price);
            command.Parameters.AddWithValue("@returning", returning);
            if (to != null)
            {
                if (quantity == from.OrdDev_count) command.CommandText = "DELETE FROM order_devices WHERE Ord_id = @ordId AND Dev_id = @devId AND Serv_id = @servId AND OrdDev_fixed = @returning AND OrdDev_returned = 0;";
                else command.CommandText = "UPDATE order_devices SET OrdDev_count = OrdDev_count - @quantity WHERE Ord_id = @ordId AND Dev_id = @devId AND Serv_id = @servId AND OrdDev_fixed = @returning AND OrdDev_returned = 0;";
                command.ExecuteNonQuery();
                command.CommandText = "UPDATE order_devices SET OrdDev_count = OrdDev_count + @quantity WHERE Ord_id = @ordId AND Dev_id = @devId AND Serv_id = @servId AND OrdDev_fixed = 1 AND OrdDev_returned = @returning;";
            }
            else
            {
                if (quantity == from.OrdDev_count)
                {
                    command.CommandText = $"UPDATE order_devices SET {(returning ? "OrdDev_returned" : "OrdDev_fixed")} = 1 WHERE Ord_id = @ordId AND Dev_id = @devId AND Serv_id = @servId AND OrdDev_fixed = @returning AND OrdDev_returned = 0;";
                }
                else
                {
                    command.CommandText = "UPDATE order_devices SET OrdDev_count = OrdDev_count - @quantity WHERE Ord_id = @ordId AND Dev_id = @devId AND Serv_id = @servId AND OrdDev_fixed = @returning AND OrdDev_returned = 0;";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO order_devices (Ord_id, Dev_id, Serv_id, OrdDev_fixed, OrdDev_returned, OrdDev_count, OrdDev_price) VALUES (@ordId, @devId, @servId, 1, @returning, @deviceQuantity, @OrdDev_price);";
                }
            }
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }

    public struct SqlParam
    {
        public string Field;
        public string Op;
        public string Variable;

        public SqlParam(string field, string op, string variable)
        {
            Field = field;
            Op = op;
            Variable = variable;
        }
    }
}
