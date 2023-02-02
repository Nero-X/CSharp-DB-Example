using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class FilterForm : Form
    {
        public string Filter { get; private set; }
        private DataTable Dt;
        private DataGridViewRow[] saveState;
        private DateTimePicker dtp;
        private static Dictionary<string, FilterForm> filterForms = new Dictionary<string, FilterForm>();

        public FilterForm(string text, DataTable dt)
        {
            InitializeComponent();
            Text = "Фильтр " + text;
            Dt = dt;
            col_field.DataSource = new BindingSource(dt.Columns, null);
            col_field.DisplayMember = "Caption";
            col_field.ValueMember = "ColumnName";
        }

        public static bool Show(string tableName, DataTable dt, BindingSource bindingSource)
        {
            var filterForm = bindingSource.Filter != null ? filterForms[dt.TableName] : new FilterForm(tableName, dt);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                var prevFilter = bindingSource.Filter;
                try
                {
                    bindingSource.Filter = filterForm.Filter;
                }
                catch (Exception e)
                {
                    bindingSource.Filter = prevFilter;
                    MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (bindingSource.Filter != null)
            {
                filterForms[dt.TableName] = filterForm;
                return true;
            }
            else return false;
        }

        public static void Dispose(string tableName)
        {
            if (filterForms.ContainsKey(tableName))
            {
                filterForms[tableName].Dispose();
                filterForms.Remove(tableName);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Filter = null;
            saveState = new DataGridViewRow[dgv.RowCount - 1];
            for(int i = 0; i < dgv.RowCount - 1; i++)
            {
                saveState[i] = dgv.Rows[i];
            }
            dgv.Sort(dgv.Columns["col_field"], ListSortDirection.Ascending);
            bool or = false;
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                string expr = $"[{dgv["col_field", i].Value}]{dgv["col_op", i].Value}'{dgv["col_value", i].Value}'";
                if (i != dgv.RowCount - 2)
                    if (dgv["col_field", i].Value == dgv["col_field", i + 1].Value && dgv["col_parentDT", i].Value != null)
                    {
                        Filter += (or ? "" : "(") + expr + " OR ";
                        or = true;
                    }
                    else
                    {
                        Filter += expr + (or ? ")" : "") + " AND ";
                        or = false;
                    }
                else Filter += expr + (or ? ")" : "");
            }
            dgv.Rows.Clear();
            dgv.Rows.AddRange(saveState);
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && dgv[e.ColumnIndex, e.RowIndex].ReadOnly == false) e.PaintImage(Properties.Resources.search);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv["col_field", e.RowIndex].Value != null)
            {
                switch (e.ColumnIndex)
                {
                    case 2: // col_value
                        {
                            if (Dt.Columns[dgv[0, e.RowIndex].Value.ToString()].DataType == typeof(DateTime))
                            {
                                // initialize DateTimePicker
                                dtp = new DateTimePicker();
                                dtp.Format = DateTimePickerFormat.Short;
                                dtp.Visible = true;
                                DateTime value = DateTime.Now;
                                if (dgv.CurrentCell.Value != null && DateTime.TryParse(dgv.CurrentCell.Value.ToString(), out value)) dtp.Value = value;

                                // set size and location
                                var rect = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                                dtp.Size = new Size(rect.Width, rect.Height);
                                dtp.Location = new Point(rect.X, rect.Y);

                                // attach events
                                dtp.CloseUp += dtp_CloseUp;
                                dtp.TextChanged += dtp_OnTextChange;

                                dgv.Controls.Add(dtp);
                            }
                            break;
                        }
                    case 3: // col_findBtn
                        {
                            if(dgv[e.ColumnIndex, e.RowIndex].ReadOnly == false)
                            {
                                ReferenceForm referenceForm = new ReferenceForm(Dt.DataSet.Tables[dgv["col_parentDT", e.RowIndex].Value.ToString()]);
                                if (referenceForm.ShowDialog() == DialogResult.OK) dgv["col_value", e.RowIndex].Value = referenceForm.SelectedValue;
                                referenceForm.Dispose();
                            }
                            break;
                        }
                }
            }
        }

        // on text change of dtp, assign back to cell
        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            dgv.CurrentCell.Value = dtp.Text.ToString();
        }

        // on close of cell, hide dtp
        private void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var colName = dgv[0, e.RowIndex].Value.ToString();
                var comboBoxCell = (DataGridViewComboBoxCell)dgv["col_op", e.RowIndex];
                comboBoxCell.ReadOnly = false;
                dgv["col_parentDT", e.RowIndex].Value = null;
                dgv["col_findBtn", e.RowIndex].DataGridViewCellVisibility(false);
                if (Utility.FindRelativeDataTable(Dt, colName) is DataTable parentDT)
                {
                    dgv["col_findBtn", e.RowIndex].DataGridViewCellVisibility(true);
                    dgv["col_parentDT", e.RowIndex].Value = parentDT.TableName;
                    comboBoxCell.Value = "=";
                    comboBoxCell.ReadOnly = true;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            if (saveState != null) dgv.Rows.AddRange(saveState);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentCell.ColumnIndex != 2 && dtp != null) dtp.Visible = false;
        }
    }
}
