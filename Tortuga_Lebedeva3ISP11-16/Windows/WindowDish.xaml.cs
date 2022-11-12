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
    /// Логика взаимодействия для WindowDish.xaml
    /// </summary>
    public partial class WindowDish : Window
    {
        List<DataBase.MenuIngredient> listMenu = new List<DataBase.MenuIngredient>();

        public WindowDish()
        {
            InitializeComponent();
        }

        public WindowDish(DataBase.DishMenu dish)
        {
            InitializeComponent();
            txt_Name.Text = dish.Name;
            txt_Desc.Text = dish.Description;
        }

        //public WindowDish(DataBase.DishMenu dish)
        //{
        //    InitializeComponent();
        //    txt_Name.Text = dish.Name;
        //    txt_Desc.Text = dish.Description;
        //}

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
