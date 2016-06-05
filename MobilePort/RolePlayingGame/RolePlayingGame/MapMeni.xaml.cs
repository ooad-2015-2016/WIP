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


namespace RolePlayingGame
{

    public sealed partial class MapMeni : Page
    {
        Collection Stuff = new Collection();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            UpdateCharacter();
            SetMap();
            Stuff.SetOption(0);
        }
        public MapMeni()
        {
            this.InitializeComponent();
        }

        public void SetMap()
        {
            Map.Source = Stuff.FindMap(Stuff.GetCurrentMapID()).GetBottomLayer().Source;
            MapFront.Source = Stuff.FindMap(Stuff.GetCurrentMapID()).GetTopLayer().Source;
            Map.Height = Stuff.FindMap(Stuff.GetCurrentMapID()).GetHeight() * 19;
            Map.Width = Stuff.FindMap(Stuff.GetCurrentMapID()).GetWidth() * 19;
            MapFront.Height = Stuff.FindMap(Stuff.GetCurrentMapID()).GetHeight() * 19;
            MapFront.Width = Stuff.FindMap(Stuff.GetCurrentMapID()).GetWidth() * 19;
        }

        public void GetCharacterPosition(ref int x, ref int y)
        {
            x = Stuff.FindCharacter(1).GetPositionX();
            y = Stuff.FindCharacter(1).GetPositionY();
        }

        public void UpdateCharacter()
        {
            int x = 0, y = 0;
            GetCharacterPosition(ref x,ref y); y--;
            Player.Source = Stuff.FindCharacter(1).GetSprite().Source;
            Player.Margin = new Thickness(x * 19, y * 19, 0, 0);
        }

        public void SetCharacterPosition(int x, int y)
        {
            Stuff.FindCharacter(1).SetPositionX(x);
            Stuff.FindCharacter(1).SetPositionY(y);
            UpdateCharacter();
        }

        public void CheckBattle(int x, int y)
        {
            Map mapa = Stuff.FindMap(Stuff.GetCurrentMapID());
            if(mapa.CheckBattle(x, y, Stuff.GetRandom()))
            {
                Stuff.SetOption(mapa.GetSpawnLayer()[mapa.GetPosition(x, y)]);
                this.Frame.Navigate(typeof(BlankPage1), Stuff);
            }
        }

        public void MoveCharacter(int direction)
        {
            // direction = 1 move up, 2 move down, 4 move right, 3 move left
            Map mapa = Stuff.FindMap(Stuff.GetCurrentMapID());
            int m = mapa.Getm() - 1,
                n = mapa.Getn();
            int x = 0, y = 0; bool hasMoved = false;
            GetCharacterPosition(ref x, ref y);
            //button.Content = m + " " + n + "d " + x + " " + y;
            string text = "/Assets/Players/";
            switch (direction)
            {
                case 1:
                    text += "PlayerUp.png";
                    if (y > 0 && mapa.CheckCollision(x, y - 1))
                    {
                        y--; hasMoved = true;
                    }
                    break;
                case 2:
                    text += "/PlayerDown.png";
                    if (y < m && mapa.CheckCollision(x, y + 1))
                    {
                        y++; hasMoved = true;
                    }
                        break;
                case 3:
                    text += "/PlayerLeft.png";
                    if (x > 0 && mapa.CheckCollision(x - 1, y))
                    {
                        x--; hasMoved = true;
                    }
                        break;
                default:
                    text += "/PlayerRight.png";
                    if (x < n && mapa.CheckCollision(x + 1, y))
                    {
                        x++; hasMoved = true;
                    }
                    break;
            }
            Stuff.FindCharacter(1).SetSprite(text);
            SetCharacterPosition(x, y);
            if (hasMoved) CheckBattle(x, y);
        }

        public void ExecuteFunction()
        {
            int x = 0, y = 0;
            GetCharacterPosition(ref x, ref y);
            FunctionTile function = Stuff.FindMap(Stuff.GetCurrentMapID()).GetFunction(x, y);
            switch(function.GetFunType())
            {
                case 1:
                    //Change Map
                    Stuff.SetCurrentMapID(function.GetDestinationID());
                    SetMap();
                    x = function.GetDestinationX();
                    y = function.GetDestinationY();
                    Stuff.FindCharacter(1).SetPositionX(x);
                    Stuff.FindCharacter(1).SetPositionY(y);
                    SetCharacterPosition(x, y);
                    break;
                case 2:
                    Stuff.SetOption(1);
                    this.Frame.Navigate(typeof(InventoryMeni), Stuff);
                    break;
                default:
                    break;
            }
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

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ExecuteFunction();
            int x = 0, y = 0;
            GetCharacterPosition(ref x, ref y);
            //button4.Content = x + " " + y + " " + Stuff.FindMap(1).GetFunction(x, y).GetID();  
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InGameMeni), Stuff);
        }
    }
}
