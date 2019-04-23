using System;
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
    public partial class WaitressTerminalForm : Form
    {
        private ConnectionHandler _connection;
        public WaitressTerminalForm()
        {
            InitializeComponent();
            _connection = new ConnectionHandler();
            _connection.CreateConnection();
        }

        private void WaitressTerminalForm_Load(object sender, EventArgs e)
        {
            _connection.InvokeFunc1();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            //TODO: Create new order and open edit order form (in parameter Pass type of order kitchen/bar)
            NewOrder editOrderForm = new NewOrder();
            editOrderForm.ShowDialog();
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            //TODO: Edit existing order in order form 
            EditOrder editOrderForm = new EditOrder();
            editOrderForm.ShowDialog();
        }
    }
}
