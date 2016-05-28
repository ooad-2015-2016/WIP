using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Entity {
	public class Map {
        //m x n
		private int iD = 0;
		private int height = 0;
        private int width = 0;
        private List<bool> collisionLayer;
		private List<SpawnTile> spawnLayer;
		private Image mapImage;
		private List<FunctionTile> functionLayer;

		public Map() {
            mapImage = new Image();
            collisionLayer = new List<bool>();
            spawnLayer = new List<SpawnTile>();
            functionLayer = new List<FunctionTile>();
		}
        private int GetPosition(int x, int y)
        {
            //Prebacuje dvodimenzionalnu poziciju na mapi na jednodimenzionu poziciju na listi
            int z = x + y * width;
            return z;
        }

        public bool CheckCollision(int x, int y) {
            int z = GetPosition(x, y);
            return !collisionLayer[z];
		}
		public bool CheckFunction(ref object int_x, ref object int_y) {
			throw new System.Exception("Not implemented");
		}
		public bool CheckBattle(ref object int_x, ref object int_y) {
			throw new System.Exception("Not implemented");
		}
		//public void() MoveCharacter() {
		//	throw new System.Exception("Not implemented");
		//}
		public int GetID() {
			return this.iD;
		}
		public void SetID(int iD) {
			this.iD = iD;
		}
        public int GetWidth()
        {
            return this.width;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int Getm()
        {
            return this.height;
        }
        public void Setm(int height)
        {
            this.height = height;
        }
        public int Getn()
        {
            return this.width;
        }
        public void Setn(int width)
        {
            this.width = width;
        }
        public List<bool> GetCollisionLayer()
        {
            return collisionLayer;
        }
        public void SetCollisionLayer(List<bool> collisionLayer)
        {
            this.collisionLayer = collisionLayer;
        }
        public List<SpawnTile> GetSpawnLayer()
        {
            return spawnLayer;
        }
        public void SetSpawnLayer(List<SpawnTile> spawnLayer)
        {
            this.spawnLayer = spawnLayer;
        }
        public Image GetMapImage() {
			return this.mapImage;
		}
		public void SetMapImage(string text) {
            text = "ms-appx:" + text;
            Uri imageUri = new Uri(text, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            mapImage.Source = imageBitmap;
		}
        public List<FunctionTile> GetFunctionLayer()
        {
            return functionLayer;
        }
        public void SetFunctionLayer(List<FunctionTile> functionLayer)
        {
            this.functionLayer = functionLayer;
        }

	}

}
