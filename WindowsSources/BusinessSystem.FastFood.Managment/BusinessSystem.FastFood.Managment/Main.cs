using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BusinessSystem.FastFood.Managment
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        #region Variables
        private string SName, STile;
        MetroFramework.Controls.MetroTile ClientAreaTile, AreaTile;
        #endregion
        public Main()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsWindow Settings = new SettingsWindow();
            Settings.Show();
            AreasFlowLayout.Controls.Clear();
            FlowLayoutArea.Controls.Clear();
            LoadAreas("areas.xml");
        }

        private void ClientTileButton_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile control = (MetroFramework.Controls.MetroTile)sender;
            TableSettings TableS = new TableSettings();
            TableS.Text = "Столик: " + control.Text;
            TableS.TableID = int.Parse(control.Text);
            TableS.FullTileName = control.Name;
            TableS.ShowDialog();
            control.Style = TableS.SelectedStyle;
        }

        private void AreaTileButton_Click(object sender, EventArgs e)
        {
            FlowLayoutArea.Controls.Clear();
            MetroFramework.Controls.MetroTile control = (MetroFramework.Controls.MetroTile)sender;
            string name = control.Text;
            LoadClientAreas("areas.xml", name);
        }

        void InsertAreaTile()
        {
            AreaTile = new MetroFramework.Controls.MetroTile();
            AreaTile.Location = new System.Drawing.Point(3, 3);
            AreaTile.Name = SName;
            AreaTile.Size = new System.Drawing.Size(83, 29);
            AreaTile.TabIndex = 0;
            AreaTile.Text = STile;
            AreaTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            AreaTile.TextAlign = ContentAlignment.MiddleCenter;
            AreaTile.Style = MetroFramework.MetroColorStyle.Purple;
            AreaTile.Click += new System.EventHandler(this.AreaTileButton_Click);
            AreasFlowLayout.Controls.Add(AreaTile);
        }

        void InsertClientTile()
        {
            string tableStatus = null;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("tables.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlElement tableElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SName);
            if (tableElem != null)
            {
                tableStatus = xDoc.SelectSingleNode(String.Format("//{0}/Status", SName)).InnerText;
            }

            ClientAreaTile = new MetroFramework.Controls.MetroTile();
            ClientAreaTile.Location = new System.Drawing.Point(3, 3);
            ClientAreaTile.Name = SName;
            ClientAreaTile.Size = new System.Drawing.Size(175, 140);
            ClientAreaTile.TabIndex = 0;
            ClientAreaTile.Text = STile;
            ClientAreaTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            ClientAreaTile.TextAlign = ContentAlignment.MiddleCenter;

            if(tableStatus == "Free")
                ClientAreaTile.Style = MetroFramework.MetroColorStyle.Green;
            else if(tableStatus == "Earmarked")
                ClientAreaTile.Style = MetroFramework.MetroColorStyle.Orange;
            else if (tableStatus == "Busy")
                ClientAreaTile.Style = MetroFramework.MetroColorStyle.Red;
            else
                ClientAreaTile.Style = MetroFramework.MetroColorStyle.Green;

            ClientAreaTile.Click += new System.EventHandler(this.ClientTileButton_Click);
            FlowLayoutArea.Controls.Add(ClientAreaTile);
        }

        private void LoadAreas(string Path)
        {
            int Counter = 0;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                STile = xnode.Name;
                SName = xnode.Name + Counter++;
                InsertAreaTile();
                STile = String.Empty;
                SName = String.Empty;
            }
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            ExpensesData ExpenseW = new ExpensesData();
            ExpenseW.Show();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesData SalesD = new SalesData();
            SalesD.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists("temp/tempSalesData.temp"))
                File.Delete("temp/tempSalesData.temp");
        }

        private void GraphicButton_Click(object sender, EventArgs e)
        {
            ReportData ReportD = new ReportData();
            ReportD.Show();
        }

        private void MenuTile_Click(object sender, EventArgs e)
        {
            MenuList MList = new MenuList();
            MList.Show();
        }

        private void LoadClientAreas(string Path, string name)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == name)
                {
                    foreach (XmlNode xn in xnode.ChildNodes)
                    {
                        SName = "tableTile" + xnode.Name + xn.InnerText;
                        STile = xn.InnerText;
                        InsertClientTile();
                    }
                }
                STile = String.Empty;
                SName = String.Empty;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Utility.isExists("tables.xml", Utility.ExistsType.XML);
            Utility.isExists("areas.xml", Utility.ExistsType.XML);
            Utility.isExists("data", Utility.ExistsType.DIRECTORY);
            Utility.isExists("temp", Utility.ExistsType.DIRECTORY);
            AreasFlowLayout.Controls.Clear();
            FlowLayoutArea.Controls.Clear();
            LoadAreas("areas.xml");
        }
    }
}
