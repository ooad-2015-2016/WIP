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
    public sealed partial class BlankPage1 : Page
    {
        Collection Stuff = new Collection();
        public void DisplayEnemy1(double n)
        {
            // n == 0 clears enemies interface, n == 1 shows it
            Enemy1.Opacity = n;
            Enemy1Health.Opacity = n;
            Enemy1HealthBar.Opacity = n;
            Enemy1Image.Opacity = n;
            Enemy1InfoBox.Opacity = n;
            Enemy1Mana.Opacity = n;
            Enemy1ManaBar.Opacity = n;
        }
        public void DisplayEnemy2(double n)
        {
            // n == 0 clears enemies interface, n == 1 shows it
            Enemy2.Opacity = n;
            Enemy2Health.Opacity = n;
            Enemy2HealthBar.Opacity = n;
            Enemy2Image.Opacity = n;
            Enemy2InfoBox.Opacity = n;
            Enemy2Mana.Opacity = n;
            Enemy2ManaBar.Opacity = n;
        }
        public void DisplayEnemy3(double n)
        {
            // n == 0 clears enemies interface, n == 1 shows it
            Enemy3.Opacity = n;
            Enemy3Health.Opacity = n;
            Enemy3HealthBar.Opacity = n;
            Enemy3Image.Opacity = n;
            Enemy3InfoBox.Opacity = n;
            Enemy3Mana.Opacity = n;
            Enemy3ManaBar.Opacity = n;
        }

        public void SetProgressBars()
        {
            Player.Text = (Stuff.FindCharacter(1)).GetName();
            List<Monster> monsterparty = new List<Monster>((Stuff.GetBattle()).GetMonsterParty());
            double PlayerHealth = Stuff.FindCharacter(1).GetHealth();
            double PlayerMaxHealth = Stuff.FindCharacter(1).GetMaxHealth();
            PlayerHealthBar.Value = PlayerHealth / PlayerMaxHealth * 100;
            double PlayerMana = Stuff.FindCharacter(1).GetMana();
            double PlayerMaxMana = Stuff.FindCharacter(1).GetMaxMana();
            PlayerManaBar.Value = PlayerMana / PlayerMaxMana * 100;
            Health.Text = "Health:" + "\t" + PlayerHealth + "/" + PlayerMaxHealth;
            Mana.Text = "Mana:" + "  \t" + PlayerMana + "/" + " " + PlayerMaxMana;

            int numberOfEnemies = monsterparty.Count();

            if(numberOfEnemies > 0)
            {
                if (monsterparty[0].GetID() != 0)
                {
                    Enemy1.Text = monsterparty[0].GetName();
                    Enemy1Image.Source = monsterparty[0].GetSprite().Source;
                    double Enemy1HP = Stuff.GetBattle().GetMonsterParty()[0].GetHealth();
                    double Enemy1MaxHP = Stuff.GetBattle().GetMonsterParty()[0].GetMaxHealth();
                    Enemy1HealthBar.Value = Enemy1HP / Enemy1MaxHP * 100;
                    double Enemy1MP = Stuff.GetBattle().GetMonsterParty()[0].GetMana();
                    double Enemy1MaxMP = Stuff.GetBattle().GetMonsterParty()[0].GetMaxMana();
                    Enemy1ManaBar.Value = Enemy1MP / Enemy1MaxMP * 100;
                    Enemy1Health.Text = "Health:" + "\t" + Enemy1HP + "/" + Enemy1MaxHP;
                    Enemy1Mana.Text = "Mana:" + "  \t" + Enemy1MP + "/" + Enemy1MaxMP;
                }
                else DisplayEnemy1(0);
            }
            
            if (numberOfEnemies > 1)
            {
                if (monsterparty[1].GetID() != 0)
                {
                    Enemy2.Text = monsterparty[1].GetName();
                    Enemy2Image.Source = monsterparty[1].GetSprite().Source;
                    double Enemy2HP = Stuff.GetBattle().GetMonsterParty()[1].GetHealth();
                    double Enemy2MaxHP = Stuff.GetBattle().GetMonsterParty()[1].GetMaxHealth();
                    Enemy2HealthBar.Value = Enemy2HP / Enemy2MaxHP * 100;
                    double Enemy2MP = Stuff.GetBattle().GetMonsterParty()[1].GetMana();
                    double Enemy2MaxMP = Stuff.GetBattle().GetMonsterParty()[1].GetMaxMana();
                    Enemy2ManaBar.Value = Enemy2MP / Enemy2MaxMP * 100;
                    Enemy2Health.Text = "Health:" + "\t" + Enemy2HP + "/" + Enemy2MaxHP;
                    Enemy2Mana.Text = "Mana:" + "  \t" + Enemy2MP + "/" + Enemy2MaxMP;
                }
                else DisplayEnemy2(0);
            }
            
            if (numberOfEnemies > 2)
            {
                if (monsterparty[2].GetID() != 0)
                {
                    Enemy3.Text = monsterparty[2].GetName();
                    Enemy3Image.Source = monsterparty[2].GetSprite().Source;
                    double Enemy3HP = Stuff.GetBattle().GetMonsterParty()[2].GetHealth();
                    double Enemy3MaxHP = Stuff.GetBattle().GetMonsterParty()[2].GetMaxHealth();
                    Enemy3HealthBar.Value = Enemy3HP / Enemy3MaxHP * 100;
                    double Enemy3MP = Stuff.GetBattle().GetMonsterParty()[2].GetMana();
                    double Enemy3MaxMP = Stuff.GetBattle().GetMonsterParty()[2].GetMaxMana();
                    Enemy3ManaBar.Value = Enemy3MP / Enemy3MaxMP * 100;
                    Enemy3Health.Text = "Health:" + "\t" + Enemy3HP + "/" + Enemy3MaxHP;
                    Enemy3Mana.Text = "Mana:" + "  \t" + Enemy3MP + "/" + Enemy3MaxMP;
                }
                else DisplayEnemy3(0);
            }

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            {
                //Adding a battle
                Battle Fight = new Battle();
                Random rand = Stuff.GetRandom();
                int x = Stuff.GetOption();
                Fight.AddPlayer(Stuff.FindCharacter(1));
                switch (x)
                {
                    case 0:
                        Fight.AddMonster(Stuff.FindMonster(1));
                        Fight.AddMonster(Stuff.FindMonster(1));
                        Fight.AddMonster(Stuff.FindMonster(1));
                        break;
                    case 1:
                        for(int i = 0; i < 3; i++)
                        {
                            int par = rand.Next(1, 10);
                            if(par > 10*i)
                            {
                                int monsta = rand.Next(1, 5);
                                int LVL = rand.Next(1, 3);
                                Fight.AddMonster(Stuff.FindMonster(1));
                                Fight.GetMonsterParty()[i].LevelUpTo(LVL);
                            }
                            else Fight.AddMonster(new Monster());
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 3; i++)
                        {
                            int par = rand.Next(1, 100);
                            if (par > 100 * i)
                            {
                                int monsta = rand.Next(1, 5);
                                int LVL = rand.Next(1, 3);
                                if (monsta > 2) Fight.AddMonster(Stuff.FindMonster(1));
                                else Fight.AddMonster(Stuff.FindMonster(2));
                                Fight.GetMonsterParty()[i].LevelUpTo(2 + LVL);
                            }
                            else Fight.AddMonster(new Monster());
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 3; i++)
                        {
                            int par = rand.Next(1, 100);
                            if (par > 100 * i)
                            {
                                int monsta = rand.Next(1, 5);
                                int LVL = rand.Next(1, 4);
                                if (monsta > 2) Fight.AddMonster(Stuff.FindMonster(1));
                                else Fight.AddMonster(Stuff.FindMonster(3));
                                Fight.GetMonsterParty()[i].LevelUpTo(4 + LVL);
                            }
                            else Fight.AddMonster(new Monster());
                        }
                        break;
                    case 4:
                        for (int i = 0; i < 3; i++)
                        {
                            int par = rand.Next(1, 10);
                            if (par > 10 * i)
                            {
                                int monsta = rand.Next(1, 5);
                                if (i == 0) monsta = rand.Next(1, 100);
                                int LVL = rand.Next(1, 5);
                                if (monsta > 10) Fight.AddMonster(Stuff.FindMonster(2));
                                else Fight.AddMonster(Stuff.FindMonster(4));
                                Fight.GetMonsterParty()[i].LevelUpTo(5 + LVL);
                            }
                            else Fight.AddMonster(new Monster());
                        }
                        break;
                    case 5:
                        for (int i = 0; i < 3; i++)
                        {
                            int par = rand.Next(0, 10);
                            if (par > 10 * i)
                            {
                                int monsta = rand.Next(1, 13);
                                if (i == 0) monsta = rand.Next(1, 100);
                                int LVL = rand.Next(1, 6);
                                if (monsta < 10) Fight.AddMonster(Stuff.FindMonster(3));
                                else Fight.AddMonster(Stuff.FindMonster(5));
                                Fight.GetMonsterParty()[i].LevelUpTo(9 + LVL);
                            }
                            else Fight.AddMonster(new Monster());
                        }
                        break;
                    case 6:
                        for (int i = 0; i < 3; i++)
                        {
                            int par = rand.Next(0, 10);
                            if (par > 10 * i)
                            {
                                int monsta = rand.Next(1, 6);
                                if (i == 0) monsta = rand.Next(1, 100);
                                int LVL = rand.Next(0, 10);
                                if (monsta < 6) Fight.AddMonster(Stuff.FindMonster(monsta));
                                else Fight.AddMonster(Stuff.FindMonster(6));
                                Fight.GetMonsterParty()[i].LevelUpTo(15 + LVL);
                            }
                            else Fight.AddMonster(new Monster());
                        }
                        break;
                    case 7:
                        Fight.AddMonster(new Monster());
                        Fight.AddMonster(Stuff.FindMonster(7));
                        Fight.GetMonsterParty()[0].LevelUpTo(25);
                        Fight.AddMonster(new Monster());
                        break;
                    default:
                        break;
                }
                if(Stuff.GetOption() != 11) Stuff.SetBattle(Fight);
            }
            //DisplayEnemy1(0);
            //DisplayEnemy2(0);
            //DisplayEnemy3(0);
            SetProgressBars();
        }

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
            if (p == 1) k = 0;
        }
        int k = 0;  //k - parametar koji pamti koja su dugmad pritisnuta i njihov redoslijed
                    //1. cifra - zadnje pritisnuto dugme, 3. cifra prvo pritisnuto dugme
        int p = 1;  //p - parametar koji pamti koliko je puta dugme pritisnuto
                    //p = 1 ili 0, nije ni jednom pritisnuto, 10 jednom pritisnuto, ..., 1000 tri puta pritisnuto

        public int FindSkill(int position, int tip)
        {
            List<Skill> skills = Stuff.FindCharacter(1).GetSkills();
            int n = skills.Count, m = 0, k = 0;
            for (int i = 0; i < n; i++)
            {
                if (skills[i].GetMainType() == tip) m++;
                if (m == position)
                {
                    k = skills[i].GetID();
                    break;
                }
            }
            if (position > m) k = -1;
            return k;
        }

        public int FindTarget(int n)
        {
            // n je trocifren broj koji oznacava odabrane opcije
            int target = (n % 1000) / 100;
            List<Monster> monsters = Stuff.GetBattle().GetMonsterParty();
            int m = 0;
            for (int i = 0; i < monsters.Count; i++)
            {
                if (monsters[i].GetID() == 0)
                {
                    if (target > i) target++;
                }
            }
            if (target > monsters.Count) target = -1;
            return target;
        }

        public void EndTurn(int n)
        {
            int option = n % 10;
            switch(option)
            {
                case 1:
                case 2:
                    try
                    {
                        int skillID = (n % 100) / 10;
                        skillID = FindSkill(skillID, option);
                        if (skillID < 0) throw new System.ArgumentException("Invalid skill selected", "option");
                        Skill skill = Stuff.FindSkill(skillID);
                        int target = FindTarget(n);
                        if (target < 0) throw new System.ArgumentException("Invalid enemy selected", "option");
                        String report = Stuff.GetBattle().EndTurn(skill, target);
                        InfoBox.Text = report;
                        if(Stuff.GetBattle().DidBattleEnd())
                        {
                            Stuff.SetReport(report);
                            Stuff.SetOption(0);
                            this.Frame.Navigate(typeof(ExitBattle), Stuff);
                        }
                    }
                    catch(System.ArgumentException ex)
                    {
                        InfoBox.Text = ex.Message;
                    }
                    break;
                case 3:
                    break;
                default:
                    break;
             
            }
        }

        public void ChangeButtonText(int x)
        {
            // aka je x = 1 na buttone pise napade, a ako je 2 pise ability-e
            // ako je x = 3 ispisuju se neprijatelji
            int n, m = 0;
            Attack_Text.Text = "";
            Ability_Text.Text = "";
            Item_Text.Text = "";
            Run_Text.Text = "";
            if (x == 3)
            {
                n = Stuff.GetBattle().GetMonsterParty().Count();
            }
            else
            {
                n = Stuff.FindCharacter(1).GetSkills().Count();
            }
            for (int i = 0; i < n; i++)
            {
                string tekst; int tip;
                if (x == 3)
                {
                    tekst = Stuff.GetBattle().GetMonsterParty()[i].GetName();
                    tip = 3;
                }
                else
                {
                    tekst = Stuff.FindCharacter(1).GetSkills()[i].GetName();
                    tip = Stuff.FindCharacter(1).GetSkills()[i].GetMainType();
                }
                //Run_Text.Text = Run_Text.Text + i;
                if (tip == x && (x != 3 || Stuff.GetBattle().GetMonsterParty()[i].GetID() != 0))
                {
                    switch (m)
                    {
                        case 0:
                            Attack_Text.Text = tekst;
                            Ability_Text.Text = "";
                            Item_Text.Text = "";
                            Run_Text.Text = "";
                            m += 1;
                            break;
                        case 1:
                            Ability_Text.Text = tekst;
                            Item_Text.Text = "";
                            Run_Text.Text = "";
                            m += 1;
                            break;
                        case 2:
                            Item_Text.Text = tekst;
                            Run_Text.Text = "";
                            m += 1;
                            break;
                        case 3:
                            Run_Text.Text = tekst;
                            m += 1;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void DisplayInformation()
        {
            if(k < 10)
            {
                InfoBox.Text = "Select this option to ";
                if (k == 1) InfoBox.Text += "choose an attack.";
                if (k == 2) InfoBox.Text += "choose an ability.";
                if (k == 3) InfoBox.Text += "open up the inventory.";
                if (k == 4) InfoBox.Text += "attempt to escape!";
            }
            else if(k < 100)
            {
                if (k % 10 < 3)
                {
                    int id = FindSkill(k / 10, k % 10);
                    EquipmentSlots equipment = Stuff.FindCharacter(1).GetEquipment();
                    InfoBox.Text = "Base damage: ";
                    if (equipment.GetPrimary().GetID() != 0)
                        InfoBox.Text += equipment.GetPrimary().GetPower();
                    else InfoBox.Text += 15;
                    if (id >= 0)
                    {
                        Skill skill = Stuff.FindSkill(id);
                        InfoBox.Text += "\nName: " + skill.GetName() + "\n" + skill.GetDescription() + "\n"
                            + "Deals " + skill.GetPower() + "% of base damage" + "\nCosts " + skill.GetManaCost()
                            + " mana";
                    }
                    else
                    {
                        InfoBox.Text = "INVALID OPTION!";
                    }
                }
            }
            else
            {
                int target = FindTarget(k);
                if (target >= 0)
                {
                    Monster monster = Stuff.GetBattle().GetMonsterParty()[target - 1];
                    InfoBox.Text = "Level: " + monster.GetLVL() + "\nName: " + monster.GetName() + "\n" + monster.GetDescription() + "\n";
                }
                else
                {
                    InfoBox.Text = "INVALID OPTION!";
                }
            }
        }
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
                    k = 1; p = 1;
                    break;
                default:
                    if (p == 1) k = 1;
                    else
                    {
                        k = p + k % p;
                    }
                    break;
            }
            DisplayInformation();
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
                    k = 2; p = 1;
                    break;
                default:
                    if (p == 1) k = 2;
                    else
                    {
                        k = 2*p + k % p;
                    }
                    break;
            }
            DisplayInformation();
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
                    k = 3; p = 1;
                    break;
                default:
                    if (p == 1) k = 3;
                    else
                    {
                        k = 3 * p + k % p;
                    }
                    break;
            }
            DisplayInformation();
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
                    if (p == 1) k = 4;
                    else
                    {
                        k = 4 * p + k % p;
                    }
                    break;
            }
            DisplayInformation();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            switch (k % (p * 10))
            {
                case 1:
                    ChangeButtonText(1);
                    p = 10;
                    break;
                case 2:
                    ChangeButtonText(2);
                    p = 10;
                    break;
                case 3:
                    Stuff.SetOption(11);
                    this.Frame.Navigate(typeof(InventoryMeni), Stuff);
                    break;
                case 4:
                    Stuff.SetOption(2);
                    this.Frame.Navigate(typeof(ExitBattle), Stuff);
                    break;
                case 11:
                case 21:
                case 31:
                case 41:
                case 12:
                case 22:
                case 32:
                case 42:
                    ChangeButtonText(3);
                    p = 100;
                    break;
                default:
                    EndTurn(k);
                    SetProgressBars();
                    Attack_Text.Text = "Attack";
                    Ability_Text.Text = "Use Ability";
                    Item_Text.Text = "Use Item";
                    Run_Text.Text = "Run Away";
                    Confirm.Opacity = 0;
                    Confirm_Image.Opacity = 0;
                    Deny.Opacity = 0;
                    Deny_Image.Opacity = 0;
                    k = 0; p = 1;
                    break;
            }
            ResetSelect();
        }

        private void Deny_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            p = p / 10;
            k = k % 10;
            if (p == 0) p = 1;
            if (p == 1) k = 0;
            switch (k % (p * 10))
            {
                case 1:
                    ChangeButtonText(1);
                    p = 10;
                    break;
                case 2:
                    ChangeButtonText(2);
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
                    ChangeButtonText(3);
                    p = 100;
                    break;
                default:
                    Attack_Text.Text = "Attack";
                    Ability_Text.Text = "Use Ability";
                    Item_Text.Text = "Use Item";
                    Run_Text.Text = "Run Away";
                    Confirm.Opacity = 0;
                    Confirm_Image.Opacity = 0;
                    Deny.Opacity = 0;
                    Deny_Image.Opacity = 0;
                    k = 0; p = 1;
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
