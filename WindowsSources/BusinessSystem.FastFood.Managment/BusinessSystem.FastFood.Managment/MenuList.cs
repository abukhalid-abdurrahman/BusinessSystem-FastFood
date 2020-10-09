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
    public partial class MenuList : MetroFramework.Forms.MetroForm
    {
        private int RowIndex = 0;
        public MenuList()
        {
            InitializeComponent();
        }

        private void InsertElemnts()
        {
            string status = "Есть";

            string[] Data = File.ReadAllLines("orders.list");
            foreach (string item in Data)
            {
                MenuDataControl.Rows.Add(item, status);
            }
        }

        private void ChangeStatus(int rowIndex)
        {
            string status = MenuDataControl.Rows[rowIndex].Cells[1].Value.ToString();
            if(status == "Есть")
            {
                MenuDataControl.Rows[rowIndex].Cells[1].Value = "Нету";
            }
            else if(status == "Нету")
            {
                MenuDataControl.Rows[rowIndex].Cells[1].Value = "Есть";
            }

            Utility.isExists("menu.changes", Utility.ExistsType.FILE);
            StreamWriter SWriter = new StreamWriter("menu.changes", false, Encoding.UTF8);
            for (int i = 0; i < MenuDataControl.RowCount; i++)
            {
                string name = MenuDataControl.Rows[i].Cells[0].Value.ToString();
                string estatus = MenuDataControl.Rows[i].Cells[1].Value.ToString();
                string data = name + "|" + estatus;
                SWriter.Write(data);
                SWriter.WriteLine();
            }
            SWriter.Flush();
            SWriter.Close();
        }

        private void ExpensesData_Load(object sender, EventArgs e)
        {
            SearchTextBox.Text = "Поиск...";
            SearchTextBox.Text = String.Empty;
            InsertElemnts();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Utility.SearchFromDataGridViewControl(MenuDataControl, SearchTextBox.Text, 0);
        }

        private void MenuDataControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void MenuDataControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
            ChangeStatus(RowIndex);
        }

        private void MenuDataControl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void MenuDataControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                ChangeStatus(RowIndex);
        }

        private void ChangeStatusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatus(RowIndex);
        }
    }
}
