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
            Mana.Text = "Mana:" + "  \t" + PlayerMana + "/" + PlayerMaxMana;

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

            Enemy2.Text = monsterparty[1].GetName();
            Enemy1Image.Source = monsterparty[1].GetSprite().Source;
            double Enemy2HP = Stuff.GetBattle().GetMonsterParty()[1].GetHealth();
            double Enemy2MaxHP = Stuff.GetBattle().GetMonsterParty()[1].GetMaxHealth();
            Enemy2HealthBar.Value = Enemy2HP / Enemy2MaxHP * 100;
            double Enemy2MP = Stuff.GetBattle().GetMonsterParty()[1].GetMana();
            double Enemy2MaxMP = Stuff.GetBattle().GetMonsterParty()[1].GetMaxMana();
            Enemy2ManaBar.Value = Enemy2MP / Enemy2MaxMP * 100;
            Enemy2Health.Text = "Health:" + "\t" + Enemy2HP + "/" + Enemy2MaxHP;
            Enemy2Mana.Text = "Mana:" + "  \t" + Enemy2MP + "/" + Enemy2MaxMP;

            Enemy3.Text = monsterparty[2].GetName();
            Enemy3Image.Source = monsterparty[2].GetSprite().Source;
            double Enemy3HP = Stuff.GetBattle().GetMonsterParty()[2].GetHealth();
            double Enemy3MaxHP = Stuff.GetBattle().GetMonsterParty()[2].GetMaxHealth();
            Enemy3HealthBar.Value = Enemy3HP / Enemy3MaxHP * 100;
            double Enemy3MP = Stuff.GetBattle().GetMonsterParty()[1].GetMana();
            double Enemy3MaxMP = Stuff.GetBattle().GetMonsterParty()[1].GetMaxMana();
            Enemy3ManaBar.Value = Enemy3MP / Enemy3MaxMP * 100;
            Enemy3Health.Text = "Health:" + "\t" + Enemy3HP + "/" + Enemy3MaxHP;
            Enemy3Mana.Text = "Mana:" + "  \t" + Enemy3MP + "/" + Enemy3MaxMP;

        }

        public BlankPage1()
        {
            {
                //Adding Skills
                Skill skill1 = new Skill();
                skill1.SetID(1);
                skill1.SetName("Soft Punch");
                skill1.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill1.SetMainType(1);
                skill1.SetSubType(1);
                skill1.SetDescription("Lightly tap your opponent with your fist");
                skill1.SetPower(10);
                skill1.SetAccuracy(1);
                skill1.SetManaCost(0);
                Stuff.AddSkill(skill1);

                Skill skill2 = new Skill();
                skill2.SetID(2);
                skill2.SetName("Hard Punch");
                skill2.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill2.SetMainType(1);
                skill2.SetSubType(1);
                skill2.SetDescription("Tap your opponent with your fist slightly harder");
                skill2.SetPower(20);
                skill2.SetAccuracy(1);
                skill2.SetManaCost(25);
                Stuff.AddSkill(skill2);

                Skill skill3 = new Skill();
                skill3.SetID(3);
                skill3.SetName("Stab");
                skill3.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill3.SetMainType(1);
                skill3.SetSubType(1);
                skill3.SetDescription("BEGONE DEMON!");
                skill3.SetPower(10);
                skill3.SetAccuracy(1);
                skill3.SetManaCost(0);
                Stuff.AddSkill(skill3);

                Skill skill4 = new Skill();
                skill4.SetID(4);
                skill4.SetName("Heal");
                skill4.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill4.SetMainType(2);
                skill4.SetSubType(1);
                skill4.SetDescription("Increase your health");
                skill4.SetPower(10);
                skill4.SetAccuracy(1);
                skill4.SetManaCost(0);
                Stuff.AddSkill(skill4);

                Skill skill5 = new Skill();
                skill5.SetID(5);
                skill5.SetName("Focus");
                skill5.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill5.SetMainType(2);
                skill5.SetSubType(1);
                skill5.SetDescription("Slightly increases health and mana");
                skill5.SetPower(10);
                skill5.SetAccuracy(1);
                skill5.SetManaCost(0);
                Stuff.AddSkill(skill5);

                Skill skill6 = new Skill();
                skill6.SetID(6);
                skill6.SetName("Beserk");
                skill6.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill6.SetMainType(2);
                skill6.SetSubType(1);
                skill6.SetDescription("Increases attack");
                skill6.SetPower(10);
                skill6.SetAccuracy(1);
                skill6.SetManaCost(0);
                Stuff.AddSkill(skill6);
            }

            {
                //Adding Monsters
                Monster Element2 = new Monster();
                Element2.SetID(1);
                Element2.SetName("Sleepy bat");
                Element2.SetSprite("/Assets/Monsters/bat.png");
                Stuff.AddMonster(Element2);
            }

            {
                //Adding Character
                Character Hero = new Character();
                Hero.SetName("Helpless soul");
                Hero.AddSkill(Stuff.FindSkill(1));
                Hero.AddSkill(Stuff.FindSkill(2));
                Hero.AddSkill(Stuff.FindSkill(3));
                Hero.AddSkill(Stuff.FindSkill(4));
                Hero.AddSkill(Stuff.FindSkill(5));
                Hero.AddSkill(Stuff.FindSkill(6));
                Stuff.AddCharacter(Hero);
            }
            {
                //Adding a battle
                Battle Fight = new Battle();
                Fight.AddPlayer(Stuff.FindCharacter(1));
                Fight.AddMonster(Stuff.FindMonster(1));
                Fight.AddMonster(Stuff.FindMonster(1));
                Fight.AddMonster(Stuff.FindMonster(1));
                Stuff.SetBattle(Fight);
            }
            this.InitializeComponent();
            Confirm.Opacity = 0;
            Confirm_Image.Opacity = 0;
            Deny.Opacity = 0;
            Deny_Image.Opacity = 0;
            Attack_Select.Opacity = 0;
            Ability_Select.Opacity = 0;
            Item_Select.Opacity = 0;
            Run_Select.Opacity = 0;

            SetProgressBars();
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
            return k;
        }


        public void EndTurn(int n)
        {
            int option = n % 10;
            switch(option)
            {
                case 1:
                case 2:
                    int skillID = (n % 100) / 10;
                    skillID = FindSkill(skillID, option);
                    int target = (n % 1000) / 100;
                    Skill skill = Stuff.FindSkill(skillID);
                    Stuff.GetBattle().EndTurn(skill, target);
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
                if (tip == x)
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
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
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
                    ChangeButtonText(3);
                    p = 100;
                    break;
                default:
                    EndTurn(k);
                    SetProgressBars();
                    Player.Text = k.ToString();
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

        private void Deny_Click(object sender, RoutedEventArgs e)
        {
            ResetSelect();
            p = p / 10;
            k = k % 10;
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
                    Player.Text = k.ToString();
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
