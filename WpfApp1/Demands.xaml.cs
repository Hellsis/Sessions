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
    /// Логика взаимодействия для Demands.xaml
    /// </summary>
    public partial class Demands : Window
    {
        public Demands()
        {
            InitializeComponent();
            Entities db = new Entities();
            foreach(var i in db.agents)
            {
                AId.Items.Add(i.FirstName);
            }
            foreach (var i in db.agents)
            {
                AIdU.Items.Add(i.FirstName);
            }
            foreach (var i in db.clients)
            {
                CId.Items.Add(i.FirstName);
            }
            foreach (var i in db.clients)
            {
                CIdU.Items.Add(i.FirstName);
            }
           

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MinR.Visibility = Visibility.Hidden;
            MaxR.Visibility = Visibility.Hidden;
            MinF.Visibility = Visibility.Hidden;
            MaxF.Visibility = Visibility.Hidden;
            MinRooms.Visibility = Visibility.Hidden;
            MaxRooms.Visibility = Visibility.Hidden;
            MinFloor.Visibility = Visibility.Hidden;
            MaxFloor.Visibility = Visibility.Hidden;
        }
        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            MinR.Visibility = Visibility.Visible;
            MaxR.Visibility = Visibility.Visible;
            MinF.Visibility = Visibility.Visible;
            MaxF.Visibility = Visibility.Visible;
            MinRooms.Visibility = Visibility.Visible;
            MaxRooms.Visibility = Visibility.Visible;
            MinFloor.Visibility = Visibility.Visible;
            MaxFloor.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MinR.Visibility = Visibility.Visible;
            MaxR.Visibility = Visibility.Visible;
            MinF.Visibility = Visibility.Visible;
            MaxF.Visibility = Visibility.Visible;
            MinRooms.Visibility = Visibility.Visible;
            MaxRooms.Visibility = Visibility.Visible;
            MinFloor.Visibility = Visibility.Visible;
            MaxFloor.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Ap.IsChecked == true)
                {
                    int MaxP = 0;
                    var MinP = 0;
                    Entities db = new Entities();
                    if (Maxp.Text != "")
                    {
                        MaxP = Convert.ToInt32(Maxp.Text);
                    }
                    if (Minp.Text != "")
                    {
                        MinP = Convert.ToInt32(Maxp.Text);
                    }

                    agent fo = db.agents.Where(p => p.FirstName == AId.SelectedItem.ToString()).FirstOrDefault();
                    client of = db.clients.Where(p => p.FirstName == CId.SelectedItem.ToString()).FirstOrDefault();
                    var apnew = new apartment_demands();
                    apnew.MaxArea = MaxA.Text;
                    apnew.MinArea = MinA.Text;
                    apnew.MaxFloor = MaxF.Text;
                    apnew.MinFloor = MinF.Text;

                    apnew.MaxPrice = MaxP;
                    apnew.MinPrice = MinP;
                    apnew.MaxRooms = MaxR.Text;
                    apnew.MinRooms = MinR.Text;
                    apnew.Address_City = Ac.Text;
                    apnew.Address_House = Ah.Text;
                    apnew.Address_Number = An.Text;
                    apnew.Address_Street = As.Text;
                    apnew.AgentId = fo.Id;
                    apnew.ClientId = of.Id;
                    db.apartment_demands.Add(apnew);
                    db.SaveChanges();
                }
                if (Ho.IsChecked == true)
                {
                    int MaxP = 0;
                    var MinP = 0;
                    Entities db = new Entities();
                    if (Maxp.Text != "")
                    {
                        MaxP = Convert.ToInt32(Maxp.Text);
                    }
                    if (Minp.Text != "")
                    {
                        MinP = Convert.ToInt32(Maxp.Text);
                    }

                    agent fo = db.agents.Where(p => p.FirstName == AId.SelectedItem.ToString()).FirstOrDefault();
                    client of = db.clients.Where(p => p.FirstName == CId.SelectedItem.ToString()).FirstOrDefault();
                    var apnew = new house_demands();
                    apnew.MaxArea = MaxA.Text;
                    apnew.MinArea = MinA.Text;
                    apnew.MaxFloors = MaxF.Text;
                    apnew.MinFloors = MinF.Text;
                    apnew.MaxPrice = MaxP;
                    apnew.MinPrice = MinP;
                    apnew.MaxRooms = MaxR.Text;
                    apnew.MinRooms = MinR.Text;
                    apnew.Address_City = Ac.Text;
                    apnew.Address_House = Ah.Text;
                    apnew.Address_Number = An.Text;
                    apnew.Address_Street = As.Text;
                    apnew.AgentId = fo.Id;
                    apnew.ClientId = of.Id;
                    db.house_demands.Add(apnew);
                    db.SaveChanges();
                }
                if (La.IsChecked == true)
                {
                    Entities db = new Entities();
                    int MaxP = 0;
                    var MinP = 0;
                    if (Maxp.Text != "")
                    {
                        MaxP = Convert.ToInt32(Maxp.Text);
                    }
                    if (Minp.Text != "")
                    {
                        MinP = Convert.ToInt32(Maxp.Text);
                    }
                    agent fo = db.agents.Where(p => p.FirstName == AId.SelectedItem.ToString()).FirstOrDefault();
                    client of = db.clients.Where(p => p.FirstName == CId.SelectedItem.ToString()).FirstOrDefault();
                    var apnew = new land_demands();
                    apnew.MaxArea = MaxA.Text;
                    apnew.MinArea = MinA.Text;
                    apnew.MaxPrice = MaxP;
                    apnew.MinPrice = MinP;
                    apnew.Address_City = Ac.Text;
                    apnew.Address_House = Ah.Text;
                    apnew.Address_Number = An.Text;
                    apnew.Address_Street = As.Text;
                    apnew.AgentId = fo.Id;
                    apnew.ClientId = of.Id;
                    db.land_demands.Add(apnew);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Ap.IsChecked == true)
                {
                    Entities db = new Entities();
                    var nub = Convert.ToInt32(IdD.Text);
                    apartment_demands ap = db.apartment_demands.Where(p => p.Id == nub).FirstOrDefault();
                    db.apartment_demands.Remove(ap);
                    db.SaveChanges();
                }
                if (Ho.IsChecked == true)
                {
                    Entities db = new Entities();
                    var nub = Convert.ToInt32(IdD.Text);
                    house_demands ap = db.house_demands.Where(p => p.Id == nub).FirstOrDefault();
                    db.house_demands.Remove(ap);
                    db.SaveChanges();
                }
                if (La.IsChecked == true)
                {
                    Entities db = new Entities();
                    var nub = Convert.ToInt32(IdD.Text);
                    land_demands ap = db.land_demands.Where(p => p.Id == nub).FirstOrDefault();
                    db.land_demands.Remove(ap);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Ap.IsChecked == true)
                {
                    Entities db = new Entities();
                    int MinP = Convert.ToInt32(Maxp.Text);
                     int MaxP = Convert.ToInt32(Maxp.Text);
                    agent fo = db.agents.Where(p => p.FirstName == AIdU.SelectedItem.ToString()).FirstOrDefault();
                    client of = db.clients.Where(p => p.FirstName == CIdU.SelectedItem.ToString()).FirstOrDefault();
                    var nub = Convert.ToInt32(IdU.Text);
                    var apnew = db.apartment_demands.Where(p => p.Id == nub).FirstOrDefault();
                    if (MaxAU.Text != "")
                    {
                        apnew.MaxArea = MaxAU.Text;
                    }
                    if (MinAU.Text != "")
                    {
                        apnew.MinArea = MinAU.Text;
                    }
                    if (MaxFU.Text != "")
                    {
                        apnew.MaxFloor = MaxFU.Text;
                    }
                    if (MinFU.Text != "")
                    {
                        apnew.MinFloor = MinFU.Text;
                    }
                    if (MaxPU.Text != "")
                    {
                        apnew.MaxPrice = MaxP;
                    }
                    if (MinPU.Text != "")
                    {
                        apnew.MinPrice = MinP;
                    }
                    if (MaxRU.Text != "")
                    {
                        apnew.MaxRooms = MaxRU.Text;
                    }
                    if (MinRU.Text != "")
                    {
                        apnew.MinRooms = MinRU.Text;
                    }
                    if (AcU.Text != "")
                    {
                        apnew.Address_City = AcU.Text;
                    }
                    if (AhU.Text != "")
                    {
                        apnew.Address_House = AhU.Text;
                    }
                    if (AnU.Text != "")
                    {
                        apnew.Address_Number = AnU.Text;
                    }
                    if (AsU.Text != "")
                    {
                        apnew.Address_Street = AsU.Text;
                    }
                    apnew.AgentId = fo.Id;
                    apnew.ClientId = of.Id;
                    db.SaveChanges();
                }
                if (Ho.IsChecked == true)
                {
                    Entities db = new Entities();
                    int MinP = Convert.ToInt32(Maxp.Text);
                    int MaxP = Convert.ToInt32(Maxp.Text);
                    agent fo = db.agents.Where(p => p.FirstName == AIdU.SelectedItem.ToString()).FirstOrDefault();
                    client of = db.clients.Where(p => p.FirstName == CIdU.SelectedItem.ToString()).FirstOrDefault();
                    var nub = Convert.ToInt32(IdU.Text);
                    var apnew = db.house_demands.Where(p => p.Id == nub).FirstOrDefault();
                    if (MaxAU.Text != "")
                    {
                        apnew.MaxArea = MaxAU.Text;
                    }
                    if (MinAU.Text != "")
                    {
                        apnew.MinArea = MinAU.Text;
                    }
                    if (MaxFU.Text != "")
                    {
                        apnew.MaxFloors = MaxFU.Text;
                    }
                    if (MinFU.Text != "")
                    {
                        apnew.MinFloors = MinFU.Text;
                    }
                    if (MaxPU.Text != "")
                    {
                        apnew.MaxPrice = MaxP;
                    }
                    if (MinPU.Text != "")
                    {
                        apnew.MinPrice = MinP;
                    }
                    if (MaxRU.Text != "")
                    {
                        apnew.MaxRooms = MaxRU.Text;
                    }
                    if (MinRU.Text != "")
                    {
                        apnew.MinRooms = MinRU.Text;
                    }
                    if (AcU.Text != "")
                    {
                        apnew.Address_City = AcU.Text;
                    }
                    if (AhU.Text != "")
                    {
                        apnew.Address_House = AhU.Text;
                    }
                    if (AnU.Text != "")
                    {
                        apnew.Address_Number = AnU.Text;
                    }
                    if (AsU.Text != "")
                    {
                        apnew.Address_Street = AsU.Text;
                    }
                    apnew.AgentId = fo.Id;
                    apnew.ClientId = of.Id;
                    db.SaveChanges();
                }
                if (La.IsChecked == true)
                {
                    int MinP = Convert.ToInt32(Maxp.Text);
                    int MaxP = Convert.ToInt32(Maxp.Text);
                    Entities db = new Entities();
                    agent fo = db.agents.Where(p => p.FirstName == AIdU.SelectedItem.ToString()).FirstOrDefault();
                    client of = db.clients.Where(p => p.FirstName == CIdU.SelectedItem.ToString()).FirstOrDefault();
                    var nub = Convert.ToInt32(IdU.Text);
                    var apnew = db.land_demands.Where(p => p.Id == nub).FirstOrDefault();
                    if (MaxAU.Text != "")
                    {
                        apnew.MaxArea = MaxAU.Text;
                    }
                    if (MinAU.Text != "")
                    {
                        apnew.MinArea = MinAU.Text;
                    }
                    if (MaxPU.Text != "")
                    {
                        apnew.MaxPrice = MaxP;
                    }
                    if (MinPU.Text != "")
                    {
                        apnew.MinPrice = MinP;
                    }
                    if (AcU.Text != "")
                    {
                        apnew.Address_City = AcU.Text;
                    }
                    if (AhU.Text != "")
                    {
                        apnew.Address_House = AhU.Text;
                    }
                    if (AnU.Text != "")
                    {
                        apnew.Address_Number = AnU.Text;
                    }
                    if (AsU.Text != "")
                    {
                        apnew.Address_Street = AsU.Text;
                    }
                    apnew.AgentId = fo.Id;
                    apnew.ClientId = of.Id;
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
    }
}
