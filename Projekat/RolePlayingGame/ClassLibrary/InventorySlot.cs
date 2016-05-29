using System;
namespace Entity {
	public class InventorySlot {
		private int capacity;
		private int currentNo;
        private Item item;

        public InventorySlot() { }
		public int GetCapacity() {
			return this.capacity;
		}
		public void SetCapacity(int capacity) {
			this.capacity = capacity;
		}
		public int GetCurrentNo() {
			return this.currentNo;
		}
		public void SetCurrentNo(int currentNo) {
			this.currentNo = currentNo;
		}
        public void SetItem(Item item)
        {
            this.item = item;
        }
        public Item GetItem()
        {
            return item;
        }
	}

}
