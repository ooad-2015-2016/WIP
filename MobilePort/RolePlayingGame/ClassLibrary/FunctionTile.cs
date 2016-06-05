using System;
namespace Entity {
	public class FunctionTile {
		private int iD = 0;
        private int funtype = 0; //tip 1 - teleport, tip 2 - shop
		private int destinationID = 0;
		private int destinationX = 0;
		private int destinationY = 0;

		public int GetID() {
			return this.iD;
		}
		public void SetID(int iD) {
			this.iD = iD;
		}
        public int GetFunType()
        {
            return this.funtype;
        }
        public void SetFunType(int funtype)
        {
            this.funtype = funtype;
        }
        public int GetDestinationID() {
			return this.destinationID;
		}
		public void SetDestinationID(int destinationID) {
			this.destinationID = destinationID;
		}
		public int GetDestinationX() {
			return this.destinationX;
		}
		public void SetDestinationX(int destinationX) {
			this.destinationX = destinationX;
		}
		public int GetDestinationY() {
			return this.destinationY;
		}
		public void SetDestinationY(int destinationY) {
			this.destinationY = destinationY;
		}
		public FunctionTile() { }

	}

}
