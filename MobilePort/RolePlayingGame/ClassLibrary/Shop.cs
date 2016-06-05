using System;
namespace Entity {
	public class Shop {
		private int iD = 0;
		private String name;
		private String description;
        private Inventory inventory;

        public Shop()
        {
            inventory = new Inventory();
        }
        public int GetID() {
			return this.iD;
		}
		public void SetID(int iD) {
			this.iD = iD;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(String description) {
			this.description = description;
		}
        public void SetInventory(Inventory inventory)
        {
            this.inventory = inventory;
        }
        public Inventory GetInventory()
        {
            return inventory;
        }

	}

}
