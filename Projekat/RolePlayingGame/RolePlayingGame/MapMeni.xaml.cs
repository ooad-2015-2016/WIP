using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RolePlayingGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MapMeni : Page
    {
        Collection Stuff = new Collection();

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    Stuff = e.Parameter as Collection;
        //}
        public MapMeni()
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
                skill2.SetPower(30);
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

                //Adding enemy skills
                Skill skill = new Skill();
                skill.SetID(101);
                skill.SetName("Bite");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent");
                skill.SetPower(5);
                skill.SetAccuracy(1);
                skill.SetManaCost(0);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(102);
                skill.SetName("Ferotious Bite");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(15);
                skill.SetAccuracy(1);
                skill.SetManaCost(15);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(103);
                skill.SetName("Drain Life");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(10);
                skill.SetAccuracy(1);
                skill.SetManaCost(20);
                Stuff.AddSkill(skill);
            }

            {
                //Adding Monsters
                Monster Enemy = new Monster();
                Enemy.SetID(1);
                Enemy.SetName("Sleepy Bat");
                Enemy.SetSprite("/Assets/Monsters/bat.png");
                Enemy.SetDescription("Likes to hang around.");
                Enemy.AddSkill(Stuff.FindSkill(101));
                Enemy.AddSkill(Stuff.FindSkill(102));
                Enemy.AddSkill(Stuff.FindSkill(103));
                Stuff.AddMonster(Enemy);
            }

            {
                //Adding Character
                Character Hero = new Character();
                Hero.SetName("Helpless Soul");
                Hero.AddSkill(Stuff.FindSkill(1));
                Hero.AddSkill(Stuff.FindSkill(2));
                Hero.AddSkill(Stuff.FindSkill(3));
                Hero.AddSkill(Stuff.FindSkill(4));
                Hero.AddSkill(Stuff.FindSkill(5));
                Hero.AddSkill(Stuff.FindSkill(6));
                Hero.SetSprite("/Assets/Players/PlayerDown.png"); ;
                Stuff.AddCharacter(Hero);
            }

            {
                //Adiding Map
                Map Mapa = new Entity.Map();
                Mapa.SetID(1);
                Mapa.Setm(23);
                Mapa.Setn(40);
                Mapa.SetMapImage("/Assets/Maps/Mapa1.png");
                List<bool> collision = new List<bool> { true, true, true, false, false, false, false, false, false, false, false, true, true, true, false, true, true, true, false, false, false, false, true, true, true, true, true, false, true, true, true, true, false, true, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, false, true, false, true, true, true, true, true, true, true, true, true, true, false, true, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, false, true, false, false, true, true, true, true, true, true, true, false, false, false, true, false, false, false, false, true, false, true, true, true, false, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, true, false, false, true, true, true, true, true, false, false, false, false, false, true, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, false, true, true, false, false, false, false, false, false, false, false, false, true, true, true, false, true, false, false, false, false, true, true, true, true, false, true, false, false, false, false, false, false, false, false, true, true, true, true, true, false, true, true, true, false, false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, true, true, true, true, true, true, true, false, false, false, false, false, false, true, true, true, true, true, false, false, true, false, false, false, false, true, true, true, true, false, false, false, false, false, true, true, true, false, false, true, true, true, true, true, true, false, false, false, false, false, false, true, false, true, true, true, true, true, false, false, false, false, false, false, true, true, true, true, false, true, false, false, false, false, false, true, true, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, false, false, false, true, true, true, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, false, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, true, true, true, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, true, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
                Mapa.SetCollisionLayer(collision);
                Stuff.AddMap(Mapa);
                Stuff.FindCharacter(1).SetPositionX(20);
                Stuff.FindCharacter(1).SetPositionY(14);
                Stuff.SetCurrentMapID(1);
            }

            this.InitializeComponent();
            int x = Stuff.FindCharacter(1).GetPositionX(),
                y = Stuff.FindCharacter(1).GetPositionY(),
                m = Stuff.FindMap(Stuff.GetCurrentMapID()).Getm(),
                n = Stuff.FindMap(Stuff.GetCurrentMapID()).Getn();
            button.Content = m + " " + n + "d " + x + " " + y;
            UpdateCharacter();
        }

        public void UpdateCharacter()
        {
            int x = Stuff.FindCharacter(1).GetPositionX(),
                y = Stuff.FindCharacter(1).GetPositionY() - 1;
            Player.Source = Stuff.FindCharacter(1).GetSprite().Source;
            Player.Margin = new Thickness(x * 32, y * 32, 0, 0);
        }

        public void SetCharacterPosition(int x, int y)
        {
            Stuff.FindCharacter(1).SetPositionX(x);
            Stuff.FindCharacter(1).SetPositionY(y);
            UpdateCharacter();
        }

        public void MoveCharacter(int direction)
        {
            // direction = 1 move up, 2 move down, 4 move right, 3 move left
            Map mapa = Stuff.FindMap(Stuff.GetCurrentMapID());
            int x = Stuff.FindCharacter(1).GetPositionX(),
                y = Stuff.FindCharacter(1).GetPositionY(),
                m = mapa.Getm() - 1,
                n = mapa.Getn();
            button.Content = m + " " + n + "d " + x + " " + y;
            string text = "/Assets/Players/";
            switch (direction)
            {
                case 1:
                    text += "PlayerUp.png";
                    if (y > 0 && mapa.CheckCollision(x, y - 1)) y--;
                    break;
                case 2:
                    text += "/PlayerDown.png";
                    if (y < m && mapa.CheckCollision(x, y + 1))  y++;
                    break;
                case 3:
                    text += "/PlayerLeft.png";
                    if (x > 0 && mapa.CheckCollision(x - 1, y)) x--;
                    break;
                default:
                    text += "/PlayerRight.png";
                    if (x < n && mapa.CheckCollision(x + 1, y)) x++;
                    break;
            }
            Stuff.FindCharacter(1).SetSprite(text);
            SetCharacterPosition(x, y);
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MoveCharacter(3);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MoveCharacter(1);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MoveCharacter(4);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MoveCharacter(2);
        }
    }
}
