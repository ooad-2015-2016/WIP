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

namespace RolePlayingGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {

        public BlankPage1()
        {
            this.InitializeComponent();
        }

        int k = 0;
        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 1;
                    break;
                default:
                    k = 10 * k + 1;
                    break;
            }
        }

        private void Use_Ability_Click(object sender, RoutedEventArgs e)
        {
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 2;
                    break;
                default:
                    k = 10 * k + 2;
                    break;
            }
        }

        private void Use_Item_Click(object sender, RoutedEventArgs e)
        {
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 3;
                    break;
                default:
                    k = 10 * k + 3;
                    break;
            }
        }

        private void Run_Away_Click(object sender, RoutedEventArgs e)
        {
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 4;
                    break;
                default:
                    k = 10 * k + 4;
                    break;
            }
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            switch (k)
            {
                case 1:
                    Attack.Content = "Attack1";
                    Use_Ability.Content = "Attack2";
                    Use_Item.Content = "Attack3";
                    Run_Away.Content = "Attack4";
                    break;
                case 2:
                    Attack.Content = "Ability1";
                    Use_Ability.Content = "Ability2";
                    Use_Item.Content = "Ability3";
                    Run_Away.Content = "Ability4";
                    break;
                case 4:
                    Attack.Content = "You coward!";
                    Use_Ability.Content = "";
                    Use_Item.Content = "";
                    Run_Away.Content = "";
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 21:
                case 22:
                case 23:
                case 24:
                    Attack.Content = "Enemy1";
                    Use_Ability.Content = "Enemy2";
                    Use_Item.Content = "Enemy3";
                    Run_Away.Content = "";
                    break;
                default:
                    Player.Text = k.ToString();
                    Attack.Content = "Attack";
                    Use_Ability.Content = "Use Ability";
                    Use_Item.Content = "Use Item";
                    Run_Away.Content = "Run Away";
                    Confirm.Opacity = 0;
                    Confirm_Image.Opacity = 0;
                    Deny.Opacity = 0;
                    Deny_Image.Opacity = 0;
                    k = 0;
                    break;
            }
        }

        private void Deny_Click(object sender, RoutedEventArgs e)
        {
            k = k / 10;
            switch (k)
            {
                case 1:
                    Attack.Content = "Attack1";
                    Use_Ability.Content = "Attack2";
                    Use_Item.Content = "Attack3";
                    Run_Away.Content = "Attack4";
                    break;
                case 2:
                    Attack.Content = "Ability1";
                    Use_Ability.Content = "Ability2";
                    Use_Item.Content = "Ability3";
                    Run_Away.Content = "Ability4";
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 21:
                case 22:
                case 23:
                case 24:
                    Attack.Content = "Enemy1";
                    Use_Ability.Content = "Enemy2";
                    Use_Item.Content = "Enemy3";
                    Run_Away.Content = "";
                    break;
                default:
                    Player.Text = k.ToString();
                    Attack.Content = "Attack";
                    Use_Ability.Content = "Use Ability";
                    Use_Item.Content = "Use Item";
                    Run_Away.Content = "Run Away";
                    Confirm.Opacity = 0;
                    Confirm_Image.Opacity = 0;
                    Deny.Opacity = 0;
                    Deny_Image.Opacity = 0;
                    k = 0;
                    break;
            }
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock2_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Enemy1Health_Copy_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

    }
}
