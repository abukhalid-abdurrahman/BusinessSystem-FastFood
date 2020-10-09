namespace BusinessSystem.FastFood.Managment
{
    partial class SettingsWindow
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
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.AreasPage = new MetroFramework.Controls.MetroTabPage();
            this.InsertData = new MetroFramework.Controls.MetroTile();
            this.ClientAreaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AreaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ClientAreaListBox = new System.Windows.Forms.ListBox();
            this.AreasListBox = new System.Windows.Forms.ListBox();
            this.OrdersPage = new MetroFramework.Controls.MetroTabPage();
            this.OrdersSummaryBtn = new MetroFramework.Controls.MetroTile();
            this.OrdersNameMenu = new MetroFramework.Controls.MetroTile();
            this.CreateOrdersName = new MetroFramework.Controls.MetroTile();
            this.TabControl.SuspendLayout();
            this.AreasPage.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AreasPage);
            this.TabControl.Controls.Add(this.OrdersPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(20, 60);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(775, 395);
            this.TabControl.Style = MetroFramework.MetroColorStyle.Purple;
            this.TabControl.TabIndex = 0;
            this.TabControl.UseStyleColors = true;
            // 
            // AreasPage
            // 
            this.AreasPage.Controls.Add(this.InsertData);
            this.AreasPage.Controls.Add(this.ClientAreaTextBox);
            this.AreasPage.Controls.Add(this.AreaTextBox);
            this.AreasPage.Controls.Add(this.ClientAreaListBox);
            this.AreasPage.Controls.Add(this.AreasListBox);
            this.AreasPage.HorizontalScrollbarBarColor = true;
            this.AreasPage.Location = new System.Drawing.Point(4, 35);
            this.AreasPage.Name = "AreasPage";
            this.AreasPage.Size = new System.Drawing.Size(767, 356);
            this.AreasPage.Style = MetroFramework.MetroColorStyle.Silver;
            this.AreasPage.TabIndex = 0;
            this.AreasPage.Text = "Зоны";
            this.AreasPage.VerticalScrollbarBarColor = true;
            // 
            // InsertData
            // 
            this.InsertData.Location = new System.Drawing.Point(3, 276);
            this.InsertData.Name = "InsertData";
            this.InsertData.Size = new System.Drawing.Size(761, 38);
            this.InsertData.Style = MetroFramework.MetroColorStyle.Purple;
            this.InsertData.TabIndex = 7;
            this.InsertData.Text = "Добавить";
            this.InsertData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertData.Click += new System.EventHandler(this.InsertData_Click);
            // 
            // ClientAreaTextBox
            // 
            this.ClientAreaTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ClientAreaTextBox.Location = new System.Drawing.Point(382, 237);
            this.ClientAreaTextBox.Multiline = true;
            this.ClientAreaTextBox.Name = "ClientAreaTextBox";
            this.ClientAreaTextBox.Size = new System.Drawing.Size(382, 33);
            this.ClientAreaTextBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.ClientAreaTextBox.TabIndex = 6;
            this.ClientAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientAreaTextBox.UseStyleColors = true;
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.AreaTextBox.Location = new System.Drawing.Point(3, 237);
            this.AreaTextBox.Multiline = true;
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(373, 33);
            this.AreaTextBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.AreaTextBox.TabIndex = 4;
            this.AreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AreaTextBox.UseStyleColors = true;
            // 
            // ClientAreaListBox
            // 
            this.ClientAreaListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAreaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientAreaListBox.ForeColor = System.Drawing.Color.Purple;
            this.ClientAreaListBox.FormattingEnabled = true;
            this.ClientAreaListBox.ItemHeight = 16;
            this.ClientAreaListBox.Location = new System.Drawing.Point(385, 19);
            this.ClientAreaListBox.Name = "ClientAreaListBox";
            this.ClientAreaListBox.Size = new System.Drawing.Size(382, 212);
            this.ClientAreaListBox.TabIndex = 3;
            // 
            // AreasListBox
            // 
            this.AreasListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AreasListBox.ForeColor = System.Drawing.Color.Purple;
            this.AreasListBox.FormattingEnabled = true;
            this.AreasListBox.ItemHeight = 16;
            this.AreasListBox.Location = new System.Drawing.Point(3, 19);
            this.AreasListBox.Name = "AreasListBox";
            this.AreasListBox.Size = new System.Drawing.Size(373, 212);
            this.AreasListBox.TabIndex = 2;
            this.AreasListBox.SelectedIndexChanged += new System.EventHandler(this.AreasListBox_SelectedIndexChanged);
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.OrdersSummaryBtn);
            this.OrdersPage.Controls.Add(this.OrdersNameMenu);
            this.OrdersPage.Controls.Add(this.CreateOrdersName);
            this.OrdersPage.HorizontalScrollbarBarColor = true;
            this.OrdersPage.Location = new System.Drawing.Point(4, 35);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Size = new System.Drawing.Size(767, 356);
            this.OrdersPage.TabIndex = 1;
            this.OrdersPage.Text = "Заказы";
            this.OrdersPage.VerticalScrollbarBarColor = true;
            // 
            // OrdersSummaryBtn
            // 
            this.OrdersSummaryBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OrdersSummaryBtn.Location = new System.Drawing.Point(3, 65);
            this.OrdersSummaryBtn.Name = "OrdersSummaryBtn";
            this.OrdersSummaryBtn.Size = new System.Drawing.Size(229, 215);
            this.OrdersSummaryBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.OrdersSummaryBtn.TabIndex = 4;
            this.OrdersSummaryBtn.Text = "Описание заказов";
            this.OrdersSummaryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrdersSummaryBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.OrdersSummaryBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.OrdersSummaryBtn.Click += new System.EventHandler(this.OrdersSummaryBtn_Click);
            // 
            // OrdersNameMenu
            // 
            this.OrdersNameMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersNameMenu.Location = new System.Drawing.Point(256, 65);
            this.OrdersNameMenu.Name = "OrdersNameMenu";
            this.OrdersNameMenu.Size = new System.Drawing.Size(229, 215);
            this.OrdersNameMenu.Style = MetroFramework.MetroColorStyle.Purple;
            this.OrdersNameMenu.TabIndex = 3;
            this.OrdersNameMenu.Text = "Заказы в меню";
            this.OrdersNameMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrdersNameMenu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.OrdersNameMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.OrdersNameMenu.Click += new System.EventHandler(this.OrdersNameMenu_Click);
            // 
            // CreateOrdersName
            // 
            this.CreateOrdersName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreateOrdersName.Location = new System.Drawing.Point(505, 65);
            this.CreateOrdersName.Name = "CreateOrdersName";
            this.CreateOrdersName.Size = new System.Drawing.Size(229, 215);
            this.CreateOrdersName.Style = MetroFramework.MetroColorStyle.Purple;
            this.CreateOrdersName.TabIndex = 2;
            this.CreateOrdersName.Text = "Типы заказов в меню";
            this.CreateOrdersName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateOrdersName.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CreateOrdersName.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.CreateOrdersName.Click += new System.EventHandler(this.CreateOrdersName_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 475);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 475);
            this.MinimumSize = new System.Drawing.Size(815, 475);
            this.Name = "SettingsWindow";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.TabControl.ResumeLayout(false);
            this.AreasPage.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage AreasPage;
        private System.Windows.Forms.ListBox ClientAreaListBox;
        private System.Windows.Forms.ListBox AreasListBox;
        private MetroFramework.Controls.MetroTextBox ClientAreaTextBox;
        private MetroFramework.Controls.MetroTextBox AreaTextBox;
        private MetroFramework.Controls.MetroTile InsertData;
        private MetroFramework.Controls.MetroTabPage OrdersPage;
        private MetroFramework.Controls.MetroTile OrdersSummaryBtn;
        private MetroFramework.Controls.MetroTile OrdersNameMenu;
        private MetroFramework.Controls.MetroTile CreateOrdersName;
    }
}