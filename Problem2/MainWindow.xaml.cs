using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Problem2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            string url = "http://pcbstuou.w27.wh-2.com/webservices/3033/api/Wine/Reviews";
            List<Wines> wine;

            cboCountry.Items.Add("All");

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                wine = JsonConvert.DeserializeObject<List<Wines>>(json);
                
                foreach (var w in wine)
                {
                    lstWines.Items.Add(w);
                    if (cboCountry.Items.Contains(w.country) == false)
                    {
                        cboCountry.Items.Add(w.country);
                    }
                    cboCountry.Items.Add(w.country);
                }

            }
        }


    }
}
