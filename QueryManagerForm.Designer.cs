
namespace BBD_lab1
{
    partial class QueryManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryManagerForm));
            this.comboBox_queryName = new System.Windows.Forms.ComboBox();
            this.textBox_queryText = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_exec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_queryName
            // 
            this.comboBox_queryName.FormattingEnabled = true;
            this.comboBox_queryName.Location = new System.Drawing.Point(12, 12);
            this.comboBox_queryName.Name = "comboBox_queryName";
            this.comboBox_queryName.Size = new System.Drawing.Size(490, 24);
            this.comboBox_queryName.TabIndex = 0;
            this.comboBox_queryName.SelectedIndexChanged += new System.EventHandler(this.comboBox_queryName_SelectedIndexChanged);
            // 
            // textBox_queryText
            // 
            this.textBox_queryText.Location = new System.Drawing.Point(12, 42);
            this.textBox_queryText.Multiline = true;
            this.textBox_queryText.Name = "textBox_queryText";
            this.textBox_queryText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_queryText.Size = new System.Drawing.Size(610, 253);
            this.textBox_queryText.TabIndex = 4;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(568, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(24, 24);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(538, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(24, 24);
            this.btn_save.TabIndex = 1;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Image = global::BBD_lab1.Properties.Resources.newFile;
            this.btn_new.Location = new System.Drawing.Point(508, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(24, 24);
            this.btn_new.TabIndex = 5;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_exec
            // 
            this.btn_exec.Image = ((System.Drawing.Image)(resources.GetObject("btn_exec.Image")));
            this.btn_exec.Location = new System.Drawing.Point(598, 12);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(24, 24);
            this.btn_exec.TabIndex = 6;
            this.btn_exec.UseVisualStyleBackColor = true;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // QueryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 307);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.textBox_queryText);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.comboBox_queryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QueryManagerForm";
            this.Text = "Управление сохранёнными запросами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryManagerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QueryManagerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_queryName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textBox_queryText;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_exec;
    }
}