using System;
namespace Entity {
	public class Item {
		private int iD;
		private String name;
		private Imagine sprite;
		private int price;
		private String description;

		public Item() {
			throw new System.Exception("Not implemented");
		}
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
		public Imagine GetSprite() {
			return this.sprite;
		}
		public void SetSprite(ref Imagine sprite) {
			this.sprite = sprite;
		}
		public int GetPrice() {
			return this.price;
		}
		public void SetPrice(ref int price) {
			this.price = price;
		}
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(ref String description) {
			this.description = description;
		}

		private InventorySlot inventorySlot;

	}

}
