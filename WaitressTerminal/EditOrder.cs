﻿using Model;
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
    public partial class EditOrder : Form
    {
        private Order order;
        public EditOrder()
        {
            InitializeComponent();

            FillUpKitchenDishes();
            //FillUpBarDishes();
        }

        public EditOrder(Order order)
        {

        }

        private void FillUpKitchenDishes()
        {
            List<IDishes> dishList = new List<IDishes>();

            dishList.Add(new KitchenDishes { Id = 1, Name = "Scrambled eggs", Price = 10, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 2, Name = "Chicken burger", Price = 19, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 3, Name = "Ham burger", Price = 19, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 4, Name = "Grilled chicken with fries", Price = 29, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 5, Name = "Grilled chicken with potatoes", Price = 29, Type = OrderDestination.Kitchen });

            gvDishCollection.DataSource = dishList;
        }

        private void FillUpBarDishes()
        {
            List<IDishes> dishList = new List<IDishes>();

            dishList.Add(new BarDishes { Id = 1, Name = "Tea", Price = 2, Type = OrderDestination.Bar });
            dishList.Add(new BarDishes { Id = 2, Name = "Coffee", Price = 3, Type = OrderDestination.Bar });
            dishList.Add(new BarDishes { Id = 3, Name = "Beer", Price = 4, Type = OrderDestination.Bar });
            dishList.Add(new BarDishes { Id = 4, Name = "Cola", Price = 2, Type = OrderDestination.Bar });
            dishList.Add(new BarDishes { Id = 5, Name = "Mohito", Price = 5, Type = OrderDestination.Bar });

            gvDishCollection.DataSource = dishList;
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            AddKitchenDish();
        }

        private void AddKitchenDish()
        {
            List<KitchenDishes> orderedDishes = new List<KitchenDishes>();
            List<KitchenDishes> dishesInGv = gvOrderedDishes.DataSource as List<KitchenDishes>;
            if (dishesInGv != null && dishesInGv.Count > 0)
            {
                foreach (KitchenDishes dish in dishesInGv)
                {
                    orderedDishes.Add(dish);
                }
            }

            if (gvDishCollection.SelectedCells.Count > 0)
            {
                int selectedrowindex = gvDishCollection.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gvDishCollection.Rows[selectedrowindex];
                KitchenDishes dish = (KitchenDishes)selectedRow.DataBoundItem;
                orderedDishes.Add(dish);
            }

            gvOrderedDishes.DataSource = orderedDishes;
        }
    }
}
