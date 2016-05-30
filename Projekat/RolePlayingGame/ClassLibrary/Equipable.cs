using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Entity {
	public class Equipable : Item  {
		private List<Modifiers> modifiers;
		private int mainType;  // 1 - weapon, 2 - shield, 3 - armor 
		private int subType;
		private int power;

        public Equipable()
        {
            ActuallySetSprite(new Image());
            modifiers = new List<Modifiers>();
        }
        public Equipable(Item item)
        {
            this.SetID(item.GetID());
            this.SetName(item.GetName());
            this.SetDescription(item.GetDescription());
            this.SetPrice(item.GetPrice());
            this.ActuallySetSprite(item.GetSprite());
            ActuallySetSprite(new Image());
            modifiers = new List<Modifiers>();
        }

        public int GetMainType() {
			return this.mainType;
		}
		public void SetMainType(int mainType) {
			this.mainType = mainType;
		}
		public int GetSubType() {
			return this.subType;
		}
		public void SetSubType(int subType) {
			this.subType = subType;
		}
		public int GetPower() {
			return this.power;
		}
		public void SetPower(int power) {
			this.power = power;
		}
		public Modifiers GetModifiers() {
			throw new System.Exception("Not implemented");
		}
		public void SetModifiers(ref Modifiers modifiers) {
			throw new System.Exception("Not implemented");
		}
	}

}
