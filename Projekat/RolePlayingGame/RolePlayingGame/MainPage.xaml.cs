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
        public MainPage()
        {
            Collection Stuff = new Collection();
            {
                //Adding Skills
                Skill Element = new Skill();
                Element.SetID(1);
                Element.SetName("Soft Punch");
                Element.SetSprite("/Assets/Skills/Attacks/punch.png");
                Element.SetMainType(1);
                Element.SetSubType(1);
                Element.SetDescription("Lightly tap your opponent with your fist");
                Element.SetPower(10);
                Element.SetAccuracy(1);
                Element.SetManaCost(0);
                Stuff.AddSkill(Element);

            }

            {
                //Adding Monsters

            }

            {
                //Adding Character
                Character Hero = new Character();
                Hero.AddSkill(Stuff.FindSkill(1));
                Stuff.AddCharacter(Hero);
            }
            
            this.InitializeComponent();
        }

        public void RadiNesto()
        {
            this.Frame.Navigate(typeof(BlankPage1), null);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1), null);
        }
    }
}
