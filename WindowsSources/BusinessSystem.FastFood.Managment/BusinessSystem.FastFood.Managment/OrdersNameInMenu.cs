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
    public partial class OrdersNameInMenu : MetroFramework.Forms.MetroForm
    {
        public OrdersNameInMenu()
        {
            InitializeComponent();
        }

        void LoadAreas(string Path)
        {
            OrdersTypeNamesList.Items.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                OrdersTypeNamesList.Items.Add(xNode.Name);
            }
        }
        void InsertAreas(string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement orderTypeElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + OrdersTypeNamesList.SelectedItem.ToString());
            XmlElement orderNameElem = xDoc.CreateElement(OrderTypeTextBoxName.Text);
            orderTypeElem.AppendChild(orderNameElem);
            xRoot.AppendChild(orderTypeElem);
            xDoc.Save(Path);

            Utility.WriteDataToFile("orders.list", true, OrderTypeTextBoxName.Text);
        }

        private void AddOrderType_Click(object sender, EventArgs e)
        {
            InsertAreas("orders.xml");
            LoadAreas("orders.xml");
        }

        private void OrdersTypeInMenu_Load(object sender, EventArgs e)
        {
            Utility.isExists("orders.xml", Utility.ExistsType.XML);
            Utility.isExists("orders.list", Utility.ExistsType.FILE);
            LoadAreas("orders.xml");
        }

        private void OrdersTypeNamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersTypeNamesList.SelectedItem != null)
            {
                string rootName = OrdersTypeNamesList.SelectedItem.ToString();
                OrdersNameList.Items.Clear();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("orders.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlNode xNode in xRoot)
                {
                    if (xNode.Name == rootName)
                    {
                        foreach (XmlNode xnode in xNode.ChildNodes)
                            OrdersNameList.Items.Add(xnode.Name);
                    }
                }
            }
        }
    }
}
