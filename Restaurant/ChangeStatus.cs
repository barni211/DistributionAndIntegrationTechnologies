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

namespace Restaurant
{
    public partial class ChangeStatus : Form
    {
        private OrderStatus _status;
        public ChangeStatus()
        {
            InitializeComponent();
            FillUpComboBox();
        }

        public ChangeStatus(OrderStatus status)
        {
            InitializeComponent();
            _status = status;
            FillUpComboBox();
        }

        private void FillUpComboBox()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(OrderStatus));
            comboBox1.SelectedItem = _status;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _status = (OrderStatus)comboBox1.SelectedItem;
            this.Close();
        }

        public OrderStatus GetOrderStatus()
        {
            return _status;
        }
    }
}
