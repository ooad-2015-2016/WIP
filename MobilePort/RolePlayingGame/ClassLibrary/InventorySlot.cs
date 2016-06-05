using System;
namespace Entity {
	public class InventorySlot {
		private int capacity = 8;
		private int quantity = 0;
        private Item item;

        public InventorySlot() { }

		public int GetCapacity() {
			return this.capacity;
		}
		public void SetCapacity(int capacity) {
			this.capacity = capacity;
		}
		public int GetQuantity() {
			return this.quantity;
		}
		public void SetQuantity(int currentNo) {
			this.quantity = currentNo;
		}
        public void IncreaseQuantity()
        {
            quantity++;
        }
        public void SetItem(Item item)
        {
            if (item is Equipable) capacity = 1;
            this.item = item;
        }
        public bool IsFull()
        {
            bool x = false;
            if (capacity == quantity) x = true;
            return x;
        }
        public Item GetItem()
        {
            return item;
        }
	}

}
