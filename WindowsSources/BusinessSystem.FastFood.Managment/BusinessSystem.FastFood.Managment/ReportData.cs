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

namespace BusinessSystem.FastFood.Managment
{
    public partial class ReportData : MetroFramework.Forms.MetroForm
    {
        public ReportData()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string DataPath = "data//" + Date.Text;
            if (!Directory.Exists(DataPath))
                Utility.ShowErrorBox("Данные по дате " + Date.Text + " отсутствуют.\nПричины: данные не были сохранены или данные были удалены с данного компютра!");
            else if (Directory.Exists(DataPath))
            {
                if(File.Exists(DataPath + "//EData.xml") && File.Exists(DataPath + "//SData.xml"))
                {
                    Label1.Text = "Расход: " + DataBase.SumColumnsData(DataPath + "//EData.xml", "//Сумма");
                    Label2.Text = "Продажи: " + DataBase.SumColumnsData(DataPath + "//SData.xml", "//Сумма");
                    CircleChart.Series["CircleChartSeries"].Points.AddY(DataBase.SumColumnsData(DataPath + "//EData.xml", "//Сумма"));
                    CircleChart.Series["CircleChartSeries"].Points.AddY(DataBase.SumColumnsData(DataPath + "//SData.xml", "//Сумма"));
                }
            }
        }

        private void ReportData_Load(object sender, EventArgs e)
        {
        }
    }
}
