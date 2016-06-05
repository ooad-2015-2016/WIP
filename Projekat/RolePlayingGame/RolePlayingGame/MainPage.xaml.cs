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

                //Adding enemy skills -Bat
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

                //-Cave dweller
                skill = new Skill();
                skill.SetID(111);
                skill.SetName("Pickaxe Strike");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent");
                skill.SetPower(5);
                skill.SetAccuracy(1);
                skill.SetManaCost(0);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(112);
                skill.SetName("Rock Throw");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(15);
                skill.SetAccuracy(1);
                skill.SetManaCost(10);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(113);
                skill.SetName("Kung Fu");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(25);
                skill.SetAccuracy(1);
                skill.SetManaCost(20);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(114);
                skill.SetName("Cliff Breaker");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(50);
                skill.SetAccuracy(1);
                skill.SetManaCost(30);
                Stuff.AddSkill(skill);

                //-Bird-man
                skill = new Skill();
                skill.SetID(121);
                skill.SetName("Tackle");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent");
                skill.SetPower(10);
                skill.SetAccuracy(1);
                skill.SetManaCost(0);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(122);
                skill.SetName("Claw Strike");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(30);
                skill.SetAccuracy(1);
                skill.SetManaCost(20);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(123);
                skill.SetName("Boulder Toss");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(60);
                skill.SetAccuracy(1);
                skill.SetManaCost(30);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(124);
                skill.SetName("Whirlwind");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(20);
                skill.SetAccuracy(1);
                skill.SetManaCost(15);
                Stuff.AddSkill(skill);

                //-Fungi
                skill = new Skill();
                skill.SetID(131);
                skill.SetName("Fungal Slap");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent");
                skill.SetPower(10);
                skill.SetAccuracy(1);
                skill.SetManaCost(0);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(132);
                skill.SetName("Toxic Fumes");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(40);
                skill.SetAccuracy(1);
                skill.SetManaCost(20);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(133);
                skill.SetName("Neurotoxic Bite");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(90);
                skill.SetAccuracy(1);
                skill.SetManaCost(40);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(134);
                skill.SetName("Root grab");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(30);
                skill.SetAccuracy(1);
                skill.SetManaCost(15);
                Stuff.AddSkill(skill);

                //-Dragonling
                skill = new Skill();
                skill.SetID(141);
                skill.SetName("Swipe");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent");
                skill.SetPower(10);
                skill.SetAccuracy(1);
                skill.SetManaCost(0);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(142);
                skill.SetName("Fireball");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(80);
                skill.SetAccuracy(1);
                skill.SetManaCost(20);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(143);
                skill.SetName("Flamestrike");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(300);
                skill.SetAccuracy(1);
                skill.SetManaCost(70);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(144);
                skill.SetName("Pyroblast");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(500);
                skill.SetAccuracy(1);
                skill.SetManaCost(100);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(145);
                skill.SetName("Fireblast");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(30);
                skill.SetAccuracy(1);
                skill.SetManaCost(5);
                Stuff.AddSkill(skill);

                //-Medusa
                skill = new Skill();
                skill.SetID(151);
                skill.SetName("Tentacle Strike");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent");
                skill.SetPower(20);
                skill.SetAccuracy(1);
                skill.SetManaCost(0);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(152);
                skill.SetName("Death Stare");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(1000);
                skill.SetAccuracy(1);
                skill.SetManaCost(150);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(153);
                skill.SetName("Grab");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(50);
                skill.SetAccuracy(1);
                skill.SetManaCost(20);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(154);
                skill.SetName("Terror gaze");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(100);
                skill.SetAccuracy(1);
                skill.SetManaCost(25);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(155);
                skill.SetName("Tentacle Flurry");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(250);
                skill.SetAccuracy(1);
                skill.SetManaCost(50);
                Stuff.AddSkill(skill);

                //-Devil's Advocate

                skill = new Skill();
                skill.SetID(161);
                skill.SetName("Harrasement Complaint");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent");
                skill.SetPower(100);
                skill.SetAccuracy(1);
                skill.SetManaCost(0);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(162);
                skill.SetName("Sexual Harrasement Charge");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(250);
                skill.SetAccuracy(1);
                skill.SetManaCost(50);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(163);
                skill.SetName("Copiright Infringement Lawsuit");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(1500);
                skill.SetAccuracy(1);
                skill.SetManaCost(100);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(164);
                skill.SetName("Canadian Devil's Mobile Game!®");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(5000);
                skill.SetAccuracy(1);
                skill.SetManaCost(200);
                Stuff.AddSkill(skill);

                skill = new Skill();
                skill.SetID(165);
                skill.SetName("I AM THE LAW! - in Silvester Stalone's voice");
                skill.SetSprite("/Assets/Skills/Attacks/punch.png");
                skill.SetMainType(1);
                skill.SetSubType(1);
                skill.SetDescription("Bite your opponent hard");
                skill.SetPower(3000);
                skill.SetAccuracy(1);
                skill.SetManaCost(150);
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

                Enemy = new Monster();
                Enemy.SetID(2);
                Enemy.SetName("Cave Dweller");
                Enemy.SetSprite("/Assets/Monsters/hardhat.png");
                Enemy.SetDescription("Usually found near caverns, obviously. Also doesn't like company.");
                Enemy.AddSkill(Stuff.FindSkill(111));
                Enemy.AddSkill(Stuff.FindSkill(112));
                Enemy.AddSkill(Stuff.FindSkill(113));
                Enemy.AddSkill(Stuff.FindSkill(114));
                Stuff.AddMonster(Enemy);

                Enemy = new Monster();
                Enemy.SetID(3);
                Enemy.SetName("Bird-man");
                Enemy.SetSprite("/Assets/Monsters/birdman.png");
                Enemy.SetDescription("Icarus went too far on this one.");
                Enemy.AddSkill(Stuff.FindSkill(121));
                Enemy.AddSkill(Stuff.FindSkill(122));
                Enemy.AddSkill(Stuff.FindSkill(123));
                Enemy.AddSkill(Stuff.FindSkill(124));
                Stuff.AddMonster(Enemy);

                Enemy = new Monster();
                Enemy.SetID(4);
                Enemy.SetName("Eatus Humanus");
                Enemy.SetSprite("/Assets/Monsters/mushroom.png");
                Enemy.SetDescription("Commonly considered to be a mushroom, but he's actually a fungi.");
                for(int i = 1; i <= 4; i++)
                    Enemy.AddSkill(Stuff.FindSkill(130 + i));
                Stuff.AddMonster(Enemy);

                Enemy = new Monster();
                Enemy.SetID(5);
                Enemy.SetName("Powerfull Dragonling");
                Enemy.SetSprite("/Assets/Monsters/lizard.png");
                Enemy.SetDescription("Oh. So you like hitting babies. How nice of you. This baby ain't messing around.");
                for (int i = 1; i <= 5; i++)
                    Enemy.AddSkill(Stuff.FindSkill(140 + i));
                Stuff.AddMonster(Enemy);

                Enemy = new Monster();
                Enemy.SetID(6);
                Enemy.SetName("Medusa");
                Enemy.SetSprite("/Assets/Monsters/eye.png");
                Enemy.SetDescription("I woudn't look at it, if I we're you.");
                for (int i = 1; i <= 5; i++)
                    Enemy.AddSkill(Stuff.FindSkill(150 + i));
                Stuff.AddMonster(Enemy);

                Enemy = new Monster();
                Enemy.SetID(7);
                Enemy.SetName("Devil's Advocate");
                Enemy.SetSprite("/Assets/Monsters/imp.png");
                Enemy.SetDescription("He came straight from hell. You better have prepared your defence.");
                for (int i = 1; i <= 5; i++)
                    Enemy.AddSkill(Stuff.FindSkill(160 + i));
                Stuff.AddMonster(Enemy);

            }

            {
                //Adding consumable items
                Consumable item = new Consumable();

                //Adding food
                item.SetID(2);
                item.SetName("Bread");
                item.SetDescription("Restores 15 health");
                item.SetSprite("/Assets/Items/Food1.png");
                item.SetPrice(1);
                item.SetHealthChange(15);
                Stuff.AddItem(item);

                item = new Consumable();
                item.SetID(3);
                item.SetName("Cheese");
                item.SetDescription("Restores 25 health");
                item.SetSprite("/Assets/Items/Food2.png");
                item.SetPrice(1);
                item.SetHealthChange(25);
                Stuff.AddItem(item);

                item = new Consumable();
                item.SetID(4);
                item.SetName("Spinach");
                item.SetDescription("Restores 40 health");
                item.SetSprite("/Assets/Items/Food3.png");
                item.SetPrice(1);
                item.SetHealthChange(40);
                Stuff.AddItem(item);

                //Adding Scrolls

                item = new Consumable();
                item.SetID(5);
                item.SetName("Healing Scroll");
                item.SetDescription("Restores 60 health");
                item.SetSprite("/Assets/Items/Scroll1.png");
                item.SetPrice(1);
                item.SetHealthChange(60);
                Stuff.AddItem(item);

                item = new Consumable();
                item.SetID(6);
                item.SetName("Mana Scroll");
                item.SetDescription("Restores 40 mana");
                item.SetSprite("/Assets/Items/Scroll2.png");
                item.SetPrice(1);
                item.SetManaChange(40);
                Stuff.AddItem(item);
            }
            {
                //Adding Equipment

                //Adding armor
                Equipable item = new Equipable();
                item.SetID(7);
                item.SetName("Leather Armor");
                item.SetDescription("Offers light protection.");
                item.SetSprite("/Assets/Items/Armor1.png");
                item.SetPrice(1);
                item.SetMainType(3);
                item.SetPower(20);
                Stuff.AddItem(item);

                item = new Equipable();
                item.SetID(8);
                item.SetName("Fancy Shirt");
                item.SetDescription("Offers next to no protection.");
                item.SetSprite("/Assets/Items/Armor2.png");
                item.SetPrice(1);
                item.SetMainType(3);
                item.SetPower(5);
                Stuff.AddItem(item);

                item = new Equipable();
                item.SetID(9);
                item.SetName("Chainmail Armor");
                item.SetDescription("Offers decent protection.");
                item.SetSprite("/Assets/Items/Armor3.png");
                item.SetPrice(1);
                item.SetMainType(3);
                item.SetPower(50);
                Stuff.AddItem(item);

                item = new Equipable();
                item.SetID(10);
                item.SetName("Steel Armor");
                item.SetDescription("Offers great protection.");
                item.SetSprite("/Assets/Items/Armor4.png");
                item.SetPrice(1);
                item.SetMainType(3);
                item.SetSubType(2);
                item.SetPower(100);
                Stuff.AddItem(item);

                //Adding axes
                item = new Equipable();
                item.SetID(11);
                item.SetName("Stone Axe");
                item.SetDescription("Cuts trees semi-decently.");
                item.SetSprite("/Assets/Items/Axe1.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(2);
                item.SetPower(10);
                Stuff.AddItem(item);

                item = new Equipable();
                item.SetID(12);
                item.SetName("Iron Axe");
                item.SetDescription("Chops all sorts of things.");
                item.SetSprite("/Assets/Items/Axe1.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(2);
                item.SetPower(10);
                Stuff.AddItem(item);

                item = new Equipable();
                item.SetID(13);
                item.SetName("Steel Waraxe");
                item.SetDescription("You don't want to know where this one was found.");
                item.SetSprite("/Assets/Items/Axe3.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(2);
                item.SetPower(10);
                Stuff.AddItem(item);

                //Adding swords
                item = new Equipable();
                item.SetID(14);
                item.SetName("Steel Sword");
                item.SetDescription("Pretty basic");
                item.SetSprite("/Assets/Items/Sword1.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(1);
                item.SetPower(10);
                Stuff.AddItem(item);

                item = new Equipable();
                item.SetID(15);
                item.SetName("Legendary Dragon's Blade");
                item.SetDescription("Shiny");
                item.SetSprite("/Assets/Items/Sword2.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(1);
                item.SetPower(10);
                Stuff.AddItem(item);

                //Adding daggers
                item = new Equipable();
                item.SetID(16);
                item.SetName("Dark Shiv");
                item.SetDescription("Silent, and deadly.");
                item.SetSprite("/Assets/Items/Dagger2.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(3);
                item.SetPower(10);
                Stuff.AddItem(item);

                item = new Equipable();
                item.SetID(17);
                item.SetName("Ritual Blade");
                item.SetDescription("Has some strange illegible markings.");
                item.SetSprite("/Assets/Items/Dagger1.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(3);
                item.SetPower(10);
                Stuff.AddItem(item);

                //Adding staves
                item = new Equipable();
                item.SetID(18);
                item.SetName("Old man's walking stick");
                item.SetDescription("Seriously, has no magical abilities.");
                item.SetSprite("/Assets/Items/Staff1.png");
                item.SetPrice(1);
                item.SetMainType(1);
                item.SetSubType(4);
                item.SetPower(10);
                Stuff.AddItem(item);
            }

            {
                //Adding Shops
                Shop shop = new Shop();
                shop.SetID(1);
                shop.SetName("Lil' Billy's General Store");
                shop.SetDescription("It's dangerous to go alone! So buy something wud'ya.");
                Inventory stock = new Inventory();
                stock.SetID(1);
                for(int i = 2; i <= 17; i++)
                {
                    stock.AddItem(Stuff.FindItem(i));
                }
                shop.SetInventory(stock);
                Stuff.AddShop(shop);
            }

            {
                //Adding Character
                Character Hero = new Character();
                Hero.SetName("Helpless Soul");
                for(int i = 1; i <= 6; i++) Hero.AddSkill(Stuff.FindSkill(i));
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
                Stuff.FindCharacter(1).SetPositionX(14);
                Stuff.FindCharacter(1).SetPositionY(11);
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

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Stuff.SetOption(1);
            this.Frame.Navigate(typeof(InventoryMeni), Stuff);
        }
    }
}
