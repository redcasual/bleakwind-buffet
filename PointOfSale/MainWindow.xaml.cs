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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void EntreeOpen(object sender, RoutedEventArgs e)
        {
            var ent = new EntreesDisp();
            window.Child = ent;
        }

        void SideOpen(object sender, RoutedEventArgs e)
        {
            var s = new SidesDisp();
            window.Child = s;
        }

        void DrinkOpen(object sender, RoutedEventArgs e)
        {
            var d = new DrinksDisp();
            window.Child = d;
        }
    }
}
