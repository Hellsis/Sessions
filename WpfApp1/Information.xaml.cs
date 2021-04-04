using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            try
            {
                int ident = Convert.ToInt32(Identificator.Text);
                db.supplies.Load();
                if (Age.IsChecked == true)
                {
                    Grid.ItemsSource = db.supplies.Local.Where(p => p.AgentId == ident);
                }
                if (Cli.IsChecked == true)
                {
                    Grid.ItemsSource = db.supplies.Local.Where(p => p.ClientId == ident);
                }
            }
            catch
            {

            }
           
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            try
            {
                int ident = Convert.ToInt32(Identificator.Text);
                db.land_demands.Load();
                if (Age.IsChecked == true)
                {
                    Grid.ItemsSource = db.land_demands.Local.Where(p => p.AgentId == ident);
                }
                if (Cli.IsChecked == true)
                {
                    Grid.ItemsSource = db.land_demands.Local.Where(p => p.ClientId == ident);
                }
            }
            catch
            {

            }

        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            try
            {
                int ident = Convert.ToInt32(Identificator.Text);
                db.house_demands.Load();
                if (Age.IsChecked == true)
                {
                    Grid.ItemsSource = db.house_demands.Local.Where(p => p.AgentId == ident);
                }
                if (Cli.IsChecked == true)
                {
                    Grid.ItemsSource = db.house_demands.Local.Where(p => p.ClientId == ident);
                }
            }
            catch
            {

            }

        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            try
            {
                int ident = Convert.ToInt32(Identificator.Text);
                db.apartment_demands.Load();
                if (Age.IsChecked == true)
                {
                    Grid.ItemsSource = db.apartment_demands.Local.Where(p => p.AgentId == ident);
                }
                if (Cli.IsChecked == true)
                {
                    Grid.ItemsSource = db.apartment_demands.Local.Where(p => p.ClientId == ident);
                }
            }
            catch
            {

            }

        }
    }
}
