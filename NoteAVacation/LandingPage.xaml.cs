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
using Windows.Devices.Geolocation;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls.Maps;
using NAVDataAccess;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NoteAVacation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LandingPage : Page
    {
        public LandingPage()
        {
            this.InitializeComponent();
            this.Loaded += Frame_Loaded;
           
        }

        private  void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            //Map.MapServiceToken = "OzdCEEwHEFD53KK9TqZYQQ";
            //await Map.TrySetViewAsync(new Geopoint(new BasicGeoposition { Latitude = 41.88259, Longitude = -87.63741 }),
            //  16, 0, 0, MapAnimationKind.Bow);
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {

            var accessStatus = await Geolocator.RequestAccessAsync();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Signup));
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                if (await NAVDataAccess.Profile.LoginRequest(txtEmail.Text, txtPassword.Password))
                {
                    Frame.Navigate(typeof(MainPage));
                return;
                    //Navigate
                }
            } catch (Exception ex) { }

            await new MessageDialog("inValid login credentials").ShowAsync();

        }
        
    }
}
