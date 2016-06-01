using System;
namespace Entity {
	public class EquipmentSlots {
		private Equipable primaryWeapon;
		private Equipable secondaryWeapon;
		private Equipable armor;

		public EquipmentSlots() {
            primaryWeapon = new Equipable();
            secondaryWeapon = new Equipable();
            armor = new Equipable();
        }
        public Equipable GetPrimary()
        {
            return primaryWeapon;
        }
		public void SetPrimary(Equipable item) {
            primaryWeapon = item;
		}
        public Equipable GetSecondary()
        {
            return secondaryWeapon;
        }
        public void SetSecondary(Equipable item) {
            secondaryWeapon = item;
		}
        public Equipable GetArmor()
        {
            return primaryWeapon;
        }
        public void SetArmor(Equipable item) {
            armor = item;
        }
		public void RemovePrimary() {
            primaryWeapon = new Equipable();
        }
		public void RemoveSecondary() {
            secondaryWeapon = new Equipable();
        }
		public void RemoveArmor() {
            armor = new Equipable();
        }

	}

}
