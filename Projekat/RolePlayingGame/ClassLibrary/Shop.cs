using System;
namespace Entity {
	public class Shop {
		private int iD;
		private String name;
		private String description;
        private Inventory inventory;

        public int GetID() {
			return this.iD;
		}
		public void SetID(ref int iD) {
			this.iD = iD;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(ref String name) {
			this.name = name;
		}
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(ref String description) {
			this.description = description;
		}

	}

}
