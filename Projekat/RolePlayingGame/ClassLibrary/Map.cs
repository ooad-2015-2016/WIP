using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Entity {
	public class Map {
		private int iD = 0;
		private int length = 0;
		private List<bool> collisionLayer;
		private List<SpawnTile> spawnLayer;
		private int width = 0;
		private Image mapImage;
		private List<FunctionTile> functionLayer;

		public Map() {
			throw new System.Exception("Not implemented");
		}
		public bool CheckCollision(ref object int_x, ref object int_y) {
			throw new System.Exception("Not implemented");
		}
		public bool CheckFunction(ref object int_x, ref object int_y) {
			throw new System.Exception("Not implemented");
		}
		public bool CheckBattle(ref object int_x, ref object int_y) {
			throw new System.Exception("Not implemented");
		}
		public void() MoveCharacter() {
			throw new System.Exception("Not implemented");
		}
		public int GetID() {
			return this.iD;
		}
		public void SetID(ref int iD) {
			this.iD = iD;
		}
		public int GetLength() {
			return this.length;
		}
		public void SetLength(ref int length) {
			this.length = length;
		}
		public void<bool> GetCollisionLayer() {
			throw new System.Exception("Not implemented");
		}
		public void SetCollisionLayer(ref object<bool> collisionLayer) {
			throw new System.Exception("Not implemented");
		}
		public void<SpawnTile> GetSpawnLayer() {
			throw new System.Exception("Not implemented");
		}
		public void SetSpawnLayer(ref object<SpawnTile> spawnLayer) {
			throw new System.Exception("Not implemented");
		}
		public int GetWidth() {
			return this.width;
		}
		public void SetWidth(ref int width) {
			this.width = width;
		}
		public Image GetMapImage() {
			return this.mapImage;
		}
		public void SetMapImage(ref Image mapImage) {
			this.mapImage = mapImage;
		}
		public void<FunctionTile> GetFunctionLayer() {
			throw new System.Exception("Not implemented");
		}
		public void SetFunctionLayer(ref object<FunctionTile> functionLayer) {
			throw new System.Exception("Not implemented");
		}

		private FunctionTile functionTile;
		private SpawnTile spawnTile;

	}

}
