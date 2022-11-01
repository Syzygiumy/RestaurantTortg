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

namespace Tortuga_Lebedeva3ISP11_16.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        List<DataBase.Menu> listMenu = new List<DataBase.Menu>();

        private int catID;

        public WindowMenu()
        {
            InitializeComponent();
            GetProductList();
        }

        private void GetProductList()
        {

            lv_Menu.ItemsSource = ClassHelper.AppData.context.Menu.ToList();
        }
        private void GetProductList(int catID)
        {

            lv_Menu.ItemsSource = ClassHelper.AppData.context.Menu.Where(i => i.CategoryID == catID).ToList();


        }

        private void Btn_Backet_Click(object sender, RoutedEventArgs e)
        {
            WindowBasket basketWindow = new WindowBasket();
            basketWindow.Show();
            this.Close();
        }

        private void Dtn_Dish1_Click(object sender, RoutedEventArgs e)
        {
            WindowDish dishWindow = new WindowDish();
            this.Opacity = 0.2;
            dishWindow.ShowDialog();
            this.Opacity = 1;
        }

        private void Dtn_Order_Click(object sender, RoutedEventArgs e)
        {
            WindowOrder orderWindow = new WindowOrder();
            this.Opacity = 0.2;
            orderWindow.ShowDialog();
            this.Opacity = 1;
        }

        private void btn_Cat_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
            {
                return;
            }

            catID = Int32.Parse(btn.Name.Substring(btn.Name.Length - 1));
            
            GetProductList(catID);
        }
    }
}
