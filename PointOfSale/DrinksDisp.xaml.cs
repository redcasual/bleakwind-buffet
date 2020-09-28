using PointOfSale.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class DrinksDisp : UserControl
    {
        public DrinksDisp()
        {
            InitializeComponent();
        }

        void StepBack(object sender, RoutedEventArgs e)
        {
            var men = new MenuDisp();
            
        }

        void AretinoOpen(object sender, RoutedEventArgs e)
        {
            var aj = new AretinoAppleJuice();
            
        }

        void CoffeeOpen(object sender, RoutedEventArgs e)
        {

        }

        void MilkOpen(object sender, RoutedEventArgs e)
        {

        }

        void SodaOpen(object sender, RoutedEventArgs e)
        {

        }

        void WaterOpen(object sender, RoutedEventArgs e)
        {

        }
    }
}
