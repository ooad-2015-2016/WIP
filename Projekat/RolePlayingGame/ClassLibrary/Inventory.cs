using System;
using System.Collections.Generic;

namespace Entity {
	public class Inventory {
		private int iD;
		private String name;
		private String description;
		private int capacity = 25;
		private int quantity;
        private List<InventorySlot> items;

		public Inventory() {
            items = new List<InventorySlot>();
		}
        public int FindAvailableSlot(Item item)
        {
            int slot = -1;
            for(int i = 0; i < items.Count; i++)
            {
                if(items[i].GetItem().GetID() == item.GetID() && !items[i].IsFull())
                {
                    slot = i;
                }
            }
            return slot;
        }
		public void AddItem(Item item){
            int pos = FindAvailableSlot(item);
            if(pos == -1)
            {
                InventorySlot slot = new InventorySlot();
                slot.IncreaseQuantity();
                slot.SetItem(item);
                items.Add(slot);
                quantity++;
            }
            else
            {
                items[pos].IncreaseQuantity();
            }
		}
		public void RemoveItemSlot(InventorySlot item) {
            items.Remove(item);
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
        public void SetItemSlots(List<InventorySlot> items)
        {
            this.items = items;
        }
        public List<InventorySlot> GetItemSlots()
        {
            return items;
        }

	}

}
