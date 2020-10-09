namespace BusinessSystem.FastFood.Managment
{
    partial class DataPickerDialog
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
            this.Apply = new MetroFramework.Controls.MetroTile();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(316, 112);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(107, 30);
            this.Apply.Style = MetroFramework.MetroColorStyle.Purple;
            this.Apply.TabIndex = 0;
            this.Apply.Text = "ОК";
            this.Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Apply.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Apply.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(11, 63);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(412, 31);
            this.Date.TabIndex = 4;
            // 
            // DataPickerDialog
            // 
            this.AcceptButton = this.Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 165);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Apply);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 165);
            this.Name = "DataPickerDialog";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Caption";
            this.Load += new System.EventHandler(this.DataPickerDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Apply;
        public System.Windows.Forms.DateTimePicker Date;
    }
}