using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class ReferenceForm : Form
    {
        public int SelectedValue;
        private string primaryKey;
        private DataTable Dt;
        private BindingSource bindingSource;
        
        public ReferenceForm(DataTable dt)
        {
            InitializeComponent();
            Dt = dt;
            bindingSource = new BindingSource(dt, null);
            dgv.DataSource = bindingSource;
            primaryKey = dt.PrimaryKey[0].ColumnName;
            Text = "Поиск значения для " + dt.PrimaryKey[0].Caption;
            dgv.SetHeaderTextsFromDataColumnCaptions(dt);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            SelectedValue = (int)dgv.SelectedCells[0].OwningRow.Cells[primaryKey].Value;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                SelectedValue = (int)dgv[primaryKey, e.RowIndex].Value;
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            btn_filter.BackColor = Color.FromKnownColor(FilterForm.Show(Dt.TableName, Dt, bindingSource) ? KnownColor.ActiveCaption : KnownColor.Control);
        }

        private void ReferenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bindingSource.Filter = null;
            FilterForm.Dispose(Dt.TableName);
        }
    }
}
