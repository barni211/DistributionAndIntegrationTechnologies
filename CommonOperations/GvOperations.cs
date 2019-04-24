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

        public static void AddOrderToGv(Order newOrder, DataGridView gvOrders)
        {
            List<Order> ordersFromGv = gvOrders.DataSource as List<Order>;
            if (ordersFromGv != null)
            {
                ordersFromGv.Add(newOrder);
            }
            else
            {
                ordersFromGv = new List<Order>();
                ordersFromGv.Add(newOrder);
            }

            //hack to refresh datagridview, looking for better solution
            gvOrders.DataSource = null;
            gvOrders.DataSource = ordersFromGv;
        }

        public static void DeleteOrder(DataGridView gvOrders)
        {
            int selectedrowindex = gvOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvOrders.Rows[selectedrowindex];

            List<Order> ordersFromGv = gvOrders.DataSource as List<Order>;
            if (ordersFromGv != null && ordersFromGv.ElementAt(selectedrowindex).Status == OrderStatus.NotSend)
            {
                ordersFromGv.RemoveAt(selectedrowindex);
                gvOrders.DataSource = null;
                gvOrders.DataSource = ordersFromGv;
            }
            else
            {
                MessageBox.Show("Delete sended order is not allowed");
            }
        }

        public static void DeleteOrder(DataGridView gvOrders, bool force = false)
        {
            int selectedrowindex = gvOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvOrders.Rows[selectedrowindex];

            List<Order> ordersFromGv = gvOrders.DataSource as List<Order>;
            if (ordersFromGv != null)
            {
                ordersFromGv.RemoveAt(selectedrowindex);
                gvOrders.DataSource = null;
                gvOrders.DataSource = ordersFromGv;
            }
            else
            {
                MessageBox.Show("There is no any existing order.");
            }
        }

        public static void ColorGridviewRows(DataGridView gvOrders)
        {
            if (gvOrders.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gvOrders.Rows)
                {
                    if(row.Cells[2].Value == null)
                    {
                        continue;
                    }

                    OrderStatus status = (OrderStatus)row.Cells[2].Value;
                    if (status == OrderStatus.Picked || status == OrderStatus.Delivered || status == OrderStatus.Paid)
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
