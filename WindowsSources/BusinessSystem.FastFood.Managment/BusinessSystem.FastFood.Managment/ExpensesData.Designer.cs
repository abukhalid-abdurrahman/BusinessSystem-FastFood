namespace BusinessSystem.FastFood.Managment
{
    partial class ExpensesData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesData));
            this.ExpenseDataControl = new System.Windows.Forms.DataGridView();
            this.NewTableBtn = new MetroFramework.Controls.MetroTile();
            this.LoadTableBtn = new MetroFramework.Controls.MetroTile();
            this.SaveTableBtn = new MetroFramework.Controls.MetroTile();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseDataControl
            // 
            this.ExpenseDataControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseDataControl.BackgroundColor = System.Drawing.Color.White;
            this.ExpenseDataControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseDataControl.Location = new System.Drawing.Point(23, 98);
            this.ExpenseDataControl.Name = "ExpenseDataControl";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            this.ExpenseDataControl.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpenseDataControl.Size = new System.Drawing.Size(723, 337);
            this.ExpenseDataControl.TabIndex = 0;
            // 
            // NewTableBtn
            // 
            this.NewTableBtn.Location = new System.Drawing.Point(23, 62);
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
            this.LoadTableBtn.Location = new System.Drawing.Point(112, 62);
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
            this.SaveTableBtn.Location = new System.Drawing.Point(201, 62);
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
            this.SearchTextBox.Location = new System.Drawing.Point(290, 61);
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
            this.pictureBox1.Location = new System.Drawing.Point(406, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ExpensesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SaveTableBtn);
            this.Controls.Add(this.LoadTableBtn);
            this.Controls.Add(this.NewTableBtn);
            this.Controls.Add(this.ExpenseDataControl);
            this.Name = "ExpensesData";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Расходы";
            this.Load += new System.EventHandler(this.ExpensesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExpenseDataControl;
        private MetroFramework.Controls.MetroTile NewTableBtn;
        private MetroFramework.Controls.MetroTile LoadTableBtn;
        private MetroFramework.Controls.MetroTile SaveTableBtn;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}