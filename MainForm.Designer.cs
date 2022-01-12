
namespace BBD_lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.управлениеЗапросамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приёмЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнениеЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачаТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закупкаЗапчастейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остаткиЗапчастейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текущиеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненныеЗаказыЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.reportsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new BBD_lab1.reportsDataSet();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.service_centerDataSet = new BBD_lab1.service_centerDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.clientsTableAdapter();
            this.devicetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_typesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.device_typesTableAdapter();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.devicesTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.employeesTableAdapter();
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturersTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.manufacturersTableAdapter();
            this.orderpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_partsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.order_partsTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.ordersTableAdapter();
            this.partswarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parts_warehouseTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.parts_warehouseTableAdapter();
            this.repairpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repair_partsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.repair_partsTableAdapter();
            this.requiredpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.required_partsTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.required_partsTableAdapter();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.servicesTableAdapter();
            this.orderdevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_devicesTableAdapter = new BBD_lab1.service_centerDataSetTableAdapters.order_devicesTableAdapter();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partswarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requiredpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdevicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(957, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.управлениеЗапросамиToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // управлениеЗапросамиToolStripMenuItem
            // 
            this.управлениеЗапросамиToolStripMenuItem.Name = "управлениеЗапросамиToolStripMenuItem";
            this.управлениеЗапросамиToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.управлениеЗапросамиToolStripMenuItem.Text = "Управление запросами";
            this.управлениеЗапросамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеЗапросамиToolStripMenuItem_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приёмЗаказаToolStripMenuItem,
            this.выполнениеЗаказаToolStripMenuItem,
            this.выдачаТехникиToolStripMenuItem,
            this.закупкаЗапчастейToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // приёмЗаказаToolStripMenuItem
            // 
            this.приёмЗаказаToolStripMenuItem.Name = "приёмЗаказаToolStripMenuItem";
            this.приёмЗаказаToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.приёмЗаказаToolStripMenuItem.Text = "Приём заказа";
            this.приёмЗаказаToolStripMenuItem.Click += new System.EventHandler(this.приёмЗаказаToolStripMenuItem_Click);
            // 
            // выполнениеЗаказаToolStripMenuItem
            // 
            this.выполнениеЗаказаToolStripMenuItem.Name = "выполнениеЗаказаToolStripMenuItem";
            this.выполнениеЗаказаToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.выполнениеЗаказаToolStripMenuItem.Text = "Выполнение заказа";
            this.выполнениеЗаказаToolStripMenuItem.Click += new System.EventHandler(this.выполнениеЗаказаToolStripMenuItem_Click);
            // 
            // выдачаТехникиToolStripMenuItem
            // 
            this.выдачаТехникиToolStripMenuItem.Name = "выдачаТехникиToolStripMenuItem";
            this.выдачаТехникиToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.выдачаТехникиToolStripMenuItem.Text = "Выдача техники";
            this.выдачаТехникиToolStripMenuItem.Click += new System.EventHandler(this.выдачаТехникиToolStripMenuItem_Click);
            // 
            // закупкаЗапчастейToolStripMenuItem
            // 
            this.закупкаЗапчастейToolStripMenuItem.Name = "закупкаЗапчастейToolStripMenuItem";
            this.закупкаЗапчастейToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.закупкаЗапчастейToolStripMenuItem.Text = "Закупка запчастей";
            this.закупкаЗапчастейToolStripMenuItem.Click += new System.EventHandler(this.закупкаЗапчастейToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остаткиЗапчастейToolStripMenuItem,
            this.текущиеЗаказыToolStripMenuItem,
            this.выполненныеЗаказыЗаПериодToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // остаткиЗапчастейToolStripMenuItem
            // 
            this.остаткиЗапчастейToolStripMenuItem.Name = "остаткиЗапчастейToolStripMenuItem";
            this.остаткиЗапчастейToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.остаткиЗапчастейToolStripMenuItem.Text = "Остатки запчастей";
            this.остаткиЗапчастейToolStripMenuItem.Click += new System.EventHandler(this.остаткиЗапчастейToolStripMenuItem_Click);
            // 
            // текущиеЗаказыToolStripMenuItem
            // 
            this.текущиеЗаказыToolStripMenuItem.Name = "текущиеЗаказыToolStripMenuItem";
            this.текущиеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.текущиеЗаказыToolStripMenuItem.Text = "Текущие заказы";
            this.текущиеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.текущиеЗаказыToolStripMenuItem_Click);
            // 
            // выполненныеЗаказыЗаПериодToolStripMenuItem
            // 
            this.выполненныеЗаказыЗаПериодToolStripMenuItem.Name = "выполненныеЗаказыЗаПериодToolStripMenuItem";
            this.выполненныеЗаказыЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.выполненныеЗаказыЗаПериодToolStripMenuItem.Text = "Выполненные заказы за период";
            this.выполненныеЗаказыЗаПериодToolStripMenuItem.Click += new System.EventHandler(this.выполненныеЗаказыЗаПериодToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(91, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 56);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(16, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(957, 394);
            this.tabControl.TabIndex = 1;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // reportsDataSetBindingSource
            // 
            this.reportsDataSetBindingSource.DataSource = this.reportsDataSet;
            this.reportsDataSetBindingSource.Position = 0;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "reportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_save.Image")));
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_save.Text = "&Сохранить";
            this.toolStripButton_save.Click += new System.EventHandler(this.toolStripButton_save_Click);
            // 
            // toolStripButton_refresh
            // 
            this.toolStripButton_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_refresh.Image = global::BBD_lab1.Properties.Resources.refresh;
            this.toolStripButton_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_refresh.Name = "toolStripButton_refresh";
            this.toolStripButton_refresh.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_refresh.Text = "Обновить";
            this.toolStripButton_refresh.Click += new System.EventHandler(this.toolStripButton_refresh_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_save,
            this.toolStripButton_refresh});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(957, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // service_centerDataSet
            // 
            this.service_centerDataSet.DataSetName = "service_centerDataSet";
            this.service_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // devicetypesBindingSource
            // 
            this.devicetypesBindingSource.DataMember = "device_types";
            this.devicetypesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // device_typesTableAdapter
            // 
            this.device_typesTableAdapter.ClearBeforeFill = true;
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
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.service_centerDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "manufacturers";
            this.manufacturersBindingSource.DataSource = this.service_centerDataSet;
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.service_centerDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
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
            // repairpartsBindingSource
            // 
            this.repairpartsBindingSource.DataMember = "repair_parts";
            this.repairpartsBindingSource.DataSource = this.service_centerDataSet;
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
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.service_centerDataSet;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Сервисный центр";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partswarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requiredpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdevicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem управлениеЗапросамиToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private service_centerDataSet service_centerDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private service_centerDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource devicetypesBindingSource;
        private service_centerDataSetTableAdapters.device_typesTableAdapter device_typesTableAdapter;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private service_centerDataSetTableAdapters.devicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private service_centerDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private service_centerDataSetTableAdapters.manufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.BindingSource orderpartsBindingSource;
        private service_centerDataSetTableAdapters.order_partsTableAdapter order_partsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private service_centerDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource partswarehouseBindingSource;
        private service_centerDataSetTableAdapters.parts_warehouseTableAdapter parts_warehouseTableAdapter;
        private System.Windows.Forms.BindingSource repairpartsBindingSource;
        private service_centerDataSetTableAdapters.repair_partsTableAdapter repair_partsTableAdapter;
        private System.Windows.Forms.BindingSource requiredpartsBindingSource;
        private service_centerDataSetTableAdapters.required_partsTableAdapter required_partsTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private service_centerDataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource reportsDataSetBindingSource;
        private reportsDataSet reportsDataSet;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.ToolStripButton toolStripButton_refresh;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem приёмЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачаТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остаткиЗапчастейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текущиеЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненныеЗаказыЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнениеЗаказаToolStripMenuItem;
        private System.Windows.Forms.BindingSource orderdevicesBindingSource;
        private service_centerDataSetTableAdapters.order_devicesTableAdapter order_devicesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem закупкаЗапчастейToolStripMenuItem;
    }
}

