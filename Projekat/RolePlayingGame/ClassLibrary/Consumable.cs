using System;
namespace Entity {
	public class Consumable : Item  {
		private int healthChange = 0;
		private int manaChange = 0;

		public Consumable() { }
		public int GetHealthChange() {
			return this.healthChange;
		}
		public void SetHealthChange(ref int healthChange) {
			this.healthChange = healthChange;
		}
		public int GetManaChange() {
			return this.manaChange;
		}
		public void SetManaChange(ref int manaChange) {
			this.manaChange = manaChange;
		}

	}

}
