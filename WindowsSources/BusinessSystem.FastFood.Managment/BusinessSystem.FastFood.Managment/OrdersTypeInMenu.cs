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
    public partial class OrdersTypeInMenu : MetroFramework.Forms.MetroForm
    {
        public OrdersTypeInMenu()
        {
            InitializeComponent();
        }

        void LoadAreas(string Path)
        {
            OrdersTypeList.Items.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                OrdersTypeList.Items.Add(xNode.Name);
            }
        }
        void InsertAreas(string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement orderTypeElem = xDoc.CreateElement(OrderTypeTextBoxName.Text);
            xRoot.AppendChild(orderTypeElem);
            xDoc.Save(Path);
        }

        private void AddOrderType_Click(object sender, EventArgs e)
        {
            InsertAreas("orders.xml");
            LoadAreas("orders.xml");
        }

        private void OrdersTypeInMenu_Load(object sender, EventArgs e)
        {
            Utility.isExists("orders.xml", Utility.ExistsType.XML);
            LoadAreas("orders.xml");
        }
    }
}
