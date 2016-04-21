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
            Confirm.Opacity = 0;
            Confirm_Image.Opacity = 0;
            Deny.Opacity = 0;
            Deny_Image.Opacity = 0;
            Attack_Select.Opacity = 0;
            Ability_Select.Opacity = 0;
            Item_Select.Opacity = 0;
            Run_Select.Opacity = 0;
        }
        private void ResetSelect()
        {
            Attack_Select.Opacity = 0;
            Ability_Select.Opacity = 0;
            Item_Select.Opacity = 0;
            Run_Select.Opacity = 0;
        }
        int k = 0;  //k - parametar koji pamti koja su dugmad pritisnuta i njihov redoslijed
                    //1. cifra - zadnje pritisnuto dugme, 3. cifra prvo pritisnuto dugme
        int p = 0;  //p - parametar koji pamti koliko je puta dugme pritisnuto
                    //p = 1 ili 0, nije ni jednom pritisnuto, 10 jednom pritisnuto, ..., 1000 tri puta pritisnuto
        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            Attack_Select.Opacity = 1;
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 1; p = 10;
                    break;
                default:
                    k = p + k % p;
                    break;
            }
        }

        private void Use_Ability_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            Ability_Select.Opacity = 1;
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 2; p = 10;
                    break;
                default:
                    k = 2 * p + k % p;
                    break;
            }
        }

        private void Use_Item_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            Item_Select.Opacity = 1;
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 3; p = 10;
                    break;
                default:
                    k = 3 * p + k % p;
                    break;
            }
        }

        private void Run_Away_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            Run_Select.Opacity = 1;
            switch (k)
            {
                case 0:
                    Confirm.Opacity = 1;
                    Confirm_Image.Opacity = 1;
                    Deny.Opacity = 1;
                    Deny_Image.Opacity = 1;
                    k = 4; p = 1;
                    break;
                default:
                    k = 4 * p + k % p;
                    break;
            }
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            switch (k % (p * 10))
            {
                case 1:
                    Attack_Text.Text = "Attack1" + k.ToString();
                    Ability_Text.Text = "Attack2";
                    Item_Text.Text = "Attack3";
                    Run_Text.Text = "Attack4";
                    p = 10;
                    break;
                case 2:
                    Attack_Text.Text = "Ability1";
                    Ability_Text.Text = "Ability2";
                    Item_Text.Text = "Ability3";
                    Run_Text.Text = "Ability4";
                    p = 10;
                    break;
                case 4:
                    Attack_Text.Text = "You coward!";
                    Ability_Text.Text = "";
                    Item_Text.Text = "";
                    Run_Text.Text = "";
                    p = 10;
                    break;
                case 11:
                case 21:
                case 31:
                case 41:
                case 12:
                case 22:
                case 32:
                case 42:
                    Attack_Text.Text = "Enemy1";
                    Ability_Text.Text = "Enemy2";
                    Item_Text.Text = "Enemy3";
                    Run_Text.Text = "";
                    p = 100;
                    break;
                default:
                    Player.Text = k.ToString();
                    Attack_Text.Text = "Attack";
                    Ability_Text.Text = "Use Ability";
                    Item_Text.Text = "Use Item";
                    Run_Text.Text = "Run Away";
                    Confirm.Opacity = 0;
                    Confirm_Image.Opacity = 0;
                    Deny.Opacity = 0;
                    Deny_Image.Opacity = 0;
                    k = 0; p = 0;
                    break;
            }
        }

        private void Deny_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            p = p / 10;
            k = k % 10;
            if (p == 1) k = 0;
            switch (k % (p * 10))
            {
                case 1:
                    Attack_Text.Text = "Attack1";
                    Ability_Text.Text = "Attack2";
                    Item_Text.Text = "Attack3";
                    Run_Text.Text = "Attack4";
                    p = 10;
                    break;
                case 2:
                    Attack_Text.Text = "Ability1";
                    Ability_Text.Text = "Ability2";
                    Item_Text.Text = "Ability3";
                    Run_Text.Text = "Ability4";
                    p = 10;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 21:
                case 22:
                case 23:
                case 24:
                    Attack_Text.Text = "Enemy1";
                    Ability_Text.Text = "Enemy2";
                    Item_Text.Text = "Enemy3";
                    Run_Text.Text = "";
                    p = 100;
                    break;
                default:
                    Player.Text = k.ToString();
                    Attack_Text.Text = "Attack";
                    Ability_Text.Text = "Use Ability";
                    Item_Text.Text = "Use Item";
                    Run_Text.Text = "Run Away";
                    Confirm.Opacity = 0;
                    Confirm_Image.Opacity = 0;
                    Deny.Opacity = 0;
                    Deny_Image.Opacity = 0;
                    k = 0; p = 0;
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

        private void textBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
