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

namespace WaitressTerminal
{
    public partial class EditOrder : Form
    {
        private Order _order;
        public EditOrder()
        {
            InitializeComponent();

            FillUpKitchenDishes();
            
        }

        public EditOrder(Order order)
        {
            InitializeComponent();

            _order = order != null ?  order :  new Order();

            //workaround to refactor
            if(order == null)
            {
                _order.Destination = OrderDestination.Kitchen;
            }
            
            if(_order.Destination == OrderDestination.Bar)
            {
                FillUpBarDishes();
                gvOrderedDishes.DataSource = _order.Dishes;
            }
            else
            {
                FillUpKitchenDishes();
                gvOrderedDishes.DataSource = _order.Dishes;
            }
        }

        private void FillUpKitchenDishes()
        {
            List<Dish> dishList = new List<Dish>();

            dishList.Add(new Dish { Id = 1, Name = "Scrambled eggs", Price = 10, Type = OrderDestination.Kitchen });
            dishList.Add(new Dish { Id = 2, Name = "Chicken burger", Price = 19, Type = OrderDestination.Kitchen });
            dishList.Add(new Dish { Id = 3, Name = "Ham burger", Price = 19, Type = OrderDestination.Kitchen });
            dishList.Add(new Dish { Id = 4, Name = "Grilled chicken with fries", Price = 29, Type = OrderDestination.Kitchen });
            dishList.Add(new Dish { Id = 5, Name = "Grilled chicken with potatoes", Price = 29, Type = OrderDestination.Kitchen });

            gvDishCollection.DataSource = dishList;
        }

        private void FillUpBarDishes()
        {
            List<Dish> dishList = new List<Dish>();

            dishList.Add(new Dish { Id = 1, Name = "Tea", Price = 2, Type = OrderDestination.Bar });
            dishList.Add(new Dish { Id = 2, Name = "Coffee", Price = 3, Type = OrderDestination.Bar });
            dishList.Add(new Dish { Id = 3, Name = "Beer", Price = 4, Type = OrderDestination.Bar });
            dishList.Add(new Dish { Id = 4, Name = "Cola", Price = 2, Type = OrderDestination.Bar });
            dishList.Add(new Dish { Id = 5, Name = "Mohito", Price = 5, Type = OrderDestination.Bar });

            gvDishCollection.DataSource = dishList;
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {

            //workaround to refactor. It should be done with one method using interface.
            //if (_order.Destination == OrderDestination.Kitchen)
            //{
            //    AddKitchenDish();
            //}
            //else
            //{
                AddDish();
            //}
        }

        private void AddDish()
        {
            List<Dish> orderedDishes = new List<Dish>();
            List<Dish> dishesInGv = gvOrderedDishes.DataSource as List<Dish>;
            if (dishesInGv != null && dishesInGv.Count > 0)
            {
                foreach (Dish dish in dishesInGv)
                {
                    orderedDishes.Add(dish);
                }
            }

            if (gvDishCollection.SelectedCells.Count > 0)
            {
                int selectedrowindex = gvDishCollection.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gvDishCollection.Rows[selectedrowindex];
                Dish dish = (Dish)selectedRow.DataBoundItem;
                orderedDishes.Add(dish);
            }

            gvOrderedDishes.DataSource = orderedDishes;
            _order.Dishes = orderedDishes;
        }

        //private void AddKitchenDish()
        //{
        //    List<KitchenDishes> orderedDishes = new List<KitchenDishes>();
        //    List<KitchenDishes> dishesInGv = gvOrderedDishes.DataSource as List<KitchenDishes>;
        //    if (dishesInGv != null && dishesInGv.Count > 0)
        //    {
        //        foreach (KitchenDishes dish in dishesInGv)
        //        {
        //            orderedDishes.Add(dish);
        //        }
        //    }

        //    if (gvDishCollection.SelectedCells.Count > 0)
        //    {
        //        int selectedrowindex = gvDishCollection.SelectedCells[0].RowIndex;
        //        DataGridViewRow selectedRow = gvDishCollection.Rows[selectedrowindex];
        //        KitchenDishes dish = (KitchenDishes)selectedRow.DataBoundItem;
        //        orderedDishes.Add(dish);
        //    }

        //    gvOrderedDishes.DataSource = orderedDishes;
        //    //_order.Dishes = orderedDishes;
        //}

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Order GetCreatedOrder()
        {
            return _order;
        }

        private void gvDishCollection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Dish> orderedDishes = new List<Dish>();
            List<Dish> dishesInGv = gvOrderedDishes.DataSource as List<Dish>;
            if (dishesInGv != null && dishesInGv.Count > 0)
            {
                foreach (Dish dish in dishesInGv)
                {
                    orderedDishes.Add(dish);
                }
            }

            if (gvOrderedDishes.SelectedCells.Count > 0)
            {
                int selectedrowindex = gvOrderedDishes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gvOrderedDishes.Rows[selectedrowindex];
                Dish dish = (Dish)selectedRow.DataBoundItem;
                orderedDishes.Remove(dish);
            }

            gvOrderedDishes.DataSource = orderedDishes;
            _order.Dishes = orderedDishes;
        }
    }
}
