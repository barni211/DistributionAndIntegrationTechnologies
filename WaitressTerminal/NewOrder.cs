using Model;
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

            cbDishType.Items.Add(OrderDestination.Kitchen);
            cbDishType.Items.Add(OrderDestination.Bar);
            cbDishType.SelectedItem = OrderDestination.Kitchen;
            cbDishType.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Destination = (OrderDestination)cbDishType.SelectedItem;
            if (ValidateTextBox())
            {
                order.TableNumber = Int32.Parse(textBox1.Text);
                EditOrder editOrderForm = new EditOrder(order);
                this.Hide();
                editOrderForm.ShowDialog();
                order = editOrderForm.GetCreatedOrder();
            }
            else
            {
                MessageBox.Show("Table number should be a numeric value.");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateTextBox()
        {
            try
            {
                Int32.Parse(textBox1.Text);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
