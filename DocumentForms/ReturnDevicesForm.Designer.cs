
namespace BBD_lab1
{
    partial class ReturnDevicesForm
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
            this.cb_order = new System.Windows.Forms.ComboBox();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.btn_findClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.service_centerDataSet = new BBD_lab1.service_centerDataSet();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.devicesTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.clientsTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.ordersTableAdapter();
            this.orderdevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.order_devicesTableAdapter();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.servicesTableAdapter();
            this.col_device = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_service = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Заказ";
            // 
            // cb_order
            // 
            this.cb_order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_order.FormattingEnabled = true;
            this.cb_order.Location = new System.Drawing.Point(73, 42);
            this.cb_order.Name = "cb_order";
            this.cb_order.Size = new System.Drawing.Size(447, 24);
            this.cb_order.TabIndex = 28;
            this.cb_order.SelectedIndexChanged += new System.EventHandler(this.cb_order_SelectedIndexChanged);
            // 
            // cb_client
            // 
            this.cb_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(73, 12);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(418, 24);
            this.cb_client.TabIndex = 31;
            this.cb_client.SelectedIndexChanged += new System.EventHandler(this.cb_client_SelectedIndexChanged);
            // 
            // btn_findClient
            // 
            this.btn_findClient.Image = global::BBD_lab1.Properties.Resources.search;
            this.btn_findClient.Location = new System.Drawing.Point(497, 12);
            this.btn_findClient.Name = "btn_findClient";
            this.btn_findClient.Size = new System.Drawing.Size(23, 23);
            this.btn_findClient.TabIndex = 32;
            this.btn_findClient.UseVisualStyleBackColor = true;
            this.btn_findClient.Click += new System.EventHandler(this.btn_findClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Клиент";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_device,
            this.col_service,
            this.col_quantity});
            this.dgv.Location = new System.Drawing.Point(12, 72);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(508, 208);
            this.dgv.TabIndex = 33;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(445, 286);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 35;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(364, 286);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 34;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // service_centerDataSet
            // 
            this.service_centerDataSet.DataSetName = "service_centerDataSet";
            this.service_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "devices";
            this.devicesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.service_centerDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
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
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // col_device
            // 
            this.col_device.DataSource = this.devicesBindingSource;
            this.col_device.DisplayMember = "Dev_model";
            this.col_device.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_device.HeaderText = "Техника";
            this.col_device.MinimumWidth = 6;
            this.col_device.Name = "col_device";
            this.col_device.ReadOnly = true;
            this.col_device.ValueMember = "Dev_id";
            this.col_device.Width = 125;
            // 
            // col_service
            // 
            this.col_service.DataSource = this.servicesBindingSource;
            this.col_service.DisplayMember = "Serv_name";
            this.col_service.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_service.HeaderText = "Услуга";
            this.col_service.MinimumWidth = 6;
            this.col_service.Name = "col_service";
            this.col_service.ReadOnly = true;
            this.col_service.ValueMember = "Serv_id";
            this.col_service.Width = 125;
            // 
            // col_quantity
            // 
            this.col_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_quantity.HeaderText = "Количество";
            this.col_quantity.MinimumWidth = 6;
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.Width = 115;
            // 
            // ReturnDevicesForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(532, 320);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cb_client);
            this.Controls.Add(this.btn_findClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnDevicesForm";
            this.Text = "Выдача техники";
            this.Load += new System.EventHandler(this.ReturnDevicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_order;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Button btn_findClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private service_centerDataSet service_centerDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private service_centerDataSetTableAdapters.devicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private service_centerDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private service_centerDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource orderdevicesBindingSource;
        private service_centerDataSetTableAdapters.order_devicesTableAdapter order_devicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private service_centerDataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_device;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
    }
}