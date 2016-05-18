using System;
namespace Entity {
	public class Monster {
		private int iD;
		public int ID {
			get {
				return iD;
			}
			set {
				iD = value;
			}
		}
		private String name;
		public String Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
		private Image sprite;
		private int lVL;
		public int LVL {
			get {
				return lVL;
			}
			set {
				lVL = value;
			}
		}
		private int health;
		public int Health {
			get {
				return health;
			}
			set {
				health = value;
			}
		}
		private int maxHealth;
		public int MaxHealth {
			get {
				return maxHealth;
			}
			set {
				maxHealth = value;
			}
		}
		private int mana;
		public int Mana {
			get {
				return mana;
			}
			set {
				mana = value;
			}
		}
		private int maxMana;
		public int MaxMana {
			get {
				return maxMana;
			}
			set {
				maxMana = value;
			}
		}
		private Atributes atributes;
		private List<Skill> skills;
		private list<StatusEffect> statusEffects;

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
		public Image GetSprite() {
			return this.sprite;
		}
		public void SetSprite(ref Image sprite) {
			this.sprite = sprite;
		}
		public int GetLVL() {
			return this.lVL;
		}
		public void SetLVL(ref int lVL) {
			this.lVL = lVL;
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
		public void<Skill> GetSkills() {
			throw new System.Exception("Not implemented");
		}
		public void SetSkills(ref object<Skill> skills) {
			throw new System.Exception("Not implemented");
		}
		public void<StatusEffect> GetStatusEffects() {
			throw new System.Exception("Not implemented");
		}
		public void SetStatusEffects(ref object<StatusEffect> statusEffects) {
			throw new System.Exception("Not implemented");
		}
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
