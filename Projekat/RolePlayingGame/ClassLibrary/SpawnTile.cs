using System;
namespace Entity {
	public class SpawnTile {
		private int ID = 0;

		public int GetID() {
			return this.ID;
		}
		public void SetID(ref int iD) {
			this.ID = iD;
		}
		public SpawnTile() {
			throw new System.Exception("Not implemented");
		}

		private Map map;

	}

}
