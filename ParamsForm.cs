using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class ParamsForm : Form
    {
        public Dictionary<string, object> ParamValues = new Dictionary<string, object>();

        public ParamsForm(DataSet dataSet, List<SqlParam> sqlParams)
        {
            InitializeComponent();
            Text = "Введите параметры запроса";
            tableLayoutPanel.RowCount = sqlParams.Count + 1;
            tableLayoutPanel.RowStyles.RemoveAt(1);
            foreach (SqlParam param in sqlParams)
            {
                var label_variable = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Text = param.Variable
                };
                var label_op = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Text = param.Op
                };
                var btn_search = new Button
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Image = Properties.Resources.search,
                    Enabled = false
                };
                Control textBox_value = new TextBox(); // TODO: between
                if (param.Field != "")
                {
                    foreach (DataTable table in dataSet.Tables)
                    {
                        var column = table.Columns[param.Field];
                        if (column != null)
                        {
                            if (column.DataType == typeof(DateTime))
                            {
                                textBox_value = new DateTimePicker { Format = DateTimePickerFormat.Short };
                                break;
                            }
                            else if (Utility.FindRelativeDataTable(table, param.Field) is DataTable parentDT)
                            {
                                btn_search.Click += (object _s, EventArgs _e) =>
                                {
                                    var referenceForm = new ReferenceForm(parentDT);
                                    if (referenceForm.ShowDialog() == DialogResult.OK)
                                    {
                                        int value = referenceForm.SelectedValue;
                                        textBox_value.Text = value.ToString();
                                    }
                                    referenceForm.Dispose();
                                };
                                btn_search.Enabled = true;
                                break;
                            }
                        }
                    }
                }
                textBox_value.Anchor = AnchorStyles.None;
                tableLayoutPanel.Controls.AddRange(new Control[] { label_variable, label_op, textBox_value, btn_search });
            }
            var btn_cancel = new Button
            {
                Text = "Отмена",
                DialogResult = DialogResult.Cancel
            };
            CancelButton = btn_cancel;
            var btn_ok = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK
            };
            btn_ok.Click += btn_ok_Click;
            AcceptButton = btn_ok;
            var flow = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft
            };
            flow.Controls.AddRange(new Control[] { btn_cancel, btn_ok });
            tableLayoutPanel.SetColumnSpan(flow, 4);
            tableLayoutPanel.Controls.Add(flow);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel.RowCount - 1; i++)
            {
                string param = tableLayoutPanel.GetControlFromPosition(0, i).Text;
                var textBox_value = tableLayoutPanel.GetControlFromPosition(2, i);
                string value;
                if (textBox_value is DateTimePicker picker) value = picker.Value.ToString("yyyy/MM/dd");
                else value = textBox_value.Text;
                ParamValues.Add(param, value);
            }
        }
    }
}
