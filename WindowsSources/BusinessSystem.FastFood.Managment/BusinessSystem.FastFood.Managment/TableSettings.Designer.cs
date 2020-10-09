namespace BusinessSystem.FastFood.Managment
{
    partial class TableSettings
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
            this.ApplyBtn = new MetroFramework.Controls.MetroTile();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TimeEarmarkedTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FreeRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.FoodTypeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrdersTypeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EarmarkedRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.BusyRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.Label3 = new MetroFramework.Controls.MetroLabel();
            this.MarkedOrderList = new System.Windows.Forms.ListBox();
            this.ListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ListContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(665, 449);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(97, 23);
            this.ApplyBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.ApplyBtn.TabIndex = 3;
            this.ApplyBtn.Text = "Принять";
            this.ApplyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApplyBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label1.Location = new System.Drawing.Point(23, 108);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 25);
            this.Label1.Style = MetroFramework.MetroColorStyle.Green;
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Имя:";
            this.Label1.UseStyleColors = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label2.Location = new System.Drawing.Point(23, 158);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 25);
            this.Label2.Style = MetroFramework.MetroColorStyle.Green;
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Время:";
            this.Label2.UseStyleColors = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.NameTextBox.Location = new System.Drawing.Point(94, 102);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(228, 31);
            this.NameTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextBox.UseStyleColors = true;
            // 
            // TimeEarmarkedTextBox
            // 
            this.TimeEarmarkedTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TimeEarmarkedTextBox.Location = new System.Drawing.Point(94, 158);
            this.TimeEarmarkedTextBox.Multiline = true;
            this.TimeEarmarkedTextBox.Name = "TimeEarmarkedTextBox";
            this.TimeEarmarkedTextBox.Size = new System.Drawing.Size(228, 31);
            this.TimeEarmarkedTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.TimeEarmarkedTextBox.TabIndex = 7;
            this.TimeEarmarkedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeEarmarkedTextBox.UseStyleColors = true;
            // 
            // FreeRadioBtn
            // 
            this.FreeRadioBtn.AutoSize = true;
            this.FreeRadioBtn.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.FreeRadioBtn.Location = new System.Drawing.Point(23, 449);
            this.FreeRadioBtn.Name = "FreeRadioBtn";
            this.FreeRadioBtn.Size = new System.Drawing.Size(110, 25);
            this.FreeRadioBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.FreeRadioBtn.TabIndex = 8;
            this.FreeRadioBtn.TabStop = true;
            this.FreeRadioBtn.Text = "Свободен";
            this.FreeRadioBtn.UseStyleColors = true;
            this.FreeRadioBtn.UseVisualStyleBackColor = true;
            this.FreeRadioBtn.CheckedChanged += new System.EventHandler(this.FreeRadioBtn_CheckedChanged);
            // 
            // FoodTypeFlowLayoutPanel
            // 
            this.FoodTypeFlowLayoutPanel.AutoScroll = true;
            this.FoodTypeFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.FoodTypeFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodTypeFlowLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.FoodTypeFlowLayoutPanel.Location = new System.Drawing.Point(23, 284);
            this.FoodTypeFlowLayoutPanel.Name = "FoodTypeFlowLayoutPanel";
            this.FoodTypeFlowLayoutPanel.Size = new System.Drawing.Size(405, 157);
            this.FoodTypeFlowLayoutPanel.TabIndex = 9;
            // 
            // OrdersTypeFlowLayoutPanel
            // 
            this.OrdersTypeFlowLayoutPanel.AutoScroll = true;
            this.OrdersTypeFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.OrdersTypeFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrdersTypeFlowLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.OrdersTypeFlowLayoutPanel.Location = new System.Drawing.Point(23, 207);
            this.OrdersTypeFlowLayoutPanel.Name = "OrdersTypeFlowLayoutPanel";
            this.OrdersTypeFlowLayoutPanel.Size = new System.Drawing.Size(405, 71);
            this.OrdersTypeFlowLayoutPanel.TabIndex = 10;
            // 
            // EarmarkedRadioBtn
            // 
            this.EarmarkedRadioBtn.AutoSize = true;
            this.EarmarkedRadioBtn.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.EarmarkedRadioBtn.Location = new System.Drawing.Point(139, 449);
            this.EarmarkedRadioBtn.Name = "EarmarkedRadioBtn";
            this.EarmarkedRadioBtn.Size = new System.Drawing.Size(156, 25);
            this.EarmarkedRadioBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.EarmarkedRadioBtn.TabIndex = 11;
            this.EarmarkedRadioBtn.TabStop = true;
            this.EarmarkedRadioBtn.Text = "Забронировать";
            this.EarmarkedRadioBtn.UseStyleColors = true;
            this.EarmarkedRadioBtn.UseVisualStyleBackColor = true;
            this.EarmarkedRadioBtn.CheckedChanged += new System.EventHandler(this.EarmarkedRadioBtn_CheckedChanged);
            // 
            // BusyRadioButton
            // 
            this.BusyRadioButton.AutoSize = true;
            this.BusyRadioButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.BusyRadioButton.Location = new System.Drawing.Point(301, 449);
            this.BusyRadioButton.Name = "BusyRadioButton";
            this.BusyRadioButton.Size = new System.Drawing.Size(73, 25);
            this.BusyRadioButton.Style = MetroFramework.MetroColorStyle.Green;
            this.BusyRadioButton.TabIndex = 12;
            this.BusyRadioButton.TabStop = true;
            this.BusyRadioButton.Text = "Занят";
            this.BusyRadioButton.UseStyleColors = true;
            this.BusyRadioButton.UseVisualStyleBackColor = true;
            this.BusyRadioButton.CheckedChanged += new System.EventHandler(this.BusyRadioButton_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label3.Location = new System.Drawing.Point(434, 447);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(169, 25);
            this.Label3.Style = MetroFramework.MetroColorStyle.Green;
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Сумма: 0с. Кол-во: 0";
            this.Label3.UseStyleColors = true;
            // 
            // MarkedOrderList
            // 
            this.MarkedOrderList.ContextMenuStrip = this.ListContextMenu;
            this.MarkedOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkedOrderList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MarkedOrderList.FormattingEnabled = true;
            this.MarkedOrderList.ItemHeight = 18;
            this.MarkedOrderList.Location = new System.Drawing.Point(434, 207);
            this.MarkedOrderList.Name = "MarkedOrderList";
            this.MarkedOrderList.Size = new System.Drawing.Size(328, 238);
            this.MarkedOrderList.TabIndex = 14;
            // 
            // ListContextMenu
            // 
            this.ListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ListContextMenu.Name = "ListContextMenu";
            this.ListContextMenu.Size = new System.Drawing.Size(143, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // TableSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 495);
            this.Controls.Add(this.MarkedOrderList);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BusyRadioButton);
            this.Controls.Add(this.EarmarkedRadioBtn);
            this.Controls.Add(this.OrdersTypeFlowLayoutPanel);
            this.Controls.Add(this.FoodTypeFlowLayoutPanel);
            this.Controls.Add(this.FreeRadioBtn);
            this.Controls.Add(this.TimeEarmarkedTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ApplyBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(755, 475);
            this.Name = "TableSettings";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Столик: VIP - 5";
            this.Load += new System.EventHandler(this.TableSettings_Load);
            this.ListContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile ApplyBtn;
        private MetroFramework.Controls.MetroLabel Label1;
        private MetroFramework.Controls.MetroLabel Label2;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroTextBox TimeEarmarkedTextBox;
        private MetroFramework.Controls.MetroRadioButton FreeRadioBtn;
        private System.Windows.Forms.FlowLayoutPanel FoodTypeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel OrdersTypeFlowLayoutPanel;
        private MetroFramework.Controls.MetroRadioButton EarmarkedRadioBtn;
        private MetroFramework.Controls.MetroRadioButton BusyRadioButton;
        private MetroFramework.Controls.MetroLabel Label3;
        private System.Windows.Forms.ListBox MarkedOrderList;
        private System.Windows.Forms.ContextMenuStrip ListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}