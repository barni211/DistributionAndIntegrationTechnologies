using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarTenderTerminal
{
    public partial class BarTenderTerminalForm : Form
    {
        public BarTenderTerminalForm()
        {
            InitializeComponent();
        }

        private void btnInPreparation_Click(object sender, EventArgs e)
        {
            //TODO: set up dish status to In Preparation
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            //TODO: set up dish status to Ready
        }

        private void btnPicked_Click(object sender, EventArgs e)
        {
            //TODO: set up dish status to Picked
        }

        private void gvDishCollection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
