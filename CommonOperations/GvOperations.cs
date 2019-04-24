using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CommonOperations
{
    public abstract class GvOperations
    {

        public static void UpdateOrder(Order order, OrderStatus status, DataGridView gvOrders)
        {
            int selectedrowindex = gvOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvOrders.Rows[selectedrowindex];

            List<Order> ordersFromGv = gvOrders.DataSource as List<Order>;
            if (ordersFromGv != null)
            {
                ordersFromGv.ElementAt(selectedrowindex).Status = status;
            }

            gvOrders.DataSource = null;
            gvOrders.DataSource = ordersFromGv;
        }

        public static Order GetSelectedOrder(DataGridView gvOrders)
        {
            int selectedrowindex = gvOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvOrders.Rows[selectedrowindex];
            return (Order)selectedRow.DataBoundItem;
        }
    }
}
