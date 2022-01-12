
namespace BBD_lab1
{
    partial class PartsPurchaseForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_device = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_centerDataSet = new BBD_lab1.service_centerDataSet();
            this.col_findDevice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_part = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.repairpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_findPart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.devicesTableAdapter();
            this.repair_partsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.repair_partsTableAdapter();
            this.partswarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parts_warehouseTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.parts_warehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partswarehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_device,
            this.col_findDevice,
            this.col_part,
            this.col_findPart,
            this.col_quantity,
            this.col_price,
            this.col_sum});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(811, 288);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_RowsRemoved);
            // 
            // col_device
            // 
            this.col_device.DataSource = this.devicesBindingSource;
            this.col_device.DisplayMember = "Dev_model";
            this.col_device.HeaderText = "Техника";
            this.col_device.MinimumWidth = 6;
            this.col_device.Name = "col_device";
            this.col_device.ValueMember = "Dev_id";
            this.col_device.Width = 125;
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
            // col_findDevice
            // 
            this.col_findDevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_findDevice.HeaderText = "Найти";
            this.col_findDevice.MinimumWidth = 6;
            this.col_findDevice.Name = "col_findDevice";
            this.col_findDevice.Width = 55;
            // 
            // col_part
            // 
            this.col_part.DataSource = this.repairpartsBindingSource;
            this.col_part.DisplayMember = "Part_name";
            this.col_part.HeaderText = "Запчасть";
            this.col_part.MinimumWidth = 6;
            this.col_part.Name = "col_part";
            this.col_part.ValueMember = "Part_id";
            this.col_part.Width = 125;
            // 
            // repairpartsBindingSource
            // 
            this.repairpartsBindingSource.DataMember = "repair_parts";
            this.repairpartsBindingSource.DataSource = this.service_centerDataSet;
            // 
            // col_findPart
            // 
            this.col_findPart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_findPart.HeaderText = "Найти";
            this.col_findPart.MinimumWidth = 6;
            this.col_findPart.Name = "col_findPart";
            this.col_findPart.Width = 55;
            // 
            // col_quantity
            // 
            this.col_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_quantity.HeaderText = "Количество";
            this.col_quantity.MinimumWidth = 6;
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.Width = 115;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price.HeaderText = "Цена";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.Width = 72;
            // 
            // col_sum
            // 
            this.col_sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_sum.HeaderText = "Сумма";
            this.col_sum.MinimumWidth = 6;
            this.col_sum.Name = "col_sum";
            this.col_sum.ReadOnly = true;
            this.col_sum.Width = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "рублей";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(65, 306);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(100, 22);
            this.tb_total.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Итого";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(748, 306);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(667, 306);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 21;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // repair_partsTableAdapter
            // 
            this.repair_partsTableAdapter.ClearBeforeFill = true;
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
            // PartsPurchaseForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(835, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartsPurchaseForm";
            this.Text = "Закупка запчастей";
            this.Load += new System.EventHandler(this.PartsPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partswarehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private service_centerDataSet service_centerDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private service_centerDataSetTableAdapters.devicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.BindingSource repairpartsBindingSource;
        private service_centerDataSetTableAdapters.repair_partsTableAdapter repair_partsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_device;
        private System.Windows.Forms.DataGridViewButtonColumn col_findDevice;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_part;
        private System.Windows.Forms.DataGridViewButtonColumn col_findPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sum;
        private System.Windows.Forms.BindingSource partswarehouseBindingSource;
        private service_centerDataSetTableAdapters.parts_warehouseTableAdapter parts_warehouseTableAdapter;
    }
}