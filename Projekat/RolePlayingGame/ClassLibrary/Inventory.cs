using System;
using System.Collections.Generic;

namespace Entity {
	public class Inventory {
		private int iD;
		private String name;
		private String description;
		private int capacity = 25;
		private int currentNo;
        private List<Item> items;

		public Inventory() {
            items = new List<Item>();
		}
		public void AddItem(Item item){
            items.Add(item);
		}
		public void RemoveItem(Item item) {
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
		public int GetCurrentNo() {
			return this.currentNo;
		}
		public void SetCurrentNo(int currentNo) {
			this.currentNo = currentNo;
		}
        public void SetItems(List<Item> items)
        {
            this.items = items;
        }
        public List<Item> GetItems()
        {
            return items;
        }

	}

}
