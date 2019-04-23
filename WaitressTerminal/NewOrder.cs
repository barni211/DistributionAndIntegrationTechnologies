using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitressTerminal
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();

            cbDishType.Items.Add("Kitchen");
            cbDishType.Items.Add("Bar");
            cbDishType.SelectedItem = "Kitchen";
            cbDishType.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
