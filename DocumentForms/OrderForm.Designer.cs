
namespace BBD_lab1
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.btn_findClient = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_device = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_findDevice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_findService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_findEmployee = new System.Windows.Forms.Button();
            this.cb_employee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_centerDataSet = new BBD_lab1.service_centerDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.devicesTableAdapter();
            this.servicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.servicesTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.clientsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // cb_client
            // 
            this.cb_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(74, 12);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(268, 24);
            this.cb_client.TabIndex = 1;
            // 
            // btn_findClient
            // 
            this.btn_findClient.Image = global::BBD_lab1.Properties.Resources.search;
            this.btn_findClient.Location = new System.Drawing.Point(348, 12);
            this.btn_findClient.Name = "btn_findClient";
            this.btn_findClient.Size = new System.Drawing.Size(23, 23);
            this.btn_findClient.TabIndex = 6;
            this.btn_findClient.UseVisualStyleBackColor = true;
            this.btn_findClient.Click += new System.EventHandler(this.btn_findClient_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(710, 415);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(629, 415);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_device,
            this.col_findDevice,
            this.col_quantity,
            this.col_service,
            this.col_findService,
            this.col_price,
            this.col_sum});
            this.dgv.Location = new System.Drawing.Point(15, 42);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(770, 367);
            this.dgv.TabIndex = 9;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_RowsRemoved);
            // 
            // col_device
            // 
            this.col_device.DataSource = this.devicesBindingSource;
            this.col_device.DisplayMember = "Dev_model";
            this.col_device.HeaderText = "Техника";
            this.col_device.MinimumWidth = 6;
            this.col_device.Name = "col_device";
            this.col_device.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_device.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_device.ValueMember = "Dev_id";
            this.col_device.Width = 91;
            // 
            // col_findDevice
            // 
            this.col_findDevice.HeaderText = "Найти";
            this.col_findDevice.MinimumWidth = 6;
            this.col_findDevice.Name = "col_findDevice";
            this.col_findDevice.Text = "";
            this.col_findDevice.Width = 55;
            // 
            // col_quantity
            // 
            this.col_quantity.HeaderText = "Количество";
            this.col_quantity.MinimumWidth = 6;
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.Width = 115;
            // 
            // col_service
            // 
            this.col_service.DataSource = this.servicesBindingSource;
            this.col_service.DisplayMember = "Serv_name";
            this.col_service.HeaderText = "Услуга";
            this.col_service.MinimumWidth = 6;
            this.col_service.Name = "col_service";
            this.col_service.ValueMember = "Serv_id";
            this.col_service.Width = 58;
            // 
            // col_findService
            // 
            this.col_findService.HeaderText = "Найти";
            this.col_findService.MinimumWidth = 6;
            this.col_findService.Name = "col_findService";
            this.col_findService.Text = "";
            this.col_findService.Width = 55;
            // 
            // col_price
            // 
            this.col_price.HeaderText = "Цена";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            this.col_price.Width = 72;
            // 
            // col_sum
            // 
            this.col_sum.HeaderText = "Сумма";
            this.col_sum.MinimumWidth = 6;
            this.col_sum.Name = "col_sum";
            this.col_sum.ReadOnly = true;
            this.col_sum.Width = 79;
            // 
            // btn_findEmployee
            // 
            this.btn_findEmployee.Image = global::BBD_lab1.Properties.Resources.search;
            this.btn_findEmployee.Location = new System.Drawing.Point(762, 12);
            this.btn_findEmployee.Name = "btn_findEmployee";
            this.btn_findEmployee.Size = new System.Drawing.Size(23, 23);
            this.btn_findEmployee.TabIndex = 12;
            this.btn_findEmployee.UseVisualStyleBackColor = true;
            this.btn_findEmployee.Click += new System.EventHandler(this.btn_findEmployee_Click);
            // 
            // cb_employee
            // 
            this.cb_employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_employee.FormattingEnabled = true;
            this.cb_employee.Location = new System.Drawing.Point(488, 11);
            this.cb_employee.Name = "cb_employee";
            this.cb_employee.Size = new System.Drawing.Size(268, 24);
            this.cb_employee.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Исполнитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Итого";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(64, 415);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(100, 22);
            this.tb_total.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "рублей";
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
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
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
            // OrderForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.cb_client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_findEmployee);
            this.Controls.Add(this.cb_employee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_findClient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Button btn_findClient;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dgv;
        private service_centerDataSet service_centerDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private service_centerDataSetTableAdapters.devicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private service_centerDataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private service_centerDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button btn_findEmployee;
        private System.Windows.Forms.ComboBox cb_employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_device;
        private System.Windows.Forms.DataGridViewButtonColumn col_findDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_service;
        private System.Windows.Forms.DataGridViewButtonColumn col_findService;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private service_centerDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
    }
}