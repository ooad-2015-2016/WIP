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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
namespace ClassLibrary { }
namespace RolePlayingGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Collection Stuff = new Collection();
        public MainPage()
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
                Hero.SetEXP(23);
                Hero.AddSkill(Stuff.FindSkill(1));
                Hero.AddSkill(Stuff.FindSkill(2));
                Hero.AddSkill(Stuff.FindSkill(3));
                Hero.AddSkill(Stuff.FindSkill(4));
                Hero.AddSkill(Stuff.FindSkill(5));
                Hero.AddSkill(Stuff.FindSkill(6));
                Stuff.AddCharacter(Hero);
            }

            {
                //Adding functions
                FunctionTile function = new FunctionTile();
                Stuff.AddFunctionTile(function);
                //Teleport sa mape 1 na mapu 2 (shop)
                FunctionTile function1 = new FunctionTile();
                function1.SetID(1);
                function1.SetFunType(1);
                function1.SetDestinationID(2);
                function1.SetDestinationX(5);
                function1.SetDestinationY(8);
                Stuff.AddFunctionTile(function1);
                //Teleport sa mape 2 na mapu 1
                FunctionTile function2 = new FunctionTile();
                function2.SetID(2);
                function2.SetFunType(1);
                function2.SetDestinationID(1);
                function2.SetDestinationX(29);
                function2.SetDestinationY(8);
                Stuff.AddFunctionTile(function2);
                //Otvaranje Shopa 1
                FunctionTile function3 = new FunctionTile();
                function3.SetID(3);
                function3.SetFunType(2);
                function3.SetDestinationID(1);
                Stuff.AddFunctionTile(function3);


            }

            {
                //Adiding Maps
                Map Mapa = new Map();
                Mapa.SetID(1);
                Mapa.Setm(23);
                Mapa.Setn(40);
                Mapa.SetBottomLayer("/Assets/Maps/Mapa1.png");
                Mapa.SetTopLayer("/Assets/Maps/Mapa1Front.png");
                List<bool> collision = new List<bool> { true, true, true, false, false, false, false, false, false, false, false, true, true, true, false, true, true, true, false, false, false, false, true, true, true, true, true, false, true, true, true, true, false, true, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, false, true, false, true, true, true, true, true, true, true, true, true, true, false, true, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, false, true, false, false, true, true, true, true, true, true, true, false, false, false, true, false, false, false, false, true, false, true, true, true, false, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, true, false, false, true, true, true, true, true, false, false, false, false, false, true, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, false, true, true, false, false, false, false, false, false, false, false, false, true, true, true, false, true, false, false, false, false, true, true, true, true, false, true, false, false, false, false, false, false, false, false, true, true, true, true, true, false, true, true, true, false, false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, true, true, true, true, true, true, true, false, false, false, false, false, false, true, true, true, true, true, false, false, true, false, false, false, false, true, true, true, true, false, false, false, false, false, true, true, true, false, false, true, true, true, true, true, true, false, false, false, false, false, false, true, false, true, true, true, true, true, false, false, false, false, false, false, true, true, true, true, false, true, false, false, false, false, false, true, true, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, false, false, false, true, true, true, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, false, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, true, true, true, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, true, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
                Mapa.SetCollisionLayer(collision);

                List<int> functionIDs = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                List<FunctionTile> functions = new List<FunctionTile>();
                for (int i = 0; i < functionIDs.Count; i++) functions.Add(Stuff.FindFunctionTile(functionIDs[i]));
                Mapa.SetFunctionLayer(functions);

                Stuff.AddMap(Mapa);
                Stuff.FindCharacter(1).SetPositionX(20);
                Stuff.FindCharacter(1).SetPositionY(14);
                Stuff.SetCurrentMapID(1);

                //Mapa 2 -Shop
                Map Mapa2 = new Map();
                Mapa2.SetID(2);
                Mapa2.Setm(10);
                Mapa2.Setn(10);
                Mapa2.SetBottomLayer("/Assets/Maps/Shop.png");
                Mapa2.SetTopLayer("/Assets/Maps/ShopFront.png");
                List<bool> collision2 = new List<bool> { true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true };
                Mapa2.SetCollisionLayer(collision2);

                List<int> functionIDs2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                List<FunctionTile> functions1 = new List<FunctionTile>();
                for (int i = 0; i < functionIDs2.Count; i++) functions1.Add(Stuff.FindFunctionTile(functionIDs2[i]));
                Mapa2.SetFunctionLayer(functions1);

                Stuff.AddMap(Mapa2);
            }

            this.InitializeComponent();
        }

        public void RadiNesto()
        {
            this.Frame.Navigate(typeof(BlankPage1), null);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1), Stuff);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapMeni), Stuff);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InGameMeni), Stuff);
        }
    }
}
