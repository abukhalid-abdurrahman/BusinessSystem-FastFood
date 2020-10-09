using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BusinessSystem.FastFood.Managment
{
    public partial class SettingsWindow : MetroFramework.Forms.MetroForm
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }
        void ClearLists()
        {
            AreasListBox.Items.Clear();
            ClientAreaListBox.Items.Clear();
        }
        void LoadAreas(string Path)
        {
            ClearLists();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                 AreasListBox.Items.Add(xNode.Name);
            }
        }
        void InsertAreas(string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement areaElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + AreaTextBox.Text);
            XmlElement tableElem = xDoc.CreateElement("table");
            XmlText areaText = xDoc.CreateTextNode(AreaTextBox.Text);
            XmlText clientAreaText = xDoc.CreateTextNode(ClientAreaTextBox.Text);
            
            if (areaElem != null)
            {
                tableElem.InnerText = ClientAreaTextBox.Text;
                areaElem.AppendChild(tableElem);
            }
            else if(areaElem == null)
            {
                areaElem = xDoc.CreateElement(AreaTextBox.Text);
                tableElem.AppendChild(clientAreaText);
                areaElem.AppendChild(tableElem);
            }
            
            xRoot.AppendChild(areaElem);
            xDoc.Save(Path);
        }
        private void InsertData_Click(object sender, EventArgs e)
        {
            InsertAreas("areas.xml");
            LoadAreas("areas.xml");
        }
        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            Utility.isExists("areas.xml", Utility.ExistsType.XML);
            LoadAreas("areas.xml");
        }

        private void AreasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AreasListBox.SelectedItem != null)
            {
                string name = AreasListBox.SelectedItem.ToString();
                AreaTextBox.Text = name;
                ClientAreaListBox.Items.Clear();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("areas.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlNode xNode in xRoot)
                {
                    if (xNode.Name == name)
                    {
                        foreach(XmlNode xnode in xNode.ChildNodes)
                            ClientAreaListBox.Items.Add(xnode.InnerText);
                    }
                }
            }
        }

        private void CreateOrdersName_Click(object sender, EventArgs e)
        {
            OrdersTypeInMenu OTIM = new OrdersTypeInMenu();
            OTIM.Show();
        }

        private void OrdersSummaryBtn_Click(object sender, EventArgs e)
        {
            OrdersDescription Descript = new OrdersDescription();
            Descript.Show();
        }

        private void OrdersNameMenu_Click(object sender, EventArgs e)
        {
            OrdersNameInMenu O = new OrdersNameInMenu();
            O.Show();
        }
    }
}
