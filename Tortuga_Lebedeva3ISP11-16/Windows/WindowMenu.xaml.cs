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
using Tortuga_Lebedeva3ISP11_16.DataBase;

namespace Tortuga_Lebedeva3ISP11_16.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        List<DataBase.DishMenu> listMenu = new List<DataBase.DishMenu>();

        private int catID;

        public WindowMenu()
        {
            InitializeComponent();
            GetProductList();
        }

        private void GetProductList()
        {

            lv_Menu.ItemsSource = ClassHelper.AppData.context.DishMenu.ToList();
        }
        private void GetProductList(int catID)
        {
            lv_Menu.ItemsSource = ClassHelper.AppData.context.DishMenu.Where(i => i.CategoryID == catID).ToList();
        }

        private void Btn_Backet_Click(object sender, RoutedEventArgs e)
        {
            WindowBasket basketWindow = new WindowBasket();
            basketWindow.Show();
            this.Close();
        }

        private void Dtn_Dish1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
                return;
            var dish = btn.DataContext as DishMenu;

            if (dish != null)
            {

                WindowDish dishWindow = new WindowDish(dish);
                this.Opacity = 0.2;
                dishWindow.ShowDialog();
                this.Opacity = 1;
            }
        }

        private void Dtn_Order_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
                return;
            var dish = btn.DataContext as DishMenu;
            
            if (dish != null)
            {
                WindowOrder orderWindow = new WindowOrder(dish);
                this.Opacity = 0.2;
                orderWindow.ShowDialog();
                this.Opacity = 1;
            }
            
        }

        private void btn_Cat_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
            {
                return;
            }

            catID = Int32.Parse(btn.Name.Substring(btn.Name.Length - 1));

            //-------------Смена цвета иконок-----------------------
            
            //Горячие закуски
            if(catID == 1)
            {
                Img_GorZakOn.Opacity = 100;
            }
            else
            {
                Img_GorZakOn.Opacity = 0;
            }

            //Холодные закуски
            if (catID == 2)
            {
                Img_HolZakOn.Opacity = 100;
            }
            else
            {
                Img_HolZakOn.Opacity = 0;
            }

            //Суши
            if (catID == 3)
            {
                Img_SushiOn.Opacity = 100;
            }
            else
            {
                Img_SushiOn.Opacity = 0;
            }

            //Роллы
            if (catID == 4)
            {
                Img_RolliOn.Opacity = 100;
            }
            else
            {
                Img_RolliOn.Opacity = 0;
            }

            //Супы
            if (catID == 5)
            {
                Img_SoupOn.Opacity = 100;
            }
            else
            {
                Img_SoupOn.Opacity = 0;
            }

            //Горячие блюда
            if (catID == 6)
            {
                Img_HotDishOn.Opacity = 100;
            }
            else
            {
                Img_HotDishOn.Opacity = 0;
            }
            //Десерты
            if (catID == 7)
            {
                Img_DessertOn.Opacity = 100;
            }
            else
            {
                Img_DessertOn.Opacity = 0;
            }

            //-------------Смена цвета иконок-----------------------



            GetProductList(catID);
        }
    }
}
