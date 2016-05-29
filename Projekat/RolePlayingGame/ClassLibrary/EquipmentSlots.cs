using System;
namespace Entity {
	public class EquipmentSlots {
		private Item primaryWeapon;
		private Item secondaryWeapon;
		private Item armor;

		public EquipmentSlots() {
            primaryWeapon = new Equipable();
            secondaryWeapon = new Equipable();
            armor = new Equipable();
        }
		public void AddPrimary(Equipable item) {
            primaryWeapon = item;
		}
		public void AddSecondary(Equipable item) {
            secondaryWeapon = item;
		}
		public void AddArmor(Equipable item) {
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
