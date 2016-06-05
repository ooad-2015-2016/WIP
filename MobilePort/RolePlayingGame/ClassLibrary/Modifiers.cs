using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Entity {
	public class Modifiers {
		private int iD;
		private String name;
		private Image sprite;
		private String description;
		private int value;
		private bool addOrMultiply;
		private bool targetsSelf;
		private Double statusEffectChance;
		private StatusEffect newStatusEffect;

		public Modifiers() {
			throw new System.Exception("Not implemented");
		}
		public int GetID() {
			return this.iD;
		}
		public void SetID(ref int iD) {
			this.iD = iD;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(ref String name) {
			this.name = name;
		}
        public Image GetSprite()
        {
            return this.sprite;
        }
        public void SetSprite(String text)
        {
            text = "ms-appx:" + text;
            Uri imageUri = new Uri(text, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            sprite.Source = imageBitmap;
        }
        public string GetDescription() {
            return description;
		}
		public void SetDescription(string description) {
            this.description = description;
		}
		public int GetValue() {
			return this.value;
		}
		public void SetValue(ref int value) {
			this.value = value;
		}
		public bool GetAddOrMultiply() {
			return this.addOrMultiply;
		}
		public void SetAddOrMultiply(ref bool addOrMultiply) {
			this.addOrMultiply = addOrMultiply;
		}
		public bool GetTargetsSelf() {
			return this.targetsSelf;
		}
		public void SetTargetsSelf(ref bool targetsSelf) {
			this.targetsSelf = targetsSelf;
		}
		public StatusEffect GetNewStatusEffect() {
			return this.newStatusEffect;
		}
		public void SetNewStatusEffect(ref StatusEffect newStatusEffect) {
			this.newStatusEffect = newStatusEffect;
		}
		public Double GetStatusEffectChance() {
			return this.statusEffectChance;
		}
		public void SetStatusEffectChance(ref Double statusEffectChance) {
			this.statusEffectChance = statusEffectChance;
		}

	}

}
