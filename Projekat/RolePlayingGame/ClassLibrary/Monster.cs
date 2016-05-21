using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Entity {
	public class Monster {
		private int ID;
		private String name;
		private Image sprite;
		private int LVL;
		private int health;
        public int Health;
		private int maxHealth;
		private int mana;
		private int maxMana;
		private Atributes atributes;
		private List<Skill> skills;
		private List<StatusEffect> statusEffects;

		public int GetID() {
			return this.ID;
		}
		public void SetID(ref int ID) {
			this.ID = ID;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(ref String name) {
			this.name = name;
		}
		public Image GetSprite() {
			return this.sprite;
		}
		public void SetSprite(ref Image sprite) {
			this.sprite = sprite;
		}
		public int GetLVL() {
			return this.LVL;
		}
		public void SetLVL(ref int LVL) {
			this.LVL = LVL;
		}
		public int GetHealth() {
			return this.health;
		}
		public void SetHealth(ref int health) {
			this.health = health;
		}
		public int GetMaxHealth() {
			return this.maxHealth;
		}
		public void SetMaxHealth(ref int maxHealth) {
			this.maxHealth = maxHealth;
		}
		public int GetMana() {
			return this.mana;
		}
		public void SetMana(ref int mana) {
			this.mana = mana;
		}
		public int GetMaxMana() {
			return this.maxMana;
		}
		public void SetMaxMana(ref int maxMana) {
			this.maxMana = maxMana;
		}
		public Atributes GetAtributes() {
			return this.atributes;
		}
		public void SetAtributes(ref Atributes atributes) {
			this.atributes = atributes;
		}
		//public void<Skill> GetSkills() {
		//	throw new System.Exception("Not implemented");
		//}
		//public void SetSkills(ref object<Skill> skills) {
		//	throw new System.Exception("Not implemented");
		//}
		//public void<StatusEffect> GetStatusEffects() {
		//	throw new System.Exception("Not implemented");
		//}
		//public void SetStatusEffects(ref object<StatusEffect> statusEffects) {
		//	throw new System.Exception("Not implemented");
		//}
		public Monster() {
			throw new System.Exception("Not implemented");
		}
		public Skill AIDecide() {
			throw new System.Exception("Not implemented");
		}
		public Monster(ref object parameter) {
			throw new System.Exception("Not implemented");
		}

		private AI aI;

	}

}
