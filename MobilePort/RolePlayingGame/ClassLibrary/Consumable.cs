using System;
using Windows.UI.Xaml.Controls;

namespace Entity {
	public class Consumable : Item  {
		private int healthChange = 0;
		private int manaChange = 0;

		public Consumable()
        {
            ActuallySetSprite(new Image());
        }
        public Consumable(Item item)
        {
            this.SetID(item.GetID());
            this.SetName(item.GetName());
            this.SetDescription(item.GetDescription());
            this.SetPrice(item.GetPrice());
            this.ActuallySetSprite(item.GetSprite());
            ActuallySetSprite(new Image());
        }
        public int GetHealthChange() {
			return this.healthChange;
		}
		public void SetHealthChange(int healthChange) {
			this.healthChange = healthChange;
		}
		public int GetManaChange() {
			return this.manaChange;
		}
		public void SetManaChange(int manaChange) {
			this.manaChange = manaChange;
		}

	}

}
