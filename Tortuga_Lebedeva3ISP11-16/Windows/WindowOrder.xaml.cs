using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tortuga_Lebedeva3ISP11_16.ClassHelper;

namespace Tortuga_Lebedeva3ISP11_16.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowOrder.xaml
    /// </summary>
    public partial class WindowOrder : Window
    {
        public WindowOrder()
        {
            InitializeComponent();
        }

        public WindowOrder(DataBase.DishMenu dish)
        {
            InitializeComponent();

            txt_Name.Text = dish.Name;
            txt_Desc.Text = dish.Description;
            txt_Time.Text = dish.PreparingTimeMin.ToString();
            txt_Sum.Text = dish.Cost.ToString();
            txt_Portions.Text = dish.Size.ToString();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Order_Click(object sender, RoutedEventArgs e)
        {
            var btnAddToCart = sender as Button;

            if (btnAddToCart == null)
                return;
            var dish = btnAddToCart.DataContext as DataBase.DishMenu;

            if (dish == null)
                return;

            //foreach (var item in ProductData.dishmenu)
            //{
            //    if (item == dish)
            //    {
            //        item.Count++;
            //        return;
            //    }
            //}
            ProductData.dishmenu.Add(dish);
        }
    }
}
