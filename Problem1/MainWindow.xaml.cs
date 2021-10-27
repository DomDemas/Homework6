using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace Problem1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char[] CharactersToTrim = {'$'};
        List<Car> cars = new List<Car>();
        public MainWindow()
        {
            InitializeComponent();

            cboYear.Items.Add("<=");
            cboYear.Items.Add("=");
            cboYear.Items.Add(">=");

            string[] lines = File.ReadAllLines("car_sales.csv");
            cboColor.Items.Add("All");
            for (int i = 1; i < lines.Length; i++)
            {

                string[] pieces = lines[i].Split(',');
               
                Car c = new Car(pieces[0], pieces[1], pieces[2], Convert.ToInt32(pieces[3]), pieces[4], Convert.ToDouble(pieces[5].Trim('$')));
                if (cboColor.Items.Contains(c.Color) == false)
                {
                    cboColor.Items.Add(c.Color);
                }
                cars.Add(c);
                
            }


        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            foreach (Car car in cars)
            {
                if (cboYear.SelectedItem.ToString() == ">=")
                {
                    if (car.Year >= Convert.ToInt32(txtYear.Text))
                    {
                        if (cboColor.SelectedItem.ToString() == car.Color)
                        {
                            lstResults.Items.Add(car);
                        }
                    }
                }

                if (cboYear.SelectedItem.ToString() == "=")
                {
                    if (car.Year == Convert.ToInt32(txtYear.Text))
                    {
                        if (cboColor.SelectedItem.ToString() == car.Color)
                        {
                            lstResults.Items.Add(car);
                        }
                    }
                }

                if (cboYear.SelectedItem.ToString() == "<=")
                {
                    if (car.Year <= Convert.ToInt32(txtYear.Text))
                    {
                        if (cboColor.SelectedItem.ToString() == car.Color)
                        {
                            lstResults.Items.Add(car);
                        }
                    }
                }

            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstResults.Items, Formatting.Indented);

            File.WriteAllText($"Car_Sales.json", json);

            MessageBox.Show("Saved contents of listbox successfully!");
        }
    }
}
