using System;
namespace Entity {
	public class Inventory {
		private int iD;
		private String name;
		private String description;
		private int capacity;
		private int currentNo;

		public Inventory() {
			throw new System.Exception("Not implemented");
		}
		public void AddItem(ref object item) {
			throw new System.Exception("Not implemented");
		}
		public void RemoveItem(ref object item) {
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
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(ref String description) {
			this.description = description;
		}
		public int GetCapacity() {
			return this.capacity;
		}
		public void SetCapacity(ref int capacity) {
			this.capacity = capacity;
		}
		public int GetCurrentNo() {
			return this.currentNo;
		}
		public void SetCurrentNo(ref int currentNo) {
			this.currentNo = currentNo;
		}

		private InventorySlot inventorySlot;

		private Character character;
		private Shop shop;

	}

}
