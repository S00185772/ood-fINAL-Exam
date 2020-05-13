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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vitorBarbosa_S00185772
{
    
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();

        List<Phone> phones = new List<Phone>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Phone p1 = new Phone() { phoneName ="Samsung S20", phonePrice = 500, OsName="Android", OsImage="/images/android.png", phoneImage="/images/s20.jpg" };

            //Phone p2 = new Phone() { phoneName = "iPhone 11", phonePrice = 600, OsName = "Ios", OsImage = "/images/apple.png", phoneImage = "/images/iPhone11.png" };

            //phones.Add(p1);
            //phones.Add(p2);

            var query = from p in db.Phones
                        select p.phoneName;
            

            var Phones = query.ToList() ;

            lbxPhone.ItemsSource = Phones;

        }

        private void lbxPhone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxPhone.SelectedItem == db.)
         // TBlkPrice.Text 
        }
    }
}
