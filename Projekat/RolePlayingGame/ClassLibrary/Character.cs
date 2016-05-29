using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Entity {
	public class Character {
		private int ID;
		private String name;
		private int HeroClass;
		private Image sprite;
		private int positionX;
		private int positionY;
		private int LVL;
		private int EXP;
		private int health;
		private int maxHealth;
		private int mana;
		private int maxMana;
		private Atributes atributes;
		private Inventory inventory;
		private EquipmentSlots equipment;
		private List<Skill> skills;
		private List<StatusEffect> statusEffects;

		public Character()
        {
            ID = 1; name = "";  LVL = 1;
            sprite = new Image();
            maxHealth = 100; health = maxHealth;
            maxMana = 50; mana = maxMana;
            skills = new List<Skill>();
            statusEffects = new List<StatusEffect>();
        }
		public void LevelUp() {
			throw new System.Exception("Not implemented");
		}
		public void IncreaseHealth(int x) {
            health += x;
        }
		public void LoseHealth(int x) {
            health -= x;
        }
		public void IncreaseMana(int x) {
            mana += x;
        }
		public void LoseMana(int x) {
            mana -= x; 
		}
		public Atributes GetAtributes() {
			return this.atributes;
		}
		public void SetAtributes(ref Atributes atributes) {
			this.atributes = atributes;
		}
		public void Equip(ref object item) {
			throw new System.Exception("Not implemented");
		}
		public void Unequip(ref object item) {
			throw new System.Exception("Not implemented");
		}
		public void AddSkill(Skill skill) {
            skills.Add(skill);
		}
		public void RemoveSkill(Skill skill) {
            skills.Remove(skill);
		}
		public String GetSkillsInfo() {
			throw new System.Exception("Not implemented");
		}
		public void AddStatusEffect(ref object statusEffect) {
			throw new System.Exception("Not implemented");
		}
		public void RemoveStatusEffect(ref object statusEffect) {
			throw new System.Exception("Not implemented");
		}
		public int GetID() {
			return this.ID;
		}
		public void SetID(int ID) {
			this.ID = ID;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public int GetClass() {
			return this.HeroClass;
		}
		public void SetHeroClass(int HeroClass) {
			this.HeroClass = HeroClass;
		}
		public Image GetSprite() {
			return this.sprite;
		}
		public void SetSprite(string text) {
            text = "ms-appx:" + text;
            Uri imageUri = new Uri(text, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            sprite.Source = imageBitmap;
		}
		public int GetPositionX() {
			return this.positionX;
		}
		public void SetPositionX(int positionX) {
			this.positionX = positionX;
		}
		public int GetPositionY() {
			return this.positionY;
		}
		public void SetPositionY(int positionY) {
			this.positionY = positionY;
		}
		public int GetLVL() {
			return this.LVL;
		}
		public void SetLVL(int lVL) {
			this.LVL = lVL;
		}
		public int GetEXP() {
			return this.EXP;
		}
		public void SetEXP(int eXP) {
			this.EXP = eXP;
		}
        public double GetMaxEXP()
        {
            double max = 50 * Math.Pow(LVL, 3) - 300 * Math.Pow(LVL, 2) + 750 * LVL - 400;
            return max;
        }
        public int GetHealth() {
			return this.health;
		}
		public void SetHealth(int health) {
			this.health = health;
		}
		public int GetMaxHealth() {
			return this.maxHealth;
		}
		public void SetMaxHealth(int maxHealth) {
			this.maxHealth = maxHealth;
		}
		public int GetMana() {
			return this.mana;
		}
		public void SetMana(int mana) {
			this.mana = mana;
		}
		public int GetMaxMana() {
			return this.maxMana;
		}
		public void SetMaxMana(int maxMana) {
			this.maxMana = maxMana;
		}
		public Inventory GetInventory() {
			return this.inventory;
		}
		public void SetInventory(Inventory inventory) {
			this.inventory = inventory;
		}
		public EquipmentSlots GetEquipment() {
			return this.equipment;
		}
		public void SetEquipment(EquipmentSlots equipment) {
			this.equipment = equipment;
		}
        public List<Skill> GetSkills()
        {
            return skills;
        }
        public void SetSkills(List<Skill> skills)
        {
            this.skills = skills;
        }
        public List<StatusEffect> GetStatusEffects()
        {
            return statusEffects;
        }
        public void SetStatusEffects(List<StatusEffect> statusEffects)
        {
            this.statusEffects = statusEffects;
        }

	}

}
