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
        public EditOrder()
        {
            InitializeComponent();
            FillUpKitchenDishes();
        }

        private void FillUpKitchenDishes()
        {
            List<KitchenDishes> dishList = new List<KitchenDishes>();

            dishList.Add(new KitchenDishes { Id = 1, Name = "Scrambled eggs", Price = 10, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 2, Name = "Chicken burger", Price = 19, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 3, Name = "Ham burger", Price = 19, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 4, Name = "Grilled chicken with fries", Price = 29, Type = OrderDestination.Kitchen });
            dishList.Add(new KitchenDishes { Id = 5, Name = "Grilled chicken with potatoes", Price = 29, Type = OrderDestination.Kitchen });

            gvDishCollection.DataSource = dishList;
        }
    }
}
