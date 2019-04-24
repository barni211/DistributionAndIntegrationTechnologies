using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static void ColorGridviewRows(DataGridView gvOrders)
        {
            if (gvOrders.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gvOrders.Rows)
                {
                    OrderStatus status = (OrderStatus)row.Cells[2].Value;
                    if ( status == OrderStatus.Picked)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (status == OrderStatus.Sended)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (status == OrderStatus.Preparation)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (status == OrderStatus.ReadyToPick)
                    {
                        row.DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }

        }
    }
}
