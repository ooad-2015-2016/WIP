using Entity;
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

namespace RolePlayingGame
{

    public sealed partial class InventoryMeni : Page
    {
        Collection Stuff = new Collection();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            ResetSelect();
        }

        public InventoryMeni()
        {
            this.InitializeComponent();
        }

        private void ResetSelect()
        {
            ViewStats_Select.Opacity = 0;
            Inventory_Select.Opacity = 0;
            ViewSkills_Select.Opacity = 0;
            BackToGame_Select.Opacity = 0;

            Confirm.Opacity = 0;
            Confirm_Image.Opacity = 0;
            Deny.Opacity = 0;
            Deny_Image.Opacity = 0;
            // if (p == 1) k = 0;
        }

        int k = 0;  //k - parametar koji pamti koje je dugme pritisnuto
        int p = 1;

        private void ViewStats_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            ViewStats_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 1; p = 1;
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            Inventory_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 2; p = 1;
        }

        private void ViewSkills_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            ViewSkills_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 3; p = 1;
        }

        private void BackToGame_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            BackToGame_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 4; p = 1;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            switch (k)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    this.Frame.Navigate(typeof(MapMeni), Stuff);
                    break;
            }
        }

        private void Deny_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
        }
    }
}
