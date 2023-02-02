using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace BBD_lab1
{
    public partial class MainForm : Form
    {
        const int RECENT_QUERIES_COUNT = 10;
        public readonly string SavedQueriesPath = "Saved queries";
        public readonly string Ext = ".sql";
        public readonly string ConnectionString = Properties.Settings.Default.service_centerConnectionString;
        public Dictionary<DataTable, (string DisplayName, int DisplayColumnIndex, BindingSource BindingSource)> DataTableInfos;

        private QueryManagerForm queryManagerForm;

        public MainForm()
        {
            InitializeComponent();
            DataTableInfos = new Dictionary<DataTable, (string, int, BindingSource)>
            {
                { service_centerDataSet.clients, ("Клиенты", 3, clientsBindingSource) },
                { service_centerDataSet.devices, ("Техника", 3, devicesBindingSource) },
                { service_centerDataSet.device_types, ("Типы техники", 1, devicetypesBindingSource) },
                { service_centerDataSet.employees, ("Сотрудники", 3, employeesBindingSource) },
                { service_centerDataSet.manufacturers, ("Производители", 1, manufacturersBindingSource) },
                { service_centerDataSet.orders, ("Заказы", 0, ordersBindingSource) },
                { service_centerDataSet.order_parts, ("Запчасти в заказах", 0, orderpartsBindingSource) },
                { service_centerDataSet.order_devices, ("Техника в заказах", 0, orderdevicesBindingSource) },
                { service_centerDataSet.parts_warehouse, ("Склад запчастей", 0, partswarehouseBindingSource) },
                { service_centerDataSet.repair_parts, ("Запчасти", 1, repairpartsBindingSource) },
                { service_centerDataSet.required_parts, ("Необходимые запчасти", 0, requiredpartsBindingSource) },
                { service_centerDataSet.services, ("Услуги", 1, servicesBindingSource) },
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillAll();
            UpdateTablesList();
            UpdateRecentQueries();
        }

        public void UpdateTablesList()
        {
            таблицыToolStripMenuItem.DropDownItems.Clear();
            foreach (var entry in DataTableInfos)
            {
                var item = new ToolStripMenuItem(entry.Value.DisplayName);
                item.Click += (object _s, EventArgs _e) => addNewTabPage(entry.Key, entry.Value.DisplayName, entry.Value.BindingSource);
                таблицыToolStripMenuItem.DropDownItems.Insert(0, item);
            }
        }

        private void addNewTabPage(DataTable dt, string name, BindingSource bindingSource)
        {
            var tabPage = new TabPage(name)
            {
                UseVisualStyleBackColor = true
            };
            tabPage.Disposed += (object _s, EventArgs _e) =>
            {
                bindingSource.Filter = null;
                FilterForm.Dispose(dt.TableName);
            };
            var bindNav = new BindingNavigator(bindingSource)
            {
                GripStyle = ToolStripGripStyle.Hidden,
                ImageScalingSize = new Size(20, 20)
            };
            var filterBtn = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.filter,
                Text = "Фильтр"
            };
            var removeFilterBtn = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.removeFilter,
                Text = "Убрать фильтр",
                Enabled = false
            };
            filterBtn.Click += (object _s, EventArgs _e) => toggleFilterUI(filterBtn, removeFilterBtn, FilterForm.Show(name, dt, bindingSource));
            removeFilterBtn.Click += (object _s, EventArgs _e) =>
            {
                bindingSource.Filter = null;
                toggleFilterUI(filterBtn, removeFilterBtn, false);
                FilterForm.Dispose(dt.TableName);
            };
            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                DataSource = bindingSource,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            };
            dgv.DataError += Utility.DataGridView_SupressDataError;
            bindNav.Items.AddRange(new ToolStripItem[] { new ToolStripSeparator(), filterBtn, removeFilterBtn });
            tabPage.Controls.AddRange(new Control[] { dgv, bindNav });
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;
            foreach (DataRelation relation in dt.ParentRelations)
            {
                var cbColumn = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = relation.ChildColumns[0].ColumnName,
                    DataSource = relation.ParentTable,
                    DisplayMember = relation.ParentTable.Columns[DataTableInfos[relation.ParentTable].DisplayColumnIndex].ColumnName,
                    ValueMember = relation.ParentColumns[0].ColumnName
                };
                var dgvColumn = dgv.Columns[relation.ChildColumns[0].ColumnName];
                dgv.Columns.Insert(dgvColumn.Index, cbColumn);
                dgv.Columns.Remove(dgvColumn);
            }
            dgv.SetHeaderTextsFromDataColumnCaptions(dt);
        }

        public void UpdateRecentQueries()
        {
            if (Directory.Exists(SavedQueriesPath))
            {
                while(запросыToolStripMenuItem.DropDownItems[0] is ToolStripSeparator == false)
                {
                    запросыToolStripMenuItem.DropDownItems.RemoveAt(0);
                }
                foreach (string file in Directory.EnumerateFiles(SavedQueriesPath, $"*{Ext}")
                    .OrderBy(x => Directory.GetLastAccessTime(x)).Take(RECENT_QUERIES_COUNT))
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    var item = new ToolStripMenuItem(fileName);
                    item.Click += (object _s, EventArgs _e) => ExecuteQuery(File.ReadAllText(file), fileName);
                    запросыToolStripMenuItem.DropDownItems.Insert(0, item);
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Render a "x" mark at the end of the Tab caption. 
            var tabPage = tabControl.TabPages[e.Index];
            var tabRect = tabControl.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            var closeImage = Properties.Resources.close;
            e.Graphics.DrawImage(closeImage,
                (tabRect.Right - closeImage.Width),
                tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            var closeImageSize = Properties.Resources.close.Size;
            Rectangle r = tabControl.GetTabRect(tabControl.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - closeImageSize.Width, r.Top + (r.Height - closeImageSize.Height) / 2, 16, 16);
            if (closeButton.Contains(e.Location))
            {
                var tab = tabControl.SelectedTab;
                tabControl.TabPages.Remove(tab);
                tab.Dispose();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !showSaveDialog();
        }

        private bool showSaveDialog()
        {
            if (service_centerDataSet.HasChanges())
            {
                switch (MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes: updateAll(); break;
                    case DialogResult.Cancel: return false;
                }
            }
            return true;
        }

        private void updateAll()
        {
            try
            {
                servicesTableAdapter.Update(service_centerDataSet.services);
                required_partsTableAdapter.Update(service_centerDataSet.required_parts);
                repair_partsTableAdapter.Update(service_centerDataSet.repair_parts);
                parts_warehouseTableAdapter.Update(service_centerDataSet.parts_warehouse);
                ordersTableAdapter.Update(service_centerDataSet.orders);
                order_partsTableAdapter.Update(service_centerDataSet.order_parts);
                manufacturersTableAdapter.Update(service_centerDataSet.manufacturers);
                employeesTableAdapter.Update(service_centerDataSet.employees);
                devicesTableAdapter.Update(service_centerDataSet.devices);
                device_typesTableAdapter.Update(service_centerDataSet.device_types);
                clientsTableAdapter.Update(service_centerDataSet.clients);
                order_devicesTableAdapter.Update(service_centerDataSet.order_devices);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillAll()
        {
            try
            {
                servicesTableAdapter.Fill(service_centerDataSet.services);
                required_partsTableAdapter.Fill(service_centerDataSet.required_parts);
                repair_partsTableAdapter.Fill(service_centerDataSet.repair_parts);
                parts_warehouseTableAdapter.Fill(service_centerDataSet.parts_warehouse);
                ordersTableAdapter.Fill(service_centerDataSet.orders);
                order_partsTableAdapter.Fill(service_centerDataSet.order_parts);
                manufacturersTableAdapter.Fill(service_centerDataSet.manufacturers);
                employeesTableAdapter.Fill(service_centerDataSet.employees);
                devicesTableAdapter.Fill(service_centerDataSet.devices);
                device_typesTableAdapter.Fill(service_centerDataSet.device_types);
                clientsTableAdapter.Fill(service_centerDataSet.clients);
                order_devicesTableAdapter.Fill(service_centerDataSet.order_devices);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            updateAll();
        }

        private void toolStripButton_refresh_Click(object sender, EventArgs e)
        {
            if (showSaveDialog()) fillAll();
        }

        private void toggleFilterUI(ToolStripButton addFilterBtn, ToolStripButton removeFilterBtn, bool state)
        {
            addFilterBtn.Checked = state;
            removeFilterBtn.Enabled = state;
        }

        private void управлениеЗапросамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((queryManagerForm?.Created ?? false) == false) queryManagerForm = new QueryManagerForm(this);
            queryManagerForm.Show();
            queryManagerForm.Activate();
        }

        public void ExecuteQuery(string query, string name)
        {
            try
            {
                if(MySqlDB.GetInstance(service_centerDataSet, ConnectionString).ExecuteQuery(query, out int recordsAffected, out ArrayList result))
                {
                    if (recordsAffected >= 0) MessageBox.Show("Запрос выполнен успешно.\nКоличество затронутых записей: " + recordsAffected, name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        var tabPage = new TabPage(name);
                        tabPage.UseVisualStyleBackColor = true;
                        var dgv = new DataGridView
                        {
                            Dock = DockStyle.Fill,
                            DataSource = result,
                            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        };
                        tabPage.Controls.Add(dgv);
                        tabControl.TabPages.Add(tabPage);
                        tabControl.SelectedTab = tabPage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExecuteReport(string reportName, string reportFilePath, string query)
        {
            var reportViewer = new ReportViewerForm(reportName, reportFilePath, query, ConnectionString);
            reportViewer.Show();
        }

        private void приёмЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm();
            orderForm.Show();
        }

        private void выдачаТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var returnForm = new ReturnDevicesForm();
            returnForm.Show();
        }

        private void остаткиЗапчастейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteReport((sender as ToolStripMenuItem).Text, "../../Reports/PartsRemains.rdlc", ReportQueries.PartsRemains);
        }

        private void текущиеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteReport((sender as ToolStripMenuItem).Text, "../../Reports/CurrentOrders.rdlc", ReportQueries.CurrentOrders);
        }

        private void выполненныеЗаказыЗаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteReport((sender as ToolStripMenuItem).Text, "../../Reports/CompletedOrders.rdlc", ReportQueries.CompletedOrders);
        }

        private void выполнениеЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var executeForm = new ExecuteOrderForm();
            executeForm.Show();
        }

        private void закупкаЗапчастейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var partsForm = new PartsPurchaseForm();
            partsForm.Show();
        }
    }
}
