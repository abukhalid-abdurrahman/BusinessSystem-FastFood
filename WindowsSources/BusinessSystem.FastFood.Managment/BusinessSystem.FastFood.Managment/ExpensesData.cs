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

namespace BusinessSystem.FastFood.Managment
{
    public partial class ExpensesData : MetroFramework.Forms.MetroForm
    {
        private string FileName = "NONE";
        public ExpensesData()
        {
            InitializeComponent();
        }

        private void ExpensesData_Load(object sender, EventArgs e)
        {
            SearchTextBox.Text = "Поиск...";
            SearchTextBox.Text = String.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Utility.SearchFromDataGridViewControl(ExpenseDataControl, SearchTextBox.Text, 0);
        }

        private void NewTableBtn_Click(object sender, EventArgs e)
        {
            Utility.CreateTable(ExpenseDataControl, "Имя", "Дата", "Покупка", "Количество", "Сумма");
        }

        private void LoadTableBtn_Click(object sender, EventArgs e)
        {
            DataPickerDialog DataP = new DataPickerDialog(DataPickerDialog.OType.OPEN);
            DataP.ShowDialog();
            if (!Directory.Exists("data//" + DataP.Date.Text))
                Utility.ShowErrorBox("Данные по дате " + DataP.Date.Text + " отсутствуют.\nПричины: данные не были сохранены или данные были удалены с данного компютра!");
            else if (Directory.Exists("data//" + DataP.Date.Text))
            {
                if(!File.Exists("data//" + DataP.Date.Text + "//EData.xml"))
                    Utility.ShowErrorBox("Данные по дате " + DataP.Date.Text + " отсутствуют.\nПричины: данные были удалены с данного компютра!");
                else if (File.Exists("data//" + DataP.Date.Text + "//EData.xml"))
                {
                    Utility.LoadData("data//" + DataP.Date.Text + "//EData.xml", ExpenseDataControl);
                }
            }
        }

        private void SaveTableBtn_Click(object sender, EventArgs e)
        {
            DataPickerDialog DataP = new DataPickerDialog(DataPickerDialog.OType.SAVE);
            DataP.ShowDialog();
            Utility.isExists("data//" + DataP.Date.Text, Utility.ExistsType.DIRECTORY);
            Utility.SaveData("data//" + DataP.Date.Text + "//EData.xml", ExpenseDataControl);
        }
    }
}
