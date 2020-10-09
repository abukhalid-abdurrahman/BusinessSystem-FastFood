using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessSystem.FastFood.Managment
{
    public partial class DataPickerDialog : MetroFramework.Forms.MetroForm
    {
        public enum OType
        {
            SAVE,
            OPEN
        };

        private OType SelectedType;

        public DataPickerDialog()
        {
            InitializeComponent();
        }

        public DataPickerDialog(OType type)
        {
            InitializeComponent();
            SelectedType = type;
        }

        private void DataPickerDialog_Load(object sender, EventArgs e)
        {
            switch (SelectedType)
            {
                case OType.SAVE:
                    this.Text = "Сохранить...";
                    break;
                case OType.OPEN:
                    this.Text = "Открыть...";
                    break;
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
