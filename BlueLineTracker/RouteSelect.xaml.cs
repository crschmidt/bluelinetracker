using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Collections;
using System.Globalization;

namespace BlueLineTracker
{

    public partial class Page1 : PhoneApplicationPage
    {
        public Dictionary<string,Route> eastRoutes;
        public Dictionary<string,Route> westRoutes;
        public string direction;
        public Page1()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(RouteSelect_Loaded);

         }
        void RouteSelect_Loaded(object sender, RoutedEventArgs e)
        {
            var routes = new Routes();
            

        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Routes routes = new Routes();
            if (NavigationContext.QueryString.TryGetValue("direction", out direction))
            {
                if (direction == "E")
                {
                    listBoxTarget.ItemsSource = routes.eastRoutes.Values;
                    PageTitle.Text = "Eastbound";
                } else if (direction == "W") {
                    listBoxTarget.ItemsSource = routes.westRoutes.Values;
                    PageTitle.Text = "Westbound";
                } 
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void SwapIcon_Click(object sender, EventArgs e)
        {
            string newdirection = null;
            if (direction == "E")
            {
                newdirection = "W";    
            }
            else if (direction == "W")
            {
                newdirection = "E";    
            }

            if (newdirection != null)
            {
                NavigationService.Navigate(new Uri("/RouteSelect.xaml?direction=" + newdirection, UriKind.Relative));
            }
        }

    }
    
    public class Route
    {
        public String key { get; set; }
        public String title { get; set; }
        public String direction { get; set; }
        public String url { get; set; }
    }
    public class Routes
    {
        public Dictionary<string, Route> eastRoutes;
        public Dictionary<string, Route> westRoutes;
        public Routes()
        {
            eastRoutes = new Dictionary<string, Route>();
            westRoutes = new Dictionary<string, Route>();
            eastRoutes.Add("BWONE", new Route { key = "BWONE", url = "/Stop.xaml?key=BWONE", direction = "E", title = "Wonderland Station"});
            eastRoutes.Add("BREVE", new Route { key = "BREVE", url = "/Stop.xaml?key=BREVE", direction = "E", title = "Revere Beach Station"});
            westRoutes.Add("BREVW", new Route { key = "BREVW", url = "/Stop.xaml?key=BREVW", direction = "W", title = "Revere Beach Station"});
            eastRoutes.Add("BBEAE", new Route { key = "BBEAE", url = "/Stop.xaml?key=BBEAE", direction = "E", title = "Beachmont Station"});
            westRoutes.Add("BBEAW", new Route { key = "BBEAW", url = "/Stop.xaml?key=BBEAW", direction = "W", title = "Beachmont Station"});
            eastRoutes.Add("BSUFE", new Route { key = "BSUFE", url = "/Stop.xaml?key=BSUFE", direction = "E", title = "Suffolk Downs Station"});
            westRoutes.Add("BSUFW", new Route { key = "BSUFW", url = "/Stop.xaml?key=BSUFW", direction = "W", title = "Suffolk Downs Station"});
            eastRoutes.Add("BORHE", new Route { key = "BORHE", url = "/Stop.xaml?key=BORHE", direction = "E", title = "Orient Heights Station"});
            westRoutes.Add("BORHW", new Route { key = "BORHW", url = "/Stop.xaml?key=BORHW", direction = "W", title = "Orient Heights Station"});
            eastRoutes.Add("BWOOE", new Route { key = "BWOOE", url = "/Stop.xaml?key=BWOOE", direction = "E", title = "Wood Island Station"});
            westRoutes.Add("BWOOW", new Route { key = "BWOOW", url = "/Stop.xaml?key=BWOOW", direction = "W", title = "Wood Island Station"});
            eastRoutes.Add("BAIRE", new Route { key = "BAIRE", url = "/Stop.xaml?key=BAIRE", direction = "E", title = "Airport Station"});
            westRoutes.Add("BAIRW", new Route { key = "BAIRW", url = "/Stop.xaml?key=BAIRW", direction = "W", title = "Airport Station"});
            eastRoutes.Add("BMAVE", new Route { key = "BMAVE", url = "/Stop.xaml?key=BMAVE", direction = "E", title = "Maverick Station"});
            westRoutes.Add("BMAVW", new Route { key = "BMAVW", url = "/Stop.xaml?key=BMAVW", direction = "W", title = "Maverick Station"});
            eastRoutes.Add("BAQUE", new Route { key = "BAQUE", url = "/Stop.xaml?key=BAQUE", direction = "E", title = "Aquarium Station"});
            westRoutes.Add("BAQUW", new Route { key = "BAQUW", url = "/Stop.xaml?key=BAQUW", direction = "W", title = "Aquarium Station"});
            eastRoutes.Add("BSTAE", new Route { key = "BSTAE", url = "/Stop.xaml?key=BSTAE", direction = "E", title = "State St. Station"});
            westRoutes.Add("BSTAW", new Route { key = "BSTAW", url = "/Stop.xaml?key=BSTAW", direction = "W", title = "State St. Station"});
            eastRoutes.Add("BGOVE", new Route { key = "BGOVE", url = "/Stop.xaml?key=BGOVE", direction = "E", title = "Government Center Station"});
            westRoutes.Add("BGOVW", new Route { key = "BGOVW", url = "/Stop.xaml?key=BGOVW", direction = "W", title = "Government Center Station"});
            eastRoutes.Add("BBOWE", new Route { key = "BBOWE", url = "/Stop.xaml?key=BBOWE", direction = "E", title = "Bowdoin Station"});
            westRoutes.Add("BBOWW", new Route { key = "BBOWW", url = "/Stop.xaml?key=BBOWW", direction = "W", title = "Bowdoin Station"});
        }
    }
}
