namespace BusinessSystem.FastFood.Managment
{
    partial class MenuList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuList));
            this.MenuDataControl = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.ChangeStatusBtn = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuDataControl
            // 
            this.MenuDataControl.AllowUserToAddRows = false;
            this.MenuDataControl.AllowUserToDeleteRows = false;
            this.MenuDataControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuDataControl.BackgroundColor = System.Drawing.Color.White;
            this.MenuDataControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDataControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.StatusColumn});
            this.MenuDataControl.Location = new System.Drawing.Point(23, 98);
            this.MenuDataControl.Name = "MenuDataControl";
            this.MenuDataControl.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            this.MenuDataControl.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.MenuDataControl.Size = new System.Drawing.Size(723, 337);
            this.MenuDataControl.TabIndex = 0;
            this.MenuDataControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuDataControl_CellClick);
            this.MenuDataControl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuDataControl_CellDoubleClick);
            this.MenuDataControl.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MenuDataControl_RowHeaderMouseClick);
            this.MenuDataControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuDataControl_KeyDown);
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.SearchTextBox.Location = new System.Drawing.Point(154, 61);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PromptText = "Поиск...";
            this.SearchTextBox.Size = new System.Drawing.Size(110, 30);
            this.SearchTextBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.UseStyleColors = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.Location = new System.Drawing.Point(270, 59);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(33, 32);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.TabStop = false;
            this.SearchButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChangeStatusBtn
            // 
            this.ChangeStatusBtn.Location = new System.Drawing.Point(23, 62);
            this.ChangeStatusBtn.Name = "ChangeStatusBtn";
            this.ChangeStatusBtn.Size = new System.Drawing.Size(123, 29);
            this.ChangeStatusBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.ChangeStatusBtn.TabIndex = 6;
            this.ChangeStatusBtn.Text = "Изменить статус";
            this.ChangeStatusBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeStatusBtn.Click += new System.EventHandler(this.ChangeStatusBtn_Click);
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 457);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ChangeStatusBtn);
            this.Controls.Add(this.MenuDataControl);
            this.Name = "MenuList";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Статус Меню";
            this.Load += new System.EventHandler(this.ExpensesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MenuDataControl;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private System.Windows.Forms.PictureBox SearchButton;
        private MetroFramework.Controls.MetroTile ChangeStatusBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}