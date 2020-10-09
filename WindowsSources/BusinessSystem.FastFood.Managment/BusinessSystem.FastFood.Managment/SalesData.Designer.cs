namespace BusinessSystem.FastFood.Managment
{
    partial class SalesData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesData));
            this.SalesDataControl = new System.Windows.Forms.DataGridView();
            this.NewTableBtn = new MetroFramework.Controls.MetroTile();
            this.LoadTableBtn = new MetroFramework.Controls.MetroTile();
            this.SaveTableBtn = new MetroFramework.Controls.MetroTile();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SummLabel = new MetroFramework.Controls.MetroLabel();
            this.OrdesFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.GeneralSalesBtn = new MetroFramework.Controls.MetroTile();
            this.FileSystemWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OrdesFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesDataControl
            // 
            this.SalesDataControl.AllowUserToAddRows = false;
            this.SalesDataControl.AllowUserToDeleteRows = false;
            this.SalesDataControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesDataControl.BackgroundColor = System.Drawing.Color.White;
            this.SalesDataControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataControl.Location = new System.Drawing.Point(23, 163);
            this.SalesDataControl.Name = "SalesDataControl";
            this.SalesDataControl.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            this.SalesDataControl.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesDataControl.Size = new System.Drawing.Size(723, 246);
            this.SalesDataControl.TabIndex = 0;
            this.SalesDataControl.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SalesDataControl_RowsAdded);
            // 
            // NewTableBtn
            // 
            this.NewTableBtn.Location = new System.Drawing.Point(23, 124);
            this.NewTableBtn.Name = "NewTableBtn";
            this.NewTableBtn.Size = new System.Drawing.Size(83, 29);
            this.NewTableBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.NewTableBtn.TabIndex = 6;
            this.NewTableBtn.Text = "Создать";
            this.NewTableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewTableBtn.Click += new System.EventHandler(this.NewTableBtn_Click);
            // 
            // LoadTableBtn
            // 
            this.LoadTableBtn.Location = new System.Drawing.Point(112, 124);
            this.LoadTableBtn.Name = "LoadTableBtn";
            this.LoadTableBtn.Size = new System.Drawing.Size(83, 29);
            this.LoadTableBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.LoadTableBtn.TabIndex = 7;
            this.LoadTableBtn.Text = "Открыть";
            this.LoadTableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadTableBtn.Click += new System.EventHandler(this.LoadTableBtn_Click);
            // 
            // SaveTableBtn
            // 
            this.SaveTableBtn.Location = new System.Drawing.Point(201, 124);
            this.SaveTableBtn.Name = "SaveTableBtn";
            this.SaveTableBtn.Size = new System.Drawing.Size(83, 30);
            this.SaveTableBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.SaveTableBtn.TabIndex = 8;
            this.SaveTableBtn.Text = "Сохранить";
            this.SaveTableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveTableBtn.Click += new System.EventHandler(this.SaveTableBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.SearchTextBox.Location = new System.Drawing.Point(290, 123);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PromptText = "Поиск...";
            this.SearchTextBox.Size = new System.Drawing.Size(110, 30);
            this.SearchTextBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(406, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SummLabel
            // 
            this.SummLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SummLabel.AutoSize = true;
            this.SummLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SummLabel.Location = new System.Drawing.Point(23, 412);
            this.SummLabel.Name = "SummLabel";
            this.SummLabel.Size = new System.Drawing.Size(208, 25);
            this.SummLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.SummLabel.TabIndex = 12;
            this.SummLabel.Text = "Общая Сумма: 0 Сомони";
            this.SummLabel.UseStyleColors = true;
            // 
            // OrdesFlowLayout
            // 
            this.OrdesFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdesFlowLayout.AutoScroll = true;
            this.OrdesFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrdesFlowLayout.Controls.Add(this.GeneralSalesBtn);
            this.OrdesFlowLayout.Location = new System.Drawing.Point(23, 73);
            this.OrdesFlowLayout.Name = "OrdesFlowLayout";
            this.OrdesFlowLayout.Size = new System.Drawing.Size(723, 42);
            this.OrdesFlowLayout.TabIndex = 13;
            // 
            // GeneralSalesBtn
            // 
            this.GeneralSalesBtn.Location = new System.Drawing.Point(3, 3);
            this.GeneralSalesBtn.Name = "GeneralSalesBtn";
            this.GeneralSalesBtn.Size = new System.Drawing.Size(83, 29);
            this.GeneralSalesBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.GeneralSalesBtn.TabIndex = 7;
            this.GeneralSalesBtn.Text = "Общее";
            this.GeneralSalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GeneralSalesBtn.Click += new System.EventHandler(this.GeneralSalesBtn_Click);
            // 
            // FileSystemWatcher
            // 
            this.FileSystemWatcher.EnableRaisingEvents = true;
            this.FileSystemWatcher.Filter = "*.xml";
            this.FileSystemWatcher.Path = "temp";
            this.FileSystemWatcher.SynchronizingObject = this;
            this.FileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
            this.FileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Created);
            // 
            // SalesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 457);
            this.Controls.Add(this.OrdesFlowLayout);
            this.Controls.Add(this.SummLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SaveTableBtn);
            this.Controls.Add(this.LoadTableBtn);
            this.Controls.Add(this.NewTableBtn);
            this.Controls.Add(this.SalesDataControl);
            this.Name = "SalesData";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.ExpensesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OrdesFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesDataControl;
        private MetroFramework.Controls.MetroTile NewTableBtn;
        private MetroFramework.Controls.MetroTile LoadTableBtn;
        private MetroFramework.Controls.MetroTile SaveTableBtn;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel SummLabel;
        private System.Windows.Forms.FlowLayoutPanel OrdesFlowLayout;
        private MetroFramework.Controls.MetroTile GeneralSalesBtn;
        private System.IO.FileSystemWatcher FileSystemWatcher;
    }
}