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
    /// Логика взаимодействия для WindowBasket.xaml
    /// </summary>
    public partial class WindowBasket : Window
    {
        public WindowBasket()
        {
            InitializeComponent();
        }

        private void Btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu menuWindow = new WindowMenu();
            menuWindow.Show();
            this.Close();
        }
    }
}
