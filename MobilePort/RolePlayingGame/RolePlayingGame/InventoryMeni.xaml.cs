﻿using Entity;
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

    public sealed partial class InventoryMeni : Page
    {
        Collection Stuff = new Collection();
        Inventory usedInventory = new Inventory();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            if(Stuff.GetOption() == 11)
            {
                usedInventory = Stuff.FindCharacter(1).GetInventory();
                ShowInventory();
            }
            else if (Stuff.GetOption() == 1)
            {
                usedInventory = Stuff.FindShop(1).GetInventory();
                Stuff.SetOption(2); ShowShop(); k = 1;
                ItemInfoBox.Text = "Your Gold: " + Stuff.FindCharacter(1).GetGold() + "\n  ";
            }
            else
            {
                usedInventory = Stuff.FindCharacter(1).GetInventory();
                ShowInventory();
                Stuff.SetOption(0);
            }
            ResetSelect();
            UnloadInventory();
            LoadInventory();
            SetBars();
        }

        public InventoryMeni()
        {
            this.InitializeComponent();
        }

        public void SetBars()
        {
            double PlayerHealth = Stuff.FindCharacter(1).GetHealth();
            double PlayerMaxHealth = Stuff.FindCharacter(1).GetMaxHealth();
            PlayerHealthBar.Value = PlayerHealth / PlayerMaxHealth * 100;
            double PlayerMana = Stuff.FindCharacter(1).GetMana();
            double PlayerMaxMana = Stuff.FindCharacter(1).GetMaxMana();
            PlayerManaBar.Value = PlayerMana / PlayerMaxMana * 100;
            double PlayerXP = Stuff.FindCharacter(1).GetEXP();
            double PlayerMaxXP = Stuff.FindCharacter(1).GetMaxEXP();
            PlayerXPBar.Value = PlayerXP / PlayerMaxXP * 100;
            Health.Text = "Health: " + PlayerHealth + "/" + PlayerMaxHealth;
            Mana.Text = "Mana: " + PlayerMana + "/" + PlayerMaxMana;
            LVL.Text = "LVL: " + Stuff.FindCharacter(1).GetLVL();
            XP.Text = "XP: " + PlayerXP + "/" + PlayerMaxXP;
        }

        public void ShowShop()
        {
            Player.Text = Stuff.FindShop(1).GetName();
            InfoBox.Text = "\n " + Stuff.FindShop(1).GetDescription();

            ViewStats_Text.Text = "";
            Inventory_Text.Text = "";
            ViewSkills_Text.Text = "";
            BackToGame_Text.Text = "Leave Shop";

            SetBars();
        }

        public void ShowInventory()
        {
            Player.Text = "Inventory: ";

            ViewStats_Text.Text = "View Stats";
            Inventory_Text.Text = "Open Inventory";
            ViewSkills_Text.Text = "View Skills";
            BackToGame_Text.Text = "Back to Game";

            SetBars();
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

        private void ShowConfirmationBoxes()
        {
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
        }

        public void ResetItemInfo()
        {
            if(Stuff.GetOption() == 2)
            {
                ItemInfoBox.Text = "Your Gold: " + Stuff.FindCharacter(1).GetGold() + "\n  ";
            }
            else ItemInfoBox.Text = "";
        }

        private void ResetItemSelect()
        {
            pos = 0;
            for (int i = 1; i <= 25; i++)
            {
                Rectangle itemslot = (Rectangle)this.FindName("Item" + i + "_Slot");
                itemslot.Fill = new SolidColorBrush(Colors.Black);
            }
            ShowConfirmationBoxes(); ResetItemInfo();
        }

        public void UnloadInventory()
        {
            for(int i = 1; i <= 9; i++)
            {
                Image itemImage = (Image)this.FindName("Item" + i);
                TextBlock itemText = (TextBlock)this.FindName("Item" + i + "_Quantity");
                itemImage.Source = null;
                itemText.Text = "";
            }
        }

        public void LoadInventory()
        {
            List<InventorySlot> slots = usedInventory.GetItemSlots();
            int n = slots.Count; if (n > 9) n = 9;
            for (int i = 1; i <= n; i++)
            {
                Image itemImage = (Image)this.FindName("Item" + i);
                TextBlock itemText = (TextBlock)this.FindName("Item" + i + "_Quantity");
                itemImage.Source = slots[i - 1].GetItem().GetSprite().Source;
                if(slots[i -1].GetQuantity() > 1) itemText.Text = "X" + slots[i - 1].GetQuantity();
            }
        }

        public bool BuyItem()
        {
            bool DidBuy = false;
            if (pos >= -1 && pos < usedInventory.GetItemSlots().Count)
            {
                Item item = new Item();
                item = usedInventory.GetItemSlots()[pos].GetItem();
                if (Stuff.FindCharacter(1).GetGold() >= item.GetPrice())
                {
                    Stuff.FindCharacter(1).GetInventory().AddItem(item);
                    Stuff.FindCharacter(1).IncreaseGold(-item.GetPrice());
                    DidBuy = true;
                }
            }
            return DidBuy;
        }

        public void ItemSelect()
        {
            ViewSkills_Text.Text = "";
            BackToGame_Text.Text = "";
            if (pos >= usedInventory.GetItemSlots().Count)
            {
                ViewStats_Text.Text = "";
                Inventory_Text.Text = "";
            }
            else if (Stuff.GetOption() == 0)
            { 
             if (usedInventory.GetItemSlots()[pos].GetItem() is Consumable)
                {
                    ViewStats_Text.Text = "Use Item";
                    Inventory_Text.Text = "Drop";
                }
                else
                {
                    ViewStats_Text.Text = "Equip Item";
                    Inventory_Text.Text = "Drop";
                }
            }
            else
            {
                ViewStats_Text.Text = "Buy Item";
                Inventory_Text.Text = "";
            }
            ShowSelectedItemInfo();
        }

        public void ShowSelectedItemInfo()
        {
            string text = ItemInfoBox.Text;
            if (pos < usedInventory.GetItemSlots().Count)
            {
                Item selected = usedInventory.GetItemSlots()[pos].GetItem();
                if (selected.GetID() != 0)
                {
                    if (selected is Equipable) text += "Equipable";
                    else text += "Consumable";
                    text += " item\nName: " + selected.GetName()
                        + "\nDescription: " + selected.GetDescription();
                    if (selected is Equipable)
                    {
                        Equipable it = (Equipable)selected;
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
                        Consumable it = (Consumable)selected;
                        if (it.GetHealthChange() > 0) text += "\nHeals " + it.GetHealthChange() + " health.";
                        if (it.GetManaChange() > 0) text += "\nRestores " + it.GetManaChange() + " mana.";
                    }
                }
                text += "\nPrice: " + selected.GetPrice() + " Gold";
            }
            else
            {
                text = "Unavailable item selected!";
            }
            ItemInfoBox.Text = text;
        }

        int k = 0;  //k - parametar koji pamti koje je dugme pritisnuto
        int pos = -1; //pamti koji je item odabran (poziciju u inventoriju ekranu)

        private void ViewStats_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            ViewStats_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 1;
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            Inventory_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 2;
        }

        private void ViewSkills_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            ViewSkills_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 3;
        }

        private void BackToGame_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            BackToGame_Select.Opacity = 1;
            Confirm.Opacity = 1;
            Confirm_Image.Opacity = 1;
            Deny.Opacity = 1;
            Deny_Image.Opacity = 1;
            k = 4;
        } 

        private void Item1_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 0; ItemSelect();
            Item1_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);

        }

        private void Item2_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 1; ItemSelect();
            Item2_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item3_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 2; ItemSelect();
            Item3_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item4_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 3; ItemSelect();
            Item4_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item5_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 4; ItemSelect();
            Item5_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item6_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 4; ItemSelect();
            Item6_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item7_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 5; ItemSelect();
            Item7_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item8_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 6; ItemSelect();
            Item8_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item9_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 6; ItemSelect();
            Item9_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item10_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 9; ItemSelect();
            Item10_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item11_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 7; ItemSelect();
            Item11_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item12_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 8; ItemSelect();
            Item12_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item13_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 9; ItemSelect();
            Item13_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item14_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 9; ItemSelect();
            Item14_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item15_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 14; ItemSelect();
            Item15_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item16_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 15; ItemSelect();
            Item16_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item17_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 16; ItemSelect();
            Item17_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item18_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 17; ItemSelect();
            Item18_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item19_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 18; ItemSelect();
            Item19_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item20_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 19; ItemSelect();
            Item20_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item21_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 20; ItemSelect();
            Item21_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item22_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 21; ItemSelect();
            Item22_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item23_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 22; ItemSelect();
            Item23_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item24_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 23; ItemSelect();
            Item24_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Item25_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = 24; ItemSelect();
            Item25_Slot.Fill = new SolidColorBrush(Colors.DarkOrange);
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemInfo();
            switch (k)
            {
                case 1:
                    if (pos != -1 && usedInventory.GetItemSlots().Count > pos)
                    {
                        Item item = usedInventory.GetItemSlots()[pos].GetItem();
                        if (Stuff.GetOption() == 2)
                        {

                            bool didBuy = BuyItem();
                            if (didBuy)
                            {
                                ItemInfoBox.Text += "You have bought " + item.GetName() + " for "
                                    + item.GetPrice() + " Gold.";
                            }
                            else
                            {
                                ItemInfoBox.Text += "You do not have enough gold.";
                            }
                        }
                        else
                        {
                            Character player = Stuff.FindCharacter(1);
                            if (item is Equipable)
                            {
                                player.Equip(item);
                                ItemInfoBox.Text += "You have equiped " + item.GetName() + " as your ";
                                if(((Equipable)item).GetMainType() == 1)
                                {
                                    ItemInfoBox.Text += "primary weapon.";
                                }
                                else if (((Equipable)item).GetMainType() == 2)
                                {
                                    ItemInfoBox.Text += "secondary weapon.";
                                }
                                else
                                {
                                    ItemInfoBox.Text += "armor set.";
                                }
                            }
                            else
                            {
                                ItemInfoBox.Text += "You have used " + item.GetName() + " and restored ";
                                if(((Consumable)item).GetHealthChange() != 0)
                                {
                                    int x = player.GetMaxHealth() - player.GetHealth();
                                    if (((Consumable)item).GetHealthChange() > x)
                                    {
                                        ItemInfoBox.Text += x;
                                    }
                                    else
                                    {
                                        ItemInfoBox.Text += ((Consumable)item).GetHealthChange();
                                    }
                                    ItemInfoBox.Text += "Health";
                                    if (((Consumable)item).GetManaChange() != 0) ItemInfoBox.Text += " and";
                                    else ItemInfoBox.Text += ".";
                                }
                                else
                                {
                                    int x = player.GetMaxMana() - player.GetMana();
                                    if (((Consumable)item).GetManaChange() > x)
                                    {
                                        ItemInfoBox.Text += x;
                                    }
                                    else
                                    {
                                        ItemInfoBox.Text += ((Consumable)item).GetManaChange();
                                    }
                                    ItemInfoBox.Text += "Mana.";
                                }
                                Stuff.FindCharacter(1).IncreaseHealth(((Consumable)item).GetHealthChange());
                                Stuff.FindCharacter(1).IncreaseMana(((Consumable)item).GetManaChange());
                                InventorySlot slot = usedInventory.GetItemSlots()[pos];
                                int quantity = slot.GetQuantity();
                                quantity--;
                                if(quantity == 0)
                                {
                                    player.GetInventory().RemoveItemSlot(slot);
                                    usedInventory = Stuff.FindCharacter(1).GetInventory();
                                }
                                else
                                {
                                    slot.SetQuantity(quantity);
                                    player.SetInventory(usedInventory);
                                    usedInventory = player.GetInventory();
                                }
                            }
                        }
                        LoadInventory();
                        ShowConfirmationBoxes();
                    }
                    else
                    {
                        if(Stuff.GetOption() != 11) Stuff.SetOption(1);
                        this.Frame.Navigate(typeof(InGameMeni), Stuff);
                    }
                    ShowConfirmationBoxes();
                    break;
                case 2:
                    if (Stuff.GetOption() == 0)
                    {
                        if(pos != -1 && pos < usedInventory.GetItemSlots().Count)
                        {
                            Character player = Stuff.FindCharacter(1);
                            InventorySlot slot = usedInventory.GetItemSlots()[pos];
                            ItemInfoBox.Text += "You have dropped the " + slot.GetItem().GetName() + ".";
                            player.GetInventory().RemoveItemSlot(slot);
                            LoadInventory();
                            ShowConfirmationBoxes();
                        }
                        else
                        {
                            ItemInfoBox.Text += "You have not selected an item.";
                        }
                    }
                    break;
                case 3:
                    break;
                default:
                    if(Stuff.GetOption() == 11)
                        this.Frame.Navigate(typeof(BlankPage1), Stuff);
                    else if(pos == -1)
                        this.Frame.Navigate(typeof(MapMeni), Stuff);
                    break;
            }
        }

        private void Deny_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect(); ResetItemSelect(); pos = -1;
            if (Stuff.GetOption() == 2) ShowShop();
            else ShowInventory();
        }
    }
}
