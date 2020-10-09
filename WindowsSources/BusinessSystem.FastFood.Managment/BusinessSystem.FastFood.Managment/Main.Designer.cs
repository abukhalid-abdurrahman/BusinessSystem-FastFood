namespace BusinessSystem.FastFood.Managment
{
    partial class Main
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
            this.FlowLayoutArea = new System.Windows.Forms.FlowLayoutPanel();
            this.GraphicButton = new MetroFramework.Controls.MetroTile();
            this.SalesButton = new MetroFramework.Controls.MetroTile();
            this.ExpenseButton = new MetroFramework.Controls.MetroTile();
            this.SettingsButton = new MetroFramework.Controls.MetroTile();
            this.AreasFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // FlowLayoutArea
            // 
            this.FlowLayoutArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutArea.AutoScroll = true;
            this.FlowLayoutArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowLayoutArea.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutArea.Location = new System.Drawing.Point(23, 153);
            this.FlowLayoutArea.Name = "FlowLayoutArea";
            this.FlowLayoutArea.Size = new System.Drawing.Size(837, 299);
            this.FlowLayoutArea.TabIndex = 0;
            // 
            // GraphicButton
            // 
            this.GraphicButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicButton.Location = new System.Drawing.Point(777, 63);
            this.GraphicButton.Name = "GraphicButton";
            this.GraphicButton.Size = new System.Drawing.Size(83, 29);
            this.GraphicButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.GraphicButton.TabIndex = 2;
            this.GraphicButton.Text = "График";
            this.GraphicButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GraphicButton.Click += new System.EventHandler(this.GraphicButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesButton.Location = new System.Drawing.Point(688, 63);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(83, 29);
            this.SalesButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.SalesButton.TabIndex = 3;
            this.SalesButton.Text = "Продажи";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ExpenseButton
            // 
            this.ExpenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseButton.Location = new System.Drawing.Point(599, 63);
            this.ExpenseButton.Name = "ExpenseButton";
            this.ExpenseButton.Size = new System.Drawing.Size(83, 29);
            this.ExpenseButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.ExpenseButton.TabIndex = 4;
            this.ExpenseButton.Text = "Расход";
            this.ExpenseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExpenseButton.Click += new System.EventHandler(this.ExpenseButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Location = new System.Drawing.Point(421, 63);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(83, 29);
            this.SettingsButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AreasFlowLayout
            // 
            this.AreasFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreasFlowLayout.AutoScroll = true;
            this.AreasFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AreasFlowLayout.Location = new System.Drawing.Point(23, 105);
            this.AreasFlowLayout.Name = "AreasFlowLayout";
            this.AreasFlowLayout.Size = new System.Drawing.Size(837, 42);
            this.AreasFlowLayout.TabIndex = 6;
            // 
            // MenuTile
            // 
            this.MenuTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuTile.Location = new System.Drawing.Point(510, 63);
            this.MenuTile.Name = "MenuTile";
            this.MenuTile.Size = new System.Drawing.Size(83, 29);
            this.MenuTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.MenuTile.TabIndex = 7;
            this.MenuTile.Text = "Меню";
            this.MenuTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MenuTile.Click += new System.EventHandler(this.MenuTile_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 475);
            this.Controls.Add(this.MenuTile);
            this.Controls.Add(this.AreasFlowLayout);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ExpenseButton);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.GraphicButton);
            this.Controls.Add(this.FlowLayoutArea);
            this.MinimumSize = new System.Drawing.Size(883, 475);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "BusinessSystem.FastFood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutArea;
        private MetroFramework.Controls.MetroTile GraphicButton;
        private MetroFramework.Controls.MetroTile SalesButton;
        private MetroFramework.Controls.MetroTile ExpenseButton;
        private MetroFramework.Controls.MetroTile SettingsButton;
        private System.Windows.Forms.FlowLayoutPanel AreasFlowLayout;
        private MetroFramework.Controls.MetroTile MenuTile;
    }
}

