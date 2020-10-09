namespace BusinessSystem.FastFood.Managment
{
    partial class OrdersDescription
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
            this.ApplyBtn = new MetroFramework.Controls.MetroTile();
            this.RusRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.TajikRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.EngRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.OrdersTypeList = new System.Windows.Forms.ListBox();
            this.OrdersNameList = new System.Windows.Forms.ListBox();
            this.OrderNameLang = new MetroFramework.Controls.MetroTextBox();
            this.OrderCost = new MetroFramework.Controls.MetroTextBox();
            this.OrderDescroptLang = new MetroFramework.Controls.MetroTextBox();
            this.MainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(673, 415);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(119, 37);
            this.ApplyBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.ApplyBtn.TabIndex = 0;
            this.ApplyBtn.Text = "Принять";
            this.ApplyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // RusRadioBtn
            // 
            this.RusRadioBtn.AutoSize = true;
            this.RusRadioBtn.Checked = true;
            this.RusRadioBtn.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.RusRadioBtn.Location = new System.Drawing.Point(23, 427);
            this.RusRadioBtn.Name = "RusRadioBtn";
            this.RusRadioBtn.Size = new System.Drawing.Size(92, 25);
            this.RusRadioBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.RusRadioBtn.TabIndex = 1;
            this.RusRadioBtn.TabStop = true;
            this.RusRadioBtn.Text = "Русский";
            this.RusRadioBtn.UseStyleColors = true;
            this.RusRadioBtn.UseVisualStyleBackColor = true;
            this.RusRadioBtn.CheckedChanged += new System.EventHandler(this.RusRadioBtn_CheckedChanged);
            // 
            // TajikRadioBtn
            // 
            this.TajikRadioBtn.AutoSize = true;
            this.TajikRadioBtn.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.TajikRadioBtn.Location = new System.Drawing.Point(121, 427);
            this.TajikRadioBtn.Name = "TajikRadioBtn";
            this.TajikRadioBtn.Size = new System.Drawing.Size(123, 25);
            this.TajikRadioBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.TajikRadioBtn.TabIndex = 2;
            this.TajikRadioBtn.Text = "Таджитский";
            this.TajikRadioBtn.UseStyleColors = true;
            this.TajikRadioBtn.UseVisualStyleBackColor = true;
            this.TajikRadioBtn.CheckedChanged += new System.EventHandler(this.RusRadioBtn_CheckedChanged);
            // 
            // EngRadioBtn
            // 
            this.EngRadioBtn.AutoSize = true;
            this.EngRadioBtn.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.EngRadioBtn.Location = new System.Drawing.Point(250, 427);
            this.EngRadioBtn.Name = "EngRadioBtn";
            this.EngRadioBtn.Size = new System.Drawing.Size(123, 25);
            this.EngRadioBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.EngRadioBtn.TabIndex = 3;
            this.EngRadioBtn.Text = "Английский";
            this.EngRadioBtn.UseStyleColors = true;
            this.EngRadioBtn.UseVisualStyleBackColor = true;
            this.EngRadioBtn.CheckedChanged += new System.EventHandler(this.RusRadioBtn_CheckedChanged);
            // 
            // OrdersTypeList
            // 
            this.OrdersTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersTypeList.ForeColor = System.Drawing.Color.Purple;
            this.OrdersTypeList.FormattingEnabled = true;
            this.OrdersTypeList.ItemHeight = 20;
            this.OrdersTypeList.Location = new System.Drawing.Point(23, 63);
            this.OrdersTypeList.Name = "OrdersTypeList";
            this.OrdersTypeList.Size = new System.Drawing.Size(376, 184);
            this.OrdersTypeList.TabIndex = 4;
            this.OrdersTypeList.SelectedIndexChanged += new System.EventHandler(this.OrdersTypeList_SelectedIndexChanged);
            // 
            // OrdersNameList
            // 
            this.OrdersNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersNameList.ForeColor = System.Drawing.Color.Purple;
            this.OrdersNameList.FormattingEnabled = true;
            this.OrdersNameList.ItemHeight = 20;
            this.OrdersNameList.Location = new System.Drawing.Point(405, 63);
            this.OrdersNameList.Name = "OrdersNameList";
            this.OrdersNameList.Size = new System.Drawing.Size(387, 184);
            this.OrdersNameList.TabIndex = 5;
            this.OrdersNameList.SelectedIndexChanged += new System.EventHandler(this.OrdersNameList_SelectedIndexChanged);
            // 
            // OrderNameLang
            // 
            this.OrderNameLang.Location = new System.Drawing.Point(23, 268);
            this.OrderNameLang.Name = "OrderNameLang";
            this.OrderNameLang.Size = new System.Drawing.Size(376, 23);
            this.OrderNameLang.TabIndex = 6;
            this.OrderNameLang.Text = "Имя";
            this.OrderNameLang.Click += new System.EventHandler(this.OrderNameLang_Click);
            // 
            // OrderCost
            // 
            this.OrderCost.Location = new System.Drawing.Point(23, 297);
            this.OrderCost.Name = "OrderCost";
            this.OrderCost.Size = new System.Drawing.Size(376, 23);
            this.OrderCost.TabIndex = 7;
            this.OrderCost.Text = "Цена";
            this.OrderCost.Click += new System.EventHandler(this.OrderNameLang_Click);
            // 
            // OrderDescroptLang
            // 
            this.OrderDescroptLang.Location = new System.Drawing.Point(23, 326);
            this.OrderDescroptLang.Multiline = true;
            this.OrderDescroptLang.Name = "OrderDescroptLang";
            this.OrderDescroptLang.Size = new System.Drawing.Size(376, 77);
            this.OrderDescroptLang.TabIndex = 8;
            this.OrderDescroptLang.Text = "Описание";
            this.OrderDescroptLang.Click += new System.EventHandler(this.OrderNameLang_Click);
            // 
            // MainImage
            // 
            this.MainImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainImage.Location = new System.Drawing.Point(405, 268);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(162, 135);
            this.MainImage.TabIndex = 9;
            this.MainImage.TabStop = false;
            this.MainImage.WaitOnLoad = true;
            this.MainImage.Click += new System.EventHandler(this.MainImage_Click);
            this.MainImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainImage_DragDrop);
            this.MainImage.DragOver += new System.Windows.Forms.DragEventHandler(this.MainImage_DragOver);
            // 
            // OrdersDescription
            // 
            this.AcceptButton = this.ApplyBtn;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 475);
            this.Controls.Add(this.MainImage);
            this.Controls.Add(this.OrderDescroptLang);
            this.Controls.Add(this.OrderCost);
            this.Controls.Add(this.OrderNameLang);
            this.Controls.Add(this.OrdersNameList);
            this.Controls.Add(this.OrdersTypeList);
            this.Controls.Add(this.EngRadioBtn);
            this.Controls.Add(this.TajikRadioBtn);
            this.Controls.Add(this.RusRadioBtn);
            this.Controls.Add(this.ApplyBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 475);
            this.MinimumSize = new System.Drawing.Size(815, 475);
            this.Name = "OrdersDescription";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Описание заказов";
            this.Load += new System.EventHandler(this.OrdersDescription_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainImage_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainImage_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile ApplyBtn;
        private MetroFramework.Controls.MetroRadioButton RusRadioBtn;
        private MetroFramework.Controls.MetroRadioButton TajikRadioBtn;
        private MetroFramework.Controls.MetroRadioButton EngRadioBtn;
        private System.Windows.Forms.ListBox OrdersTypeList;
        private System.Windows.Forms.ListBox OrdersNameList;
        private MetroFramework.Controls.MetroTextBox OrderNameLang;
        private MetroFramework.Controls.MetroTextBox OrderCost;
        private MetroFramework.Controls.MetroTextBox OrderDescroptLang;
        private System.Windows.Forms.PictureBox MainImage;
    }
}