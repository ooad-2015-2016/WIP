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
using Windows.UI.Xaml.Shapes;

namespace RolePlayingGame
{
    public sealed partial class ExitBattle : Page
    {
        Collection Stuff = new Collection();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stuff = e.Parameter as Collection;
            UpdateCharacter();
            SetMap();
            if (Stuff.GetBattle().GetPlayerParty()[0].GetID() != 0)
            {
                BattleResults.Text = "\t         Congratulations!\n\t\tYou won!\n";
                BattleReport.Text = Stuff.GetReport();
            }
            else
            {
                BattleResults.Text = "\t         You have DIED!";
                BattleReport.Text = Stuff.GetReport();
            }

        }

        public ExitBattle()
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
            GetCharacterPosition(ref x, ref y); y--;
            Player.Source = Stuff.FindCharacter(1).GetSprite().Source;
            Player.Margin = new Thickness(x * 32, y * 32, 0, 0);
        }

        public void SetCharacterPosition(int x, int y)
        {
            Stuff.FindCharacter(1).SetPositionX(x);
            Stuff.FindCharacter(1).SetPositionY(y);
            UpdateCharacter();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(Stuff.GetBattle().GetPlayerParty()[0].GetID() != 0)
            {
                this.Frame.Navigate(typeof(MapMeni), Stuff);
            }
            else
            {
                this.Frame.Navigate(typeof(MainPage), Stuff);
            }
        }
    }
}
