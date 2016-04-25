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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using NAVDataAccess;
using Windows.UI.Popups;

namespace NoteAVacation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Signup : Page
    {
        public Signup()
        {
            this.InitializeComponent();
        }

        private async void btnSignUp_Click(object sender, RoutedEventArgs e)
        {

            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")))
            {
                await new MessageDialog("Invalid Email Address").ShowAsync();
                return;
            }
            if (!(txtEmail.Text.ToUpper().Trim() ==  txtReenterEmail.Text.ToUpper().Trim()))
            {
                await new MessageDialog("Email Address don't match").ShowAsync();
                return;
            }

            Profile newProfile = new Profile();
            newProfile.Email = txtEmail.Text.ToLower();
            newProfile.Password = txtPassword.Password;
            newProfile.FirstName = txtFirstName.Text;
            newProfile.LastName = txtLastName.Text;
            string addMessage = await newProfile.AddNewProfile();
            if (String.IsNullOrEmpty(addMessage)) {
                //Frame.Navigate(typeof(MainPage));
            } else
            {
                await new MessageDialog("Email Address already has an account").ShowAsync();
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
