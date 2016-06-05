using System;
namespace Entity {
	public class FunctionTile {
		private int iD = 0;
		private int destinationID;
		private int destinationX;
		private int destinationY;

		public int GetID() {
			return this.iD;
		}
		public void SetID(ref int iD) {
			this.iD = iD;
		}
		public int GetDestinationID() {
			return this.destinationID;
		}
		public void SetDestinationID(ref int destinationID) {
			this.destinationID = destinationID;
		}
		public int GetDestinationX() {
			return this.destinationX;
		}
		public void SetDestinationX(ref int destinationX) {
			this.destinationX = destinationX;
		}
		public int GetDestinationY() {
			return this.destinationY;
		}
		public void SetDestinationY(ref int destinationY) {
			this.destinationY = destinationY;
		}
		public FunctionTile() {
			throw new System.Exception("Not implemented");
		}

		private Map map;

	}

}
