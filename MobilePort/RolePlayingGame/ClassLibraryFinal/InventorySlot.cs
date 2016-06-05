using System;
namespace Entity {
	public class InventorySlot {
		private int capacity;
		private int currentNo;

		public InventorySlot() {
			throw new System.Exception("Not implemented");
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

		private Item item;

		private Inventory inventory;

	}

}
