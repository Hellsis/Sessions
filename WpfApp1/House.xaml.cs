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
    /// Логика взаимодействия для House1.xaml
    /// </summary>
    public partial class House : Window
    {
        public House()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int plus;
            int minus;
            try
            {
                Entities db = new Entities();
                db.houses.Load();
                house newAp = new house();
                newAp.Address_City = Ac.Text;
                newAp.Address_House = Ah.Text;
                newAp.Address_Number = An.Text;
                newAp.Address_Street = As.Text;
                try
                {
                    plus = Convert.ToInt32(Cl.Text);
                    minus = Convert.ToInt32(Cl.Text);
                    if (plus >= -90 && minus <= 180)
                    {
                        newAp.Coordinate_latitude = Cl.Text;

                    }
                    else
                    {
                        newAp.Coordinate_latitude = "";
                    }
                }
                catch
                {
                    newAp.Coordinate_latitude = "";
                }

                try
                {
                    plus = Convert.ToInt32(Clo.Text);
                    minus = Convert.ToInt32(Clo.Text);
                    if (plus >= -90 && minus <= 180)
                    {
                        newAp.Coordinate_longitude = Clo.Text;
                    }
                    else
                    {
                        newAp.Coordinate_longitude = "";
                    }
                }
                catch
                {
                    newAp.Coordinate_longitude = "";
                }
                newAp.TotalFloors = F.Text;
                newAp.TotalArea = Convert.ToDouble(Ta.Text);
                db.houses.Add(newAp);
                db.SaveChanges();
            }
            catch
            {

            }
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Entities db = new Entities();
                db.houses.Load();
                var nub = Convert.ToInt64(DeleteId.Text);
                house delS = db.houses.Where(p => p.Id == nub).FirstOrDefault();
                db.houses.Remove(delS);
                db.SaveChanges();
            }
            catch
            {

            }
            
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int plus;
            int minus;
            try
            {
                Entities db = new Entities();
                db.houses.Load();
                var nub = Convert.ToInt64(UpdateId.Text);
                house newAp = db.houses.Where(p => p.Id == nub).FirstOrDefault();
                if (AcU.Text != "")
                {
                    newAp.Address_City = AcU.Text;
                }
                if (AhU.Text != "")
                {
                    newAp.Address_House = AhU.Text;
                }
                if (AnU.Text != "")
                {
                    newAp.Address_Number = AnU.Text;
                }
                if (AsU.Text != "")
                {
                    newAp.Address_Street = AsU.Text;
                }
                if (ClU.Text != "")
                {
                    try
                    {
                        plus = Convert.ToInt32(ClU.Text);
                        minus = Convert.ToInt32(ClU.Text);
                        if (plus >= -90 && minus <= 180)
                        {
                            newAp.Coordinate_latitude = ClU.Text;

                        }
                    }
                    catch
                    {

                    }


                }
                if (CloU.Text != "")
                {
                    try
                    {
                        plus = Convert.ToInt32(CloU.Text);
                        minus = Convert.ToInt32(CloU.Text);
                        if (plus >= -90 && minus <= 180)
                        {
                            newAp.Coordinate_longitude = CloU.Text;
                        }
                    }
                    catch
                    {

                    }


                }
                if (FU.Text != "")
                {
                    newAp.TotalFloors = FU.Text;
                }
                if (TaU.Text != "")
                {
                    newAp.TotalArea = Convert.ToDouble(TaU.Text);
                }

                db.SaveChanges();
            }
            catch
            {

            }
            
        }
    }
}
