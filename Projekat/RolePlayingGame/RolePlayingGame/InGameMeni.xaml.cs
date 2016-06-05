using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

namespace RolePlayingGame
{
    public sealed partial class InGameMeni : Page
    {
        Collection Stuff = new Collection();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            ResetSelect();
            if (Stuff.GetOption() == 1) ShowStats(1);
            else ShowStats(0);
            Stuff.SetOption(0);
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
            EquipmentInfo.Opacity = i;

            Atributes points = Stuff.FindCharacter(1).GetAtributes();
            if (i == 1)
            {
                InfoBox.Text = "Atributes:\n\nStrength: " + points.GetStrength()
                    + "\nVitality: " + points.GetVitality() + "\nAgility: " + points.GetAgility()
                    + "\nIntelligence: " + points.GetIntelligence() + "\nWillpower: " + points.GetWillpower()
                    + "\nLuck: " + points.GetLuck();
            }
            else InfoBox.Text = "";

            EquipmentSlots items = Stuff.FindCharacter(1).GetEquipment();
            for(int j = 1; j < 4; j++)
            {
                Image itemImage = (Image)this.FindName("Item" + j);
                Rectangle rectangle = (Rectangle)this.FindName("Item" + j + "_Slot");
                if (j == 1) itemImage.Source = items.GetPrimary().GetSprite().Source;
                else if(j == 2) itemImage.Source = items.GetSecondary().GetSprite().Source;
                else itemImage.Source = items.GetArmor().GetSprite().Source;
                itemImage.Opacity = i;
                rectangle.Opacity = i;
            }
        }

        public void ShowSelectedItemInfo()
        {
            ShowStats(1);
            for (int j = 1; j < 4; j++)
            {
                Rectangle rectangle = (Rectangle)this.FindName("Item" + j + "_Slot");
                rectangle.Fill = new SolidColorBrush(Colors.Black);
            }
                string text = InfoBox.Text;
            if (x != 0)
            {
                Rectangle rectangle = (Rectangle)this.FindName("Item" + x + "_Slot");
                rectangle.Fill = new SolidColorBrush(Colors.DarkOrange);
                Equipable it;
                if (x == 1) it = Stuff.FindCharacter(1).GetEquipment().GetPrimary();
                else if (x == 2) it = Stuff.FindCharacter(1).GetEquipment().GetSecondary();
                else it = Stuff.FindCharacter(1).GetEquipment().GetArmor();
                if (it.GetID() != 0)
                {
                    text += "\n\n" + it.GetName()
                    + "\n" + it.GetDescription();
                    int n = it.GetMainType();
                    text += "\nType: ";
                    if (n == 1)
                    {
                        text += "Weapon";
                        int m = it.GetSubType();
                        switch (m)
                        {
                            case 1:
                                text += "\nClass: Sword";
                                break;
                            case 2:
                                text += "\nClass: Axe";
                                break;
                            case 3:
                                text += "\nClass: Dagger";
                                break;
                            default:
                                text += "\nClass: Staff";
                                break;
                        }
                        text += "\nBase damage: " + it.GetPower();

                    }
                    else if (n == 2)
                    {
                        text += "Shield";
                    }
                    else
                    {
                        text += "Armor\nDeflects: " + it.GetPower() + "% Damage";
                    }

                }
                else
                {

                }
            }
            InfoBox.Text = text;
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
        int p = 1;

        int x = 0; // koji je equipment izabran

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
            ResetSelect(); x = 0;
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
            ResetSelect(); x = 0;
        }


        private void Item1_Button_Click(object sender, RoutedEventArgs e)
        {
            x = 1; ShowSelectedItemInfo();
        }


        private void Item2_Button_Click(object sender, RoutedEventArgs e)
        {
            x = 2; ShowSelectedItemInfo();
        }

        private void Item3_Button_Click(object sender, RoutedEventArgs e)
        {
            x = 3; ShowSelectedItemInfo();
        }
    }
}
