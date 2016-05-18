using System;
namespace Entity {
	public class SpawnTile {
		private int iD = 0;

		public int GetID() {
			return this.iD;
		}
		public void SetID(ref int iD) {
			this.iD = iD;
		}
		public SpawnTile() {
			throw new System.Exception("Not implemented");
		}

		private Map map;

	}

}
