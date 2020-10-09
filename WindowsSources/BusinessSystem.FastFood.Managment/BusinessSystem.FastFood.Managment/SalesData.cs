using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace BusinessSystem.FastFood.Managment
{
    public partial class SalesData : MetroFramework.Forms.MetroForm
    {
        private string FileName = "NONE";
        private float A = 0.0f;
        public SalesData()
        {
            InitializeComponent();
        }

        private void CalculationSumm()
        {
            if(SalesDataControl.Rows.Count > 0)
            {
                for (int i = 0; i < SalesDataControl.RowCount; i++)
                {
                    A += float.Parse(SalesDataControl.Rows[i].Cells[4].Value.ToString());
                }
            }
            SummLabel.Text = String.Format("Общая Сумма: {0} Сомони", A);
         
        }

        private void OrderTypeTile_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tileControl = (MetroFramework.Controls.MetroTile)sender;
            string FileName = "resources/orders/data/" + tileControl.Text + ".xml";
            if (File.Exists(FileName))
            {
                SalesDataControl.Columns.Clear();
                Utility.LoadData(FileName, SalesDataControl);
            }
            else
            {
                Utility.ShowErrorBox("Список продаж для " + tileControl.Text + " отсутствует!");
            }
            CalculationSumm();
        }

        private void InsertTile(string TName)
        {
            MetroFramework.Controls.MetroTile TemplateButton = new MetroFramework.Controls.MetroTile();
            TemplateButton.Location = new System.Drawing.Point(3, 3);
            TemplateButton.Name = TName + "Btn";
            TemplateButton.Size = new System.Drawing.Size(83, 29);
            TemplateButton.Style = MetroFramework.MetroColorStyle.Purple;
            TemplateButton.TabIndex = 7;
            TemplateButton.Text = TName;
            TemplateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TemplateButton.Click += new EventHandler(OrderTypeTile_Click);
            OrdesFlowLayout.Controls.Add(TemplateButton);
        }

        private void LoadOrdersData()
        {
            string[] Data = File.ReadAllLines("orders.list");
            foreach (string item in Data)
            {
                InsertTile(item);
            }
        }

        private void ExpensesData_Load(object sender, EventArgs e)
        {
            SearchTextBox.Text = "Поиск...";
            SearchTextBox.Text = String.Empty;
            LoadOrdersData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Utility.SearchFromDataGridViewControl(SalesDataControl, SearchTextBox.Text, 0);
        }

        private void NewTableBtn_Click(object sender, EventArgs e)
        {
            Utility.CreateTable(SalesDataControl, "Имя", "Дата", "Время", "Количество", "Сумма");
        }

        private void LoadTableBtn_Click(object sender, EventArgs e)
        {
            DataPickerDialog DataP = new DataPickerDialog(DataPickerDialog.OType.OPEN);
            DataP.ShowDialog();
            if (!Directory.Exists("data//" + DataP.Date.Text))
                Utility.ShowErrorBox("Данные по дате " + DataP.Date.Text + " отсутствуют.\nПричины: данные не были сохранены или данные были удалены с данного компютра!");
            else if (Directory.Exists("data//" + DataP.Date.Text))
            {
                if(!File.Exists("data//" + DataP.Date.Text + "//SData.xml"))
                    Utility.ShowErrorBox("Данные по дате " + DataP.Date.Text + " отсутствуют.\nПричины: данные были удалены с данного компютра!");
                else if (File.Exists("data//" + DataP.Date.Text + "//SData.xml"))
                {
                    Utility.LoadData("data//" + DataP.Date.Text + "//SData.xml", SalesDataControl);
                }
            }
        }

        private void SaveTableBtn_Click(object sender, EventArgs e)
        {
            DataPickerDialog DataP = new DataPickerDialog(DataPickerDialog.OType.SAVE);
            DataP.ShowDialog();
            Utility.isExists("data//" + DataP.Date.Text, Utility.ExistsType.DIRECTORY);
            Utility.SaveData("data//" + DataP.Date.Text + "//SData.xml", SalesDataControl);
        }

        private void InsertDataFromTemp(FileSystemEventArgs e)
        {
            Utility.isExists("resources", Utility.ExistsType.DIRECTORY);
            Utility.isExists("resources/orders", Utility.ExistsType.DIRECTORY);
            Utility.isExists("resources/orders/data", Utility.ExistsType.DIRECTORY);
            float OrderCount = 1, OrderSumm = 0;
            string FileName = e.FullPath;
            DateTime date = File.GetCreationTime(FileName);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(FileName);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                foreach(XmlNode xnode in xNode)
                {
                    for (int i = 0; i < xnode.ChildNodes.Count; i++)
                    {
                        
                        if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("price");
                            if (attr != null)
                            {
                                OrderSumm = float.Parse(attr.Value.ToString().Replace(".", ","));
                                A += OrderSumm;
                            }
                        }
                        
                        SalesDataControl.Rows.Add(xnode.ChildNodes[i].InnerText, date.Day + "." + date.Month + "." + date.Year, date.TimeOfDay.Hours + ":" + date.TimeOfDay.Minutes, OrderCount, OrderSumm);
                        Utility.InsertRowToXMLData("resources/orders/data/" + xnode.ChildNodes[i].Name + ".xml", SalesDataControl.Name, "Имя=" + xnode.ChildNodes[i].InnerText, "Дата=" + date.Day + "." + date.Month + "." + date.Year, "Время=" + date.TimeOfDay.Hours + ":" + date.TimeOfDay.Minutes, "Количество=" + OrderCount, "Сумма=" + OrderSumm);
                    }
                }
            }
            SummLabel.Text = String.Format("Общая Сумма: {0} Сомони", A);
        }

        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            //InsertDataFromTemp(e);
        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            InsertDataFromTemp(e);
            Utility.SaveData("temp/tempSalesData.temp", SalesDataControl);
            //CalculationSumm();
        }

        private void GeneralSalesBtn_Click(object sender, EventArgs e)
        {
            string FileName = "temp/tempSalesData.temp";
            if (File.Exists(FileName))
            {
                SalesDataControl.Columns.Clear();
                Utility.LoadData(FileName, SalesDataControl);
            }
            //CalculationSumm();
        }

        private void SalesDataControl_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Utility.SetRowIndex(SalesDataControl);
        }
    }
}
