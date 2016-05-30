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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RolePlayingGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InGameMeni : Page
    {
        Collection Stuff = new Collection();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            ResetSelect();
            ShowStats(0);
        }
        public InGameMeni()
        {
            this.InitializeComponent();
        }

        public void ShowStats(int i)
        {
            //i = 0 hides stats, i = 1 shows stats
            if (i != 0)
            {
                i = 1;
                SetProgressBars();
            }
            else
            {
                Health.Text = "";
                Mana.Text = "";
                LVL.Text = "";
                XP.Text = "";
            }
            Player.Opacity = i;
            PlayerHealthBar.Opacity = i;
            PlayerImage.Opacity = i;
            PlayerImageBox.Opacity = i;
            PlayerManaBar.Opacity = i;
            PlayerXPBar.Opacity = i;

        }
        public void SetProgressBars()
        {
            Player.Text = (Stuff.FindCharacter(1)).GetName();
            double PlayerHealth = Stuff.FindCharacter(1).GetHealth();
            double PlayerMaxHealth = Stuff.FindCharacter(1).GetMaxHealth();
            PlayerHealthBar.Value = PlayerHealth / PlayerMaxHealth * 100;
            double PlayerMana = Stuff.FindCharacter(1).GetMana();
            double PlayerMaxMana = Stuff.FindCharacter(1).GetMaxMana();
            PlayerManaBar.Value = PlayerMana / PlayerMaxMana * 100;
            double PlayerXP = Stuff.FindCharacter(1).GetEXP();
            double PlayerMaxXP = Stuff.FindCharacter(1).GetMaxEXP();
            PlayerXPBar.Value = PlayerXP / PlayerMaxXP * 100;
            Health.Text = "Health:" + "\t" + PlayerHealth + "/" + PlayerMaxHealth;
            Mana.Text = "Mana:" + "  \t" + PlayerMana + "/" + PlayerMaxMana;
            LVL.Text = "LVL: " + Stuff.FindCharacter(1).GetLVL();
            XP.Text = "XP: " + PlayerXP + "/" + PlayerMaxXP;
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

        int k = 0;  //k - parametar koji pamti koja su dugmad pritisnuta i njihov redoslijed
                    //1. cifra - zadnje pritisnuto dugme, 3. cifra prvo pritisnuto dugme
        int p = 1;  //p - parametar koji pamti koliko je puta dugme pritisnuto
                    //p = 1 ili 0, nije ni jednom pritisnuto, 10 jednom pritisnuto, ..., 1000 tri puta pritisnuto

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
            switch(k)
            {
                case 1:
                    ShowStats(1);
                    break;
                case 2:
                    this.Frame.Navigate(typeof(InventoryMeni), Stuff);
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
