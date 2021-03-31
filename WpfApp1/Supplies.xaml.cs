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
    /// Логика взаимодействия для Supplies.xaml
    /// </summary>
    public partial class Supplies : Window
    {
        public Supplies()
        {
            InitializeComponent();
            Entities db = new Entities();
            foreach (var i in db.agents)
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
            foreach (var i in db.apartments)
            {
                ApId.Items.Add(i.Id);
            }
            foreach (var i in db.apartments)
            {
                ApIdU.Items.Add(i.Id);
            }
            foreach (var i in db.houses)
            {
                HId.Items.Add(i.Id);
            }
            foreach (var i in db.houses)
            {
                HIdU.Items.Add(i.Id);
            }
            foreach (var i in db.lands)
            {
                LId.Items.Add(i.Id);
            }
            foreach (var i in db.lands)
            {
                LIdU.Items.Add(i.Id);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            
            Entities db = new Entities();
            int MaxP = 0;
            int Aid = Convert.ToInt32(ApId.SelectedItem);
            int Hid = Convert.ToInt32(HId.SelectedItem);
            int Lid = Convert.ToInt32(LId.SelectedItem);
            if (Price.Text != "")
            {
                MaxP = Convert.ToInt32(Price.Text);
            }
            
            agent fo = db.agents.Where(p => p.FirstName == AId.SelectedItem.ToString()).FirstOrDefault();
            client of = db.clients.Where(p => p.FirstName == CId.SelectedItem.ToString()).FirstOrDefault();
            var apnew = new supply();
            apnew.Price = MaxP;
            apnew.AgentId = fo.Id;
            apnew.ClientId = of.Id;
            apnew.ApartmentId = Aid;
            apnew.HouseId = Hid;
            apnew.LandId = Lid;
            db.supplies.Add(apnew);
            db.SaveChanges();
            }
            catch
            {

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

            
            Entities db = new Entities();
            var nub = Convert.ToInt32(IdD.Text);
            supply ap = db.supplies.Where(p => p.Id == nub).FirstOrDefault();
            db.supplies.Remove(ap);
            db.SaveChanges();
            }
            catch
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {

            
            Entities db = new Entities();
            int MaxP = 0;
            int id = Convert.ToInt32(IdU.Text);
            int Aid = Convert.ToInt32(ApId.SelectedItem);
            int Hid = Convert.ToInt32(HId.SelectedItem);
            int Lid = Convert.ToInt32(LId.SelectedItem);
            if (Price.Text != "")
            {
                MaxP = Convert.ToInt32(Price.Text);
            }
            agent fo = db.agents.Where(p => p.FirstName == AIdU.SelectedItem.ToString()).FirstOrDefault();
            client of = db.clients.Where(p => p.FirstName == CIdU.SelectedItem.ToString()).FirstOrDefault();
            var apnew = db.supplies.Where(p=>p.Id==id).FirstOrDefault();
            if (Price.Text == "")
            {
                apnew.Price = apnew.Price;
            }
            apnew.AgentId = fo.Id;
            apnew.ClientId = of.Id;
            apnew.ApartmentId = Aid;
            apnew.HouseId = Hid;
            apnew.LandId = Lid;
            db.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
