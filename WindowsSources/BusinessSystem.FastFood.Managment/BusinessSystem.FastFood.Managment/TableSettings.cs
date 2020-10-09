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
    public partial class TableSettings : MetroFramework.Forms.MetroForm
    {
        #region Variables
        public MetroFramework.MetroColorStyle SelectedStyle = MetroFramework.MetroColorStyle.Green;
        private List<float> OrdersCostList = new List<float>();
        private float[] OrdersCostArray;
        private string TableStatus = "Free";
        public int TableID = 0;
        public string FullTileName = "None";
        string OTypeName = String.Empty;
        float A = 0;
        float PriceValue = 0.0f;
        #endregion
        public TableSettings()
        {
            InitializeComponent();
        }

        private void ChangeStyle(MetroFramework.MetroColorStyle Style)
        {
            this.Style = Style;
            Label1.Style = Style;
            Label2.Style = Style;
            Label3.Style = Style;
            NameTextBox.Style = Style;
            TimeEarmarkedTextBox.Style = Style;
            FreeRadioBtn.Style = Style;
            EarmarkedRadioBtn.Style = Style;
            BusyRadioButton.Style = Style;
            ApplyBtn.Style = Style;
            SelectedStyle = Style;
        }

        private void LoadTableClientData(string tableName)
        {
            MetroFramework.MetroColorStyle LoadedStyle = MetroFramework.MetroColorStyle.Green;
            string TStatus = null, CName = null, CTime = null;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("tables.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlElement tableElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + tableName);
            if (tableElem != null)
            {
                TStatus = xDoc.SelectSingleNode(String.Format("//{0}/Status", tableName)).InnerText;
                CName = xDoc.SelectSingleNode(String.Format("//{0}/ClientName", tableName)).InnerText;
                CTime = xDoc.SelectSingleNode(String.Format("//{0}/Time", tableName)).InnerText;
            }

            if (TStatus == "Free")
            {
                LoadedStyle = MetroFramework.MetroColorStyle.Green;
                FreeRadioBtn.Checked = true;
            }
            else if (TStatus == "Earmarked")
            {
                LoadedStyle = MetroFramework.MetroColorStyle.Orange;
                EarmarkedRadioBtn.Checked = true;
            }
            else if (TStatus == "Busy")
            {
                LoadedStyle = MetroFramework.MetroColorStyle.Red;
                BusyRadioButton.Checked = true;
            }
            else
            {
                LoadedStyle = MetroFramework.MetroColorStyle.Green;
                FreeRadioBtn.Checked = true;
            }

            NameTextBox.Text = CName;
            TimeEarmarkedTextBox.Text = CTime;
            ChangeStyle(LoadedStyle);
        }

        private void FreeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(FreeRadioBtn.Checked)
            {
                ChangeStyle(MetroFramework.MetroColorStyle.Green);
                TableStatus = "Free";
                ClearData();
            }
        }

        private void EarmarkedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (EarmarkedRadioBtn.Checked)
            {
                ChangeStyle(MetroFramework.MetroColorStyle.Orange);
                TableStatus = "Earmarked";
            }
        }

        private void BusyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BusyRadioButton.Checked)
            {
                ChangeStyle(MetroFramework.MetroColorStyle.Red);
                TableStatus = "Busy";
            }
        }

        private void ClearData()
        {
            OrdersCostArray = new float[0];
            OrdersCostList.Clear();
            MarkedOrderList.Items.Clear();
            NameTextBox.Text = String.Empty;
            TimeEarmarkedTextBox.Text = String.Empty;
            Label3.Text = "Сумма: 0с. Кол-во: 0";
            DeleteTempData();
        }

        private void LoadTempData()
        {
            string TableItemName = FullTileName;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("temp/tableData" + TableID + ".xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if(xNode.Name == TableItemName)
                {
                    foreach(XmlNode node in xNode)
                    {
                        if (node.Attributes.Count > 0)
                        {
                            XmlNode attr = node.Attributes.GetNamedItem("price");
                            if (attr != null)
                                OrdersCostList.Add(float.Parse(attr.Value.ToString().Replace(".", ",")));
                        }

                        MarkedOrderList.Items.Add(node.Name);
                    }
                }
            }

            OrdersCostArray = OrdersCostList.ToArray();
            A = 0.0f;
            for (int i = 0; i < OrdersCostArray.Length; i++)
            {
                A += OrdersCostArray[i];
            }

            Label3.Text = String.Format("Сумма: {0}с. Кол-во: {1}", A, MarkedOrderList.Items.Count);
        }

        private void DeleteTempData()
        {
            if (File.Exists("temp/tableData" + TableID + ".xml"))
                File.Delete("temp/tableData" + TableID + ".xml");
        }

        private void SaveTempData()
        {
            string TableItemName = FullTileName;
            Utility.isExists("temp/tableData" + TableID + ".xml", Utility.ExistsType.XML);

            XmlDocument xTempDoc = new XmlDocument();
            xTempDoc.Load("temp/tableData" + TableID + ".xml");
            XmlElement xTempRoot = xTempDoc.DocumentElement;

            XmlElement tableTempElem = xTempDoc.CreateElement(TableItemName);
            XmlElement oCountTempElem = xTempDoc.CreateElement("OrdersCount");
            XmlText oCountTempElemText = xTempDoc.CreateTextNode(MarkedOrderList.Items.Count.ToString());

            tableTempElem = xTempDoc.CreateElement(TableItemName);

            for (int i = 0; i < MarkedOrderList.Items.Count; i++)
            {
                XmlAttribute priceAttr = xTempDoc.CreateAttribute("price");
                XmlElement xOrderTempName = xTempDoc.CreateElement(MarkedOrderList.Items[i].ToString());
                XmlText xOrderTempText = xTempDoc.CreateTextNode(MarkedOrderList.Items[i].ToString());
                xOrderTempName.AppendChild(xOrderTempText);
                XmlText priceVal = xTempDoc.CreateTextNode(OrdersCostArray[i].ToString());
                priceAttr.AppendChild(priceVal);
                xOrderTempName.Attributes.Append(priceAttr);
                tableTempElem.AppendChild(xOrderTempName);
            }
            oCountTempElem.AppendChild(oCountTempElemText);
            xTempRoot.AppendChild(tableTempElem);
            xTempRoot.AppendChild(oCountTempElem);
            xTempDoc.Save("temp/tableData" + TableID + ".xml");
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Utility.isExists("tables.xml", Utility.ExistsType.XML);
            string TableItemName = FullTileName;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("tables.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlElement tableElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + TableItemName);
            XmlElement clientName = xDoc.CreateElement("ClientName");
            XmlElement time = xDoc.CreateElement("Time");
            XmlElement status = xDoc.CreateElement("Status");
            XmlText clientNameText = xDoc.CreateTextNode(NameTextBox.Text);
            XmlText cTime = xDoc.CreateTextNode(TimeEarmarkedTextBox.Text);
            XmlText cStatus = xDoc.CreateTextNode(TableStatus);
            
            if (tableElem != null)
            {
                xDoc.SelectSingleNode(String.Format("//{0}/ClientName", TableItemName)).InnerText = NameTextBox.Text;
                xDoc.SelectSingleNode(String.Format("//{0}/Time", TableItemName)).InnerText = TimeEarmarkedTextBox.Text;
                xDoc.SelectSingleNode(String.Format("//{0}/Status", TableItemName)).InnerText = TableStatus;
            }
            else if(tableElem == null)
            {
                tableElem = xDoc.CreateElement(TableItemName);
                clientName.AppendChild(clientNameText);
                tableElem.AppendChild(clientName);
                time.AppendChild(cTime);
                tableElem.AppendChild(time);
                status.AppendChild(cStatus);
                tableElem.AppendChild(status);
            }
            xRoot.AppendChild(tableElem);
            xDoc.Save("tables.xml");

            if (MarkedOrderList.Items.Count != 0)
            {
                DeleteTempData();
                SaveTempData();
            }
            else if (MarkedOrderList.Items.Count == 0)
                DeleteTempData();

            this.Close();
        }

        private void ClearFlowControls()
        {
            OrdersTypeFlowLayoutPanel.Controls.Clear();
            FoodTypeFlowLayoutPanel.Controls.Clear();
        }

        void InsertOrderTile(string TName)
        {
            MetroFramework.Controls.MetroTile OrderTypeTile = new MetroFramework.Controls.MetroTile();
            OrderTypeTile.Location = new System.Drawing.Point(3, 3);
            OrderTypeTile.Name = TName;
            OrderTypeTile.Size = new System.Drawing.Size(150, 90);
            OrderTypeTile.TabIndex = 0;
            OrderTypeTile.Text = TName;
            OrderTypeTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            OrderTypeTile.TextAlign = ContentAlignment.MiddleCenter;
            OrderTypeTile.Style = MetroFramework.MetroColorStyle.Silver;
            OrderTypeTile.Click += new System.EventHandler(this.OrderTileButton_Click);
            FoodTypeFlowLayoutPanel.Controls.Add(OrderTypeTile);
        }

        private void OrderTypeTileButton_Click(object sender, EventArgs e)
        {
            FoodTypeFlowLayoutPanel.Controls.Clear();
            MetroFramework.Controls.MetroTile senderTile = (MetroFramework.Controls.MetroTile)sender;
            OTypeName = senderTile.Text;
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("orders.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if(xnode.Name == OTypeName)
                {
                    XmlElement xElem = (XmlElement)xDoc.SelectSingleNode("settings/" + OTypeName);
                    foreach(XmlNode xcNode in xElem)
                    {
                        InsertOrderTile(xcNode.Name);
                    }
                }
            }
            
        }

        private void OrderTileButton_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile senderTile = (MetroFramework.Controls.MetroTile)sender;
            string OName = senderTile.Text;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("orders.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == OTypeName)
                {
                    XmlElement xElem = (XmlElement)xDoc.SelectSingleNode("settings/" + OTypeName + "/" + OName + "/Russian/Price");
                    PriceValue = float.Parse(xElem.InnerText.Replace(".", ","));
                }
            }
            OrdersCostList.Add(PriceValue);
            MarkedOrderList.Items.Add(OName);
            OrdersCostArray = OrdersCostList.ToArray();
            A = 0.0f;
            for(int i = 0; i < OrdersCostArray.Length; i++)
            {
               A += OrdersCostArray[i];
            }

            Label3.Text = String.Format("Сумма: {0}с. Кол-во: {1}", A, MarkedOrderList.Items.Count);
        }

        void InsertOrderTypeTile(string TName)
        {
            MetroFramework.Controls.MetroTile OrderTypeTile = new MetroFramework.Controls.MetroTile();
            OrderTypeTile.Location = new System.Drawing.Point(3, 3);
            OrderTypeTile.Name = TName;
            OrderTypeTile.Size = new System.Drawing.Size(95, 35);
            OrderTypeTile.TabIndex = 0;
            OrderTypeTile.Text = TName;
            OrderTypeTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            OrderTypeTile.TextAlign = ContentAlignment.MiddleCenter;
            OrderTypeTile.Style = MetroFramework.MetroColorStyle.Silver;
            OrderTypeTile.Click += new System.EventHandler(this.OrderTypeTileButton_Click);
            OrdersTypeFlowLayoutPanel.Controls.Add(OrderTypeTile);
        }

        private void LoadOrders(string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                InsertOrderTypeTile(xnode.Name);
            }
        }

        private void TableSettings_Load(object sender, EventArgs e)
        {
            ClearFlowControls();
            LoadTableClientData(FullTileName);
            LoadOrders("orders.xml");
            if (File.Exists("temp/tableData" + TableID + ".xml"))
                LoadTempData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MarkedOrderList.SelectedItem != null)
            {
                int Index = MarkedOrderList.SelectedIndex;
                MarkedOrderList.Items.RemoveAt(Index);
                OrdersCostList.RemoveAt(Index);
                OrdersCostArray = OrdersCostList.ToArray();
                A = 0.0f;
                for (int i = 0; i < OrdersCostArray.Length; i++)
                {
                    A += OrdersCostArray[i];
                }
                Label3.Text = String.Format("Сумма: {0}с. Кол-во: {1}", A, MarkedOrderList.Items.Count);
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }
    }
}
