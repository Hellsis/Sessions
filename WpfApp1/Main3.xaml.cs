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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Main3.xaml
    /// </summary>
    public partial class Main3 : Window
    {
        public Main3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Demands dem = new Demands();
            dem.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Supplies sup = new Supplies();
            sup.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Information inf = new Information();
            inf.Show();
        }
    }
}
