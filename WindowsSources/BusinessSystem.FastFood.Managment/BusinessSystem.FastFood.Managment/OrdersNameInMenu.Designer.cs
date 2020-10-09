namespace BusinessSystem.FastFood.Managment
{
    partial class OrdersNameInMenu
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
            this.OrderTypeTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.AddOrderType = new MetroFramework.Controls.MetroTile();
            this.OrdersNameList = new System.Windows.Forms.ListBox();
            this.OrdersTypeNamesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OrderTypeTextBoxName
            // 
            this.OrderTypeTextBoxName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.OrderTypeTextBoxName.Location = new System.Drawing.Point(23, 372);
            this.OrderTypeTextBoxName.Multiline = true;
            this.OrderTypeTextBoxName.Name = "OrderTypeTextBoxName";
            this.OrderTypeTextBoxName.Size = new System.Drawing.Size(739, 42);
            this.OrderTypeTextBoxName.Style = MetroFramework.MetroColorStyle.Purple;
            this.OrderTypeTextBoxName.TabIndex = 0;
            this.OrderTypeTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderTypeTextBoxName.UseStyleColors = true;
            // 
            // AddOrderType
            // 
            this.AddOrderType.Location = new System.Drawing.Point(23, 420);
            this.AddOrderType.Name = "AddOrderType";
            this.AddOrderType.Size = new System.Drawing.Size(739, 52);
            this.AddOrderType.Style = MetroFramework.MetroColorStyle.Purple;
            this.AddOrderType.TabIndex = 1;
            this.AddOrderType.Text = "Добавить";
            this.AddOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddOrderType.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddOrderType.Click += new System.EventHandler(this.AddOrderType_Click);
            // 
            // OrdersNameList
            // 
            this.OrdersNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersNameList.ForeColor = System.Drawing.Color.Purple;
            this.OrdersNameList.FormattingEnabled = true;
            this.OrdersNameList.ItemHeight = 18;
            this.OrdersNameList.Location = new System.Drawing.Point(392, 63);
            this.OrdersNameList.Name = "OrdersNameList";
            this.OrdersNameList.Size = new System.Drawing.Size(370, 292);
            this.OrdersNameList.TabIndex = 2;
            // 
            // OrdersTypeNamesList
            // 
            this.OrdersTypeNamesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersTypeNamesList.ForeColor = System.Drawing.Color.Purple;
            this.OrdersTypeNamesList.FormattingEnabled = true;
            this.OrdersTypeNamesList.ItemHeight = 18;
            this.OrdersTypeNamesList.Location = new System.Drawing.Point(23, 63);
            this.OrdersTypeNamesList.Name = "OrdersTypeNamesList";
            this.OrdersTypeNamesList.Size = new System.Drawing.Size(363, 292);
            this.OrdersTypeNamesList.TabIndex = 3;
            this.OrdersTypeNamesList.SelectedIndexChanged += new System.EventHandler(this.OrdersTypeNamesList_SelectedIndexChanged);
            // 
            // OrdersNameInMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 495);
            this.Controls.Add(this.OrdersTypeNamesList);
            this.Controls.Add(this.OrdersNameList);
            this.Controls.Add(this.AddOrderType);
            this.Controls.Add(this.OrderTypeTextBoxName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(755, 475);
            this.Name = "OrdersNameInMenu";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Заказы в меню";
            this.Load += new System.EventHandler(this.OrdersTypeInMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox OrderTypeTextBoxName;
        private MetroFramework.Controls.MetroTile AddOrderType;
        private System.Windows.Forms.ListBox OrdersNameList;
        private System.Windows.Forms.ListBox OrdersTypeNamesList;
    }
}