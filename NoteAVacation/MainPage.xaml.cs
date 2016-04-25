﻿using System;
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

namespace NoteAVacation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitVeiw.IsPaneOpen = !MySplitVeiw.IsPaneOpen;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ListBoxItem itm = IconsListBox.SelectedItem as ListBoxItem;
            
            switch (itm.Name)
            {
                case  "IconHome":
                    ScenarioFrame.Navigate(typeof(MainPageTrips));
                    break;
                case "IconSettings":
                    ScenarioFrame.Navigate(typeof(MainPageHistory));
                    break;
            }
        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
