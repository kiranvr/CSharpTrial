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

namespace TryCollectionClass
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Car c1 = new Car() { regno = 1, value = 20 };
            Car c2 = new Car() { regno = 2, value = 30 };
            Car c3 = new Car() { regno = 3, value = 40 };

            CarList cl = new CarList();
            cl.Add(c1);
            cl.Add(c2);
            cl.Add(c3);

            foreach (var car in cl)
            {
                Console.WriteLine(car.value);
            }

            MessageBox.Show(Retailer.GetCarsVal(cl).ToString());
             MessageBox.Show(cl.GetCarsVal().ToString());

        }
    }

    class CarList:List<Car>
    {
        public   int GetCarsVal()
        {
            return Retailer.GetCarsVal(this.ToList<Car>());
            
            
        }
    }

    class Car
    {
        public int regno { get; set; }
        public int value { get; set; }
    }

    class Retailer
    {
        public static int GetCarsVal(List<Car> c)
        {
            int tot = 0;
            foreach (var car in c)
            {
                tot += car.value;
            }
            return tot;
        }
        public static int GetCarsVal(CarList c)
        {
            int tot = 0;
            foreach (var car in c)
            {
                tot += car.value;
            }
            return tot;
        }
    }
}
