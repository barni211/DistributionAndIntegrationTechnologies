﻿using BarTenderTerminal;
using CommonOperations;
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

namespace KitchenTerminal
{
    public partial class KitchenTerminal : Form
    {
        private List<Order> _orderList;
        public KitchenTerminal()
        {
            InitializeComponent();
            SetUpTestData();
        }


        private void SetUpTestData()
        {
            List<Dish> dishList = new List<Dish>();
            dishList.Add(new Dish() { Id = 1, Name = "Dish1", Status = OrderStatus.Sended, Type = OrderDestination.Kitchen });
            dishList.Add(new Dish() { Id = 2, Name = "Dish2", Status = OrderStatus.Sended, Type = OrderDestination.Kitchen });
            dishList.Add(new Dish() { Id = 3, Name = "Dish3", Status = OrderStatus.Sended, Type = OrderDestination.Kitchen });

            _orderList = new List<Order>();
            _orderList.Add(new Order() { Id = "1", Destination = OrderDestination.Kitchen, Status = OrderStatus.Sended, TableNumber = 1, Dishes = dishList });
            _orderList.Add(new Order() { Id = "2", Destination = OrderDestination.Kitchen, Status = OrderStatus.Sended, TableNumber = 1, Dishes = dishList });
            _orderList.Add(new Order() { Id = "3", Destination = OrderDestination.Kitchen, Status = OrderStatus.Sended, TableNumber = 1, Dishes = dishList });
            gvDishCollection.DataSource = _orderList;
        }

        private void btnInPreparation_Click(object sender, EventArgs e)
        {
            Order orderToUpdate = GvOperations.GetSelectedOrder(gvDishCollection);
            GvOperations.UpdateOrder(orderToUpdate, OrderStatus.Preparation, gvDishCollection);
            ShowDishes dishesForm = new ShowDishes(orderToUpdate);
            dishesForm.ShowDialog();
            GvOperations.UpdateOrder(orderToUpdate, dishesForm.CurrentStatus(), gvDishCollection);
            //TODO: Send information to server
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            Order orderToUpdate = GvOperations.GetSelectedOrder(gvDishCollection);
            GvOperations.UpdateOrder(orderToUpdate, OrderStatus.ReadyToPick, gvDishCollection);
            //TODO: Send information to server
        }

        private void btnPicked_Click(object sender, EventArgs e)
        {
            Order orderToUpdate = GvOperations.GetSelectedOrder(gvDishCollection);
            GvOperations.UpdateOrder(orderToUpdate, OrderStatus.Picked, gvDishCollection);
            //TODO: Send information to server
        }

        private void gvDishCollection_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GvOperations.ColorGridviewRows(gvDishCollection);
        }
    }
}
