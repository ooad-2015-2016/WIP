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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            UpdateCharacter();
        }
        public MapMeni()
        {
            this.InitializeComponent();
        }

        public void SetMap()
        {
            Map.Source = Stuff.FindMap(Stuff.GetCurrentMapID()).GetBottomLayer().Source;
            MapFront.Source = Stuff.FindMap(Stuff.GetCurrentMapID()).GetTopLayer().Source;
            Map.Height = Stuff.FindMap(Stuff.GetCurrentMapID()).GetHeight() * 32;
            Map.Width = Stuff.FindMap(Stuff.GetCurrentMapID()).GetWidth() * 32;
            MapFront.Height = Stuff.FindMap(Stuff.GetCurrentMapID()).GetHeight() * 32;
            MapFront.Width = Stuff.FindMap(Stuff.GetCurrentMapID()).GetWidth() * 32;
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
            int m = mapa.Getm() - 1,
                n = mapa.Getn();
            int x = 0, y = 0;
            GetCharacterPosition(ref x, ref y);
            //button.Content = m + " " + n + "d " + x + " " + y;
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
            button4.Content = x + " " + y + " " + Stuff.FindMap(1).GetFunction(x, y).GetID();  
        }
    }
}
