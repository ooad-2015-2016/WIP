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
		private List<int> spawnLayer;
		private Image bottomLayer;
        private Image topLayer;
		private List<FunctionTile> functionLayer;

		public Map() {
            bottomLayer = new Image();
            topLayer = new Image();
            collisionLayer = new List<bool>();
            spawnLayer = new List<int>();
            functionLayer = new List<FunctionTile>();
		}
        public int GetPosition(int x, int y)
        {
            //Prebacuje dvodimenzionalnu poziciju na mapi na jednodimenzionu poziciju na listi
            int z = x + y * width;
            return z;
        }

        public bool CheckCollision(int x, int y) {
            bool collision = false;
            if (x >= 0 && y >= 0 && x <= width && y <= height)
            {
                int z = GetPosition(x, y);
                collision = !collisionLayer[z];
            }
            return collision;
		}
		public FunctionTile GetFunction(int x, int y) {
            int z = GetPosition(x, y);
            return functionLayer[z];
		}
		public bool CheckBattle(int x, int y, Random rand) {
            int spawn = spawnLayer[GetPosition(x, y)];
            bool battle = false;
            switch(spawn)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    if(rand.Next(1, 10) <= 2) battle = true;
                    break;
                case 7:
                    battle = true;
                    break;
                default:
                    break;
            }
            return battle;
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
        public List<int> GetSpawnLayer()
        {
            return spawnLayer;
        }
        public void SetSpawnLayer(List<int> spawnLayer)
        {
            this.spawnLayer = spawnLayer;
        }
        public Image GetBottomLayer() {
			return this.bottomLayer;
		}
		public void SetBottomLayer(string text) {
            text = "ms-appx:" + text;
            Uri imageUri = new Uri(text, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            bottomLayer.Source = imageBitmap;
		}
        public Image GetTopLayer()
        {
            return this.topLayer;
        }
        public void SetTopLayer(string text)
        {
            text = "ms-appx:" + text;
            Uri imageUri = new Uri(text, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            topLayer.Source = imageBitmap;
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
