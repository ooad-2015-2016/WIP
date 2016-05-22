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
                skill2.SetPower(10);
                skill2.SetAccuracy(1);
                skill2.SetManaCost(0);
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
            Player.Text = (Stuff.FindCharacter(1)).GetName();
            List<Monster> monsterparty = new List<Monster>((Stuff.GetBattle()).GetMonsterParty());
            Enemy1.Text = monsterparty[0].GetName();
            Enemy1Image.Source = monsterparty[0].GetSprite().Source;
            Enemy2.Text = monsterparty[1].GetName();
            Enemy2Image.Source = monsterparty[1].GetSprite().Source;
            Enemy3.Text = monsterparty[2].GetName();
            Enemy3Image.Source = monsterparty[2].GetSprite().Source;
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

        public void ChangeButtonText(int x)
        {
            // aka je x = 1 na buttone pise napade, a ako je 2 pise ability-e
            int n = Stuff.FindCharacter(1).GetSkills().Count(), m = 0;
            for (int i = 0; i < n; i++)
            {
                Skill skill;
                skill = Stuff.FindCharacter(1).GetSkills()[i];
                //Run_Text.Text = Run_Text.Text + i;
                if (skill.GetMainType() == x)
                {
                    switch (m)
                    {
                        case 0:
                            Attack_Text.Text = skill.GetName();
                            Ability_Text.Text = "";
                            Item_Text.Text = "";
                            Run_Text.Text = "";
                            m += 1;
                            break;
                        case 1:
                            Ability_Text.Text = skill.GetName();
                            Item_Text.Text = "";
                            Run_Text.Text = "";
                            m += 1;
                            break;
                        case 2:
                            Item_Text.Text = skill.GetName();
                            Run_Text.Text = "";
                            m += 1;
                            break;
                        case 3:
                            Run_Text.Text = skill.GetName();
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
