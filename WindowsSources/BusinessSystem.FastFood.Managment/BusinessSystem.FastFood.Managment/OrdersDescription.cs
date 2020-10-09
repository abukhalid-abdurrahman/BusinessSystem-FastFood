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
    public partial class OrdersDescription : MetroFramework.Forms.MetroForm
    {
        #region Variables
        private string SelectedOrder = "NONE", SelectedOrderType = "NONE";
        private string ImagePath = null;
        string FileName = "NONE";
        #endregion
        public OrdersDescription()
        {
            InitializeComponent();
        }

        private void LoadOrdersType(string Path)
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

        private void OrderNameLang_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox TxtBox = (MetroFramework.Controls.MetroTextBox)sender;
            TxtBox.Text = String.Empty;
        }

        private void OrdersDescription_Load(object sender, EventArgs e)
        {
            Utility.isExists("orders.xml", Utility.ExistsType.XML);
            Utility.isExists("resources//orders//images", Utility.ExistsType.DIRECTORY);
            LoadOrdersType("orders.xml");
        }

        private void OrdersTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersTypeList.SelectedItem != null)
            {
                string rootName = OrdersTypeList.SelectedItem.ToString();
                SelectedOrderType = OrdersTypeList.SelectedItem.ToString();
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

        private void LoadOrderData()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("orders.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement orderElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder);
            XmlElement rusElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian");
            XmlElement tajikElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik");
            XmlElement englishElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/English");
            string ItemName = null, ItemPrice = null, ItemImage = null, ItemDescript = null;

            if (orderElem != null)
            {
                if (RusRadioBtn.Checked)
                {
                    if (rusElem != null)
                    {
                        ItemName = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Name").InnerText;
                        ItemPrice = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Price").InnerText;
                        ItemDescript = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Description").InnerText;
                        ItemImage = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Image").InnerText;
                        OrderNameLang.Text = ItemName;
                        OrderCost.Text = ItemPrice;
                        OrderDescroptLang.Text = ItemDescript;
                        if (File.Exists("resources/orders/images/" + ItemImage))
                        {
                            FileName = ItemImage;
                            MainImage.BackgroundImage = Image.FromFile("resources/orders/images/" + ItemImage);
                        }
                    }
                }
                else if (TajikRadioBtn.Checked)
                {
                    if (tajikElem != null)
                    {
                        ItemName = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Name").InnerText;
                        ItemPrice = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Price").InnerText;
                        ItemDescript = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Description").InnerText;
                        ItemImage = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Image").InnerText;
                        OrderNameLang.Text = ItemName;
                        OrderCost.Text = ItemPrice;
                        OrderDescroptLang.Text = ItemDescript;
                        if (File.Exists("resources/orders/images/" + ItemImage))
                            MainImage.BackgroundImage = Image.FromFile("resources/orders/images/" + ItemImage);
                    }
                }
                else if (EngRadioBtn.Checked)
                {
                    if (englishElem != null)
                    {
                        ItemName = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/English/Name").InnerText;
                        ItemPrice = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/English/Price").InnerText;
                        ItemDescript = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/English/Description").InnerText;
                        ItemImage = xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/English/Image").InnerText;
                        OrderNameLang.Text = ItemName;
                        OrderCost.Text = ItemPrice;
                        OrderDescroptLang.Text = ItemDescript;
                        if (File.Exists("resources/orders/images/" + ItemImage))
                            MainImage.BackgroundImage = Image.FromFile("resources/orders/images/" + ItemImage);
                    }
                }
                else
                    return;
            }
            else if (orderElem == null)
            {
                return;
            }
        }

        private void OrdersNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OrdersNameList.SelectedItem != null)
            {
                SelectedOrder = OrdersNameList.SelectedItem.ToString();
                LoadOrderData();
            }
        }

        private void MainImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] DFile = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (DFile != null && DFile.Any())
            {
                ImagePath = DFile.First();
                LoadImage(DFile.First());
            }
        }

        private void MainImage_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        void ReplaceImage(string FPath)
        {
            try
            {
                FileName = Path.GetFileName(FPath);
                File.Copy(FPath, "resources//orders//images//" + FileName);
            }
            catch (Exception ex)
            {
            }
        }

        private void LoadImage(string FPath)
        {
            MainImage.BackgroundImage = Image.FromFile(FPath);
            ReplaceImage(FPath);
        }

        private void MainImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadImage(openFileDialog.FileName);
            }
        }

        private void RusRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("orders.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement orderElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder);
            XmlElement rusElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian");
            XmlElement tajikElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik");
            XmlElement englishElem = (XmlElement)xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/English");
            XmlElement nameElem = xDoc.CreateElement("Name");
            XmlElement priceElem = xDoc.CreateElement("Price");
            XmlElement descriptElem = xDoc.CreateElement("Description");
            XmlElement imagePathElem = xDoc.CreateElement("Image");
            XmlText imagePathLinkText = xDoc.CreateTextNode(FileName);
            XmlText nameText = xDoc.CreateTextNode(OrderNameLang.Text);
            XmlText priceText = xDoc.CreateTextNode(OrderCost.Text);
            XmlText descriptText = xDoc.CreateTextNode(OrderDescroptLang.Text);

            if (orderElem != null)
            {
                if (RusRadioBtn.Checked)
                {
                    if (rusElem == null)
                    {
                        rusElem = xDoc.CreateElement("Russian");
                        nameElem.AppendChild(nameText);
                        priceElem.AppendChild(priceText);
                        descriptElem.AppendChild(descriptText);
                        imagePathElem.AppendChild(imagePathLinkText);
                        rusElem.AppendChild(nameElem);
                        rusElem.AppendChild(priceElem);
                        rusElem.AppendChild(descriptElem);
                        rusElem.AppendChild(imagePathElem);
                        orderElem.AppendChild(rusElem);
                    }
                    else if (rusElem != null)
                    {
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Name").InnerText = OrderNameLang.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Price").InnerText = OrderCost.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Description").InnerText = OrderDescroptLang.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Image").InnerText = FileName;
                    }
                }
                else if (TajikRadioBtn.Checked)
                {
                    if (tajikElem == null)
                    {
                        tajikElem = xDoc.CreateElement("Tajik");
                        nameElem.AppendChild(nameText);
                        priceElem.AppendChild(priceText);
                        descriptElem.AppendChild(descriptText);
                        imagePathElem.AppendChild(imagePathLinkText);
                        tajikElem.AppendChild(nameElem);
                        tajikElem.AppendChild(priceElem);
                        tajikElem.AppendChild(descriptElem);
                        tajikElem.AppendChild(imagePathElem);
                        orderElem.AppendChild(tajikElem);
                    }
                    else if (tajikElem != null)
                    {
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Name").InnerText = OrderNameLang.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Price").InnerText = OrderCost.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Description").InnerText = OrderDescroptLang.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Tajik/Image").InnerText = FileName;
                    }
                }
                else if (EngRadioBtn.Checked)
                {
                    if (englishElem == null)
                    {
                        englishElem = xDoc.CreateElement("English");
                        nameElem.AppendChild(nameText);
                        priceElem.AppendChild(priceText);
                        descriptElem.AppendChild(descriptText);
                        imagePathElem.AppendChild(imagePathLinkText);
                        englishElem.AppendChild(nameElem);
                        englishElem.AppendChild(priceElem);
                        englishElem.AppendChild(descriptElem);
                        englishElem.AppendChild(imagePathElem);
                        orderElem.AppendChild(englishElem);
                    }
                    else if (englishElem != null)
                    {
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Name").InnerText = OrderNameLang.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Price").InnerText = OrderCost.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Description").InnerText = OrderDescroptLang.Text;
                        xDoc.SelectSingleNode("/settings/" + SelectedOrderType + "/" + SelectedOrder + "/Russian/Image").InnerText = FileName;
                    }
                }
                else
                    return;
            }
            else if (orderElem == null)
            {
                return;
            }
            xDoc.Save("orders.xml");

            Utility.ShowInformaionBox("Данные успешно сохранены.");
        }
    }
}
