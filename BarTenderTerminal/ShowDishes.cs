using Model;
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
    public partial class ShowDishes : Form
    {
        private Order _order;
        public ShowDishes()
        {
            InitializeComponent();
        }

        public ShowDishes(Order order)
        {
            InitializeComponent();
            _order = order;
            gvOrderedDishes.DataSource = _order.Dishes;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.ReadyToPick;
            this.Close();
        }

        public OrderStatus CurrentStatus()
        {
            return _order.Status;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Sended;
            this.Close();
        }
    }
}
