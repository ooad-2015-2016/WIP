using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Entity {
	public class Equipable : Item  {
		private List<Modifiers> modifiers;
		private Image sprite;
		private int mainType;
		private int subType;
		private int power;

        public Equipable()
        {
            modifiers = new List<Modifiers>();
        }
        public int GetMainType() {
			return this.mainType;
		}
		public void SetMainType(ref int mainType) {
			this.mainType = mainType;
		}
		public int GetSubType() {
			return this.subType;
		}
		public void SetSubType(ref int subType) {
			this.subType = subType;
		}
		public int GetPower() {
			return this.power;
		}
		public void SetPower(ref int power) {
			this.power = power;
		}
		public Modifiers GetModifiers() {
			throw new System.Exception("Not implemented");
		}
		public void SetModifiers(ref Modifiers modifiers) {
			throw new System.Exception("Not implemented");
		}

		private EquipmentSlots equipmentSlots;

	}

}
