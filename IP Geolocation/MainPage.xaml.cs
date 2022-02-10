using IP_Geolocation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IP_Geolocation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private RootObject rootObject;

        public MainPage()
        {
            this.InitializeComponent();
            //rootObject = new RootObject();
        }
        
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            rootObject = await GeolocationProxy.GetGeolocation();
            if (rootObject.status.Equals("success"))
            {
                AsNumber.Text = rootObject.@as;
                city.Text = rootObject.city;
                country.Text = rootObject.country;
                countryCode.Text = rootObject.countryCode;
                isp.Text = rootObject.isp;
                lat.Text = rootObject.lat.ToString();
                lon.Text = rootObject.lon.ToString();
                org.Text = rootObject.org;
                query.Text = rootObject.query;
                region.Text = rootObject.region;
                regionName.Text = rootObject.regionName;
                timezone.Text = rootObject.timezone;
                zip.Text = rootObject.zip;
            }
            else
            {

            }

        }
    }
}
