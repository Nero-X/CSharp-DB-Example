
namespace BBD_lab1
{
    partial class ExecuteOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_order = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_parts = new System.Windows.Forms.DataGridView();
            this.col_part_device = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_centerDataSet = new BBD_lab1.service_centerDataSet();
            this.col_part_part = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.repairpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_part_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_part_WH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_part_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_part_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.tb_employee = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_devices = new System.Windows.Forms.DataGridView();
            this.col_dev_device = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_dev_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dev_service = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_dev_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dev_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.clientsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.employeesTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.ordersTableAdapter();
            this.devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.devicesTableAdapter();
            this.partswarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parts_warehouseTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.parts_warehouseTableAdapter();
            this.repair_partsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.repair_partsTableAdapter();
            this.requiredpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.required_partsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.required_partsTableAdapter();
            this.servicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.servicesTableAdapter();
            this.orderdevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.order_devicesTableAdapter();
            this.orderpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_partsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.order_partsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairpartsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partswarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requiredpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderpartsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_order
            // 
            this.cb_order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_order.FormattingEnabled = true;
            this.cb_order.Location = new System.Drawing.Point(65, 12);
            this.cb_order.Name = "cb_order";
            this.cb_order.Size = new System.Drawing.Size(302, 24);
            this.cb_order.TabIndex = 0;
            this.cb_order.SelectedIndexChanged += new System.EventHandler(this.cb_order_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказ";
            // 
            // dgv_parts
            // 
            this.dgv_parts.AllowUserToAddRows = false;
            this.dgv_parts.AllowUserToDeleteRows = false;
            this.dgv_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_part_device,
            this.col_part_part,
            this.col_part_quantity,
            this.col_part_WH,
            this.col_part_price,
            this.col_part_sum});
            this.dgv_parts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_parts.Location = new System.Drawing.Point(3, 3);
            this.dgv_parts.Name = "dgv_parts";
            this.dgv_parts.ReadOnly = true;
            this.dgv_parts.RowHeadersWidth = 51;
            this.dgv_parts.RowTemplate.Height = 24;
            this.dgv_parts.Size = new System.Drawing.Size(762, 304);
            this.dgv_parts.TabIndex = 2;
            // 
            // col_part_device
            // 
            this.col_part_device.DataSource = this.devicesBindingSource;
            this.col_part_device.DisplayMember = "Dev_model";
            this.col_part_device.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_part_device.HeaderText = "Техника";
            this.col_part_device.MinimumWidth = 6;
            this.col_part_device.Name = "col_part_device";
            this.col_part_device.ReadOnly = true;
            this.col_part_device.ValueMember = "Dev_id";
            this.col_part_device.Width = 125;
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "devices";
            this.devicesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // service_centerDataSet
            // 
            this.service_centerDataSet.DataSetName = "service_centerDataSet";
            this.service_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // col_part_part
            // 
            this.col_part_part.DataSource = this.repairpartsBindingSource;
            this.col_part_part.DisplayMember = "Part_name";
            this.col_part_part.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_part_part.HeaderText = "Запчасть";
            this.col_part_part.MinimumWidth = 6;
            this.col_part_part.Name = "col_part_part";
            this.col_part_part.ReadOnly = true;
            this.col_part_part.ValueMember = "Part_id";
            this.col_part_part.Width = 125;
            // 
            // repairpartsBindingSource
            // 
            this.repairpartsBindingSource.DataMember = "repair_parts";
            this.repairpartsBindingSource.DataSource = this.service_centerDataSet;
            // 
            // col_part_quantity
            // 
            this.col_part_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_part_quantity.HeaderText = "Количество";
            this.col_part_quantity.MinimumWidth = 6;
            this.col_part_quantity.Name = "col_part_quantity";
            this.col_part_quantity.ReadOnly = true;
            this.col_part_quantity.Width = 115;
            // 
            // col_part_WH
            // 
            this.col_part_WH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_part_WH.HeaderText = "На складе";
            this.col_part_WH.MinimumWidth = 6;
            this.col_part_WH.Name = "col_part_WH";
            this.col_part_WH.ReadOnly = true;
            this.col_part_WH.Width = 105;
            // 
            // col_part_price
            // 
            this.col_part_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_part_price.HeaderText = "Цена";
            this.col_part_price.MinimumWidth = 6;
            this.col_part_price.Name = "col_part_price";
            this.col_part_price.ReadOnly = true;
            this.col_part_price.Width = 72;
            // 
            // col_part_sum
            // 
            this.col_part_sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_part_sum.HeaderText = "Сумма";
            this.col_part_sum.MinimumWidth = 6;
            this.col_part_sum.Name = "col_part_sum";
            this.col_part_sum.ReadOnly = true;
            this.col_part_sum.Width = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "рублей";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(64, 415);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(100, 22);
            this.tb_total.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Итого";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(713, 415);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(632, 415);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 16;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Исполнитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Клиент";
            // 
            // tb_client
            // 
            this.tb_client.Location = new System.Drawing.Point(74, 42);
            this.tb_client.Name = "tb_client";
            this.tb_client.ReadOnly = true;
            this.tb_client.Size = new System.Drawing.Size(293, 22);
            this.tb_client.TabIndex = 27;
            // 
            // tb_employee
            // 
            this.tb_employee.Location = new System.Drawing.Point(488, 42);
            this.tb_employee.Name = "tb_employee";
            this.tb_employee.ReadOnly = true;
            this.tb_employee.Size = new System.Drawing.Size(300, 22);
            this.tb_employee.TabIndex = 28;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 339);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_devices);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Техника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_devices
            // 
            this.dgv_devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dev_device,
            this.col_dev_quantity,
            this.col_dev_service,
            this.col_dev_price,
            this.col_dev_sum});
            this.dgv_devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_devices.Location = new System.Drawing.Point(3, 3);
            this.dgv_devices.Name = "dgv_devices";
            this.dgv_devices.RowHeadersWidth = 51;
            this.dgv_devices.RowTemplate.Height = 24;
            this.dgv_devices.Size = new System.Drawing.Size(762, 304);
            this.dgv_devices.TabIndex = 0;
            this.dgv_devices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_devices_CellValueChanged);
            this.dgv_devices.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_devices_RowsAdded);
            this.dgv_devices.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_devices_RowsRemoved);
            // 
            // col_dev_device
            // 
            this.col_dev_device.DataSource = this.devicesBindingSource;
            this.col_dev_device.DisplayMember = "Dev_model";
            this.col_dev_device.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_dev_device.HeaderText = "Техника";
            this.col_dev_device.MinimumWidth = 6;
            this.col_dev_device.Name = "col_dev_device";
            this.col_dev_device.ReadOnly = true;
            this.col_dev_device.ValueMember = "Dev_id";
            this.col_dev_device.Width = 125;
            // 
            // col_dev_quantity
            // 
            this.col_dev_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_dev_quantity.HeaderText = "Количество";
            this.col_dev_quantity.MinimumWidth = 6;
            this.col_dev_quantity.Name = "col_dev_quantity";
            this.col_dev_quantity.Width = 115;
            // 
            // col_dev_service
            // 
            this.col_dev_service.DataSource = this.servicesBindingSource;
            this.col_dev_service.DisplayMember = "Serv_name";
            this.col_dev_service.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_dev_service.HeaderText = "Услуга";
            this.col_dev_service.MinimumWidth = 125;
            this.col_dev_service.Name = "col_dev_service";
            this.col_dev_service.ReadOnly = true;
            this.col_dev_service.ValueMember = "Serv_id";
            this.col_dev_service.Width = 125;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // col_dev_price
            // 
            this.col_dev_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_dev_price.HeaderText = "Цена";
            this.col_dev_price.MinimumWidth = 6;
            this.col_dev_price.Name = "col_dev_price";
            this.col_dev_price.ReadOnly = true;
            this.col_dev_price.Width = 72;
            // 
            // col_dev_sum
            // 
            this.col_dev_sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_dev_sum.HeaderText = "Сумма";
            this.col_dev_sum.MinimumWidth = 6;
            this.col_dev_sum.Name = "col_dev_sum";
            this.col_dev_sum.ReadOnly = true;
            this.col_dev_sum.Width = 79;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_parts);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запчасти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.service_centerDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.service_centerDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // partswarehouseBindingSource
            // 
            this.partswarehouseBindingSource.DataMember = "parts_warehouse";
            this.partswarehouseBindingSource.DataSource = this.service_centerDataSet;
            // 
            // parts_warehouseTableAdapter
            // 
            this.parts_warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // repair_partsTableAdapter
            // 
            this.repair_partsTableAdapter.ClearBeforeFill = true;
            // 
            // requiredpartsBindingSource
            // 
            this.requiredpartsBindingSource.DataMember = "required_parts";
            this.requiredpartsBindingSource.DataSource = this.service_centerDataSet;
            // 
            // required_partsTableAdapter
            // 
            this.required_partsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // orderdevicesBindingSource
            // 
            this.orderdevicesBindingSource.DataMember = "order_devices";
            this.orderdevicesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // order_devicesTableAdapter
            // 
            this.order_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // orderpartsBindingSource
            // 
            this.orderpartsBindingSource.DataMember = "order_parts";
            this.orderpartsBindingSource.DataSource = this.service_centerDataSet;
            // 
            // order_partsTableAdapter
            // 
            this.order_partsTableAdapter.ClearBeforeFill = true;
            // 
            // ExecuteOrderForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_employee);
            this.Controls.Add(this.tb_client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_order);
            this.Name = "ExecuteOrderForm";
            this.Text = "Выполнить заказ";
            this.Load += new System.EventHandler(this.ExecuteOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairpartsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partswarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requiredpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderpartsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_parts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_client;
        private System.Windows.Forms.TextBox tb_employee;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_devices;
        private System.Windows.Forms.TabPage tabPage2;
        private service_centerDataSet service_centerDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private service_centerDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private service_centerDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private service_centerDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private service_centerDataSetTableAdapters.devicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.BindingSource partswarehouseBindingSource;
        private service_centerDataSetTableAdapters.parts_warehouseTableAdapter parts_warehouseTableAdapter;
        private System.Windows.Forms.BindingSource repairpartsBindingSource;
        private service_centerDataSetTableAdapters.repair_partsTableAdapter repair_partsTableAdapter;
        private System.Windows.Forms.BindingSource requiredpartsBindingSource;
        private service_centerDataSetTableAdapters.required_partsTableAdapter required_partsTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private service_centerDataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource orderdevicesBindingSource;
        private service_centerDataSetTableAdapters.order_devicesTableAdapter order_devicesTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_part_device;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_part_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_part_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_part_WH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_part_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_part_sum;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_dev_device;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dev_quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_dev_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dev_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dev_sum;
        private System.Windows.Forms.BindingSource orderpartsBindingSource;
        private service_centerDataSetTableAdapters.order_partsTableAdapter order_partsTableAdapter;
    }
}