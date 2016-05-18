using System;
namespace Entity {
	public class Character {
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
		private int class;
		private Sprite sprite;
		private int positionX;
		private int positionY;
		private int lVL;
		public int LVL {
			get {
				return lVL;
			}
			set {
				lVL = value;
			}
		}
		private int eXP;
		public int EXP {
			get {
				return eXP;
			}
			set {
				eXP = value;
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
		private Inventory inventory;
		private EquipmentSlots equipment;
		private List<Skill> skills;
		private list<StatusEffect> statusEffects;

		public Character() {
			throw new System.Exception("Not implemented");
		}
		public void LevelUp() {
			throw new System.Exception("Not implemented");
		}
		public void IncreaseHealth(ref object int_) {
			throw new System.Exception("Not implemented");
		}
		public void LoseHealth(ref object int_) {
			throw new System.Exception("Not implemented");
		}
		public void IncreaseMana(ref object int_) {
			throw new System.Exception("Not implemented");
		}
		public void LoseMana(ref object int_) {
			throw new System.Exception("Not implemented");
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
		public void AddSkill(ref object skill) {
			throw new System.Exception("Not implemented");
		}
		public void RemoveSkill(ref object skill) {
			throw new System.Exception("Not implemented");
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
		public int GetClass() {
			return this.class;
		}
		public void SetClass(ref int class) {
			this.class = class;
		}
		public Sprite GetSprite() {
			return this.sprite;
		}
		public void SetSprite(ref Sprite sprite) {
			this.sprite = sprite;
		}
		public int GetPositionX() {
			return this.positionX;
		}
		public void SetPositionX(ref int positionX) {
			this.positionX = positionX;
		}
		public int GetPositionY() {
			return this.positionY;
		}
		public void SetPositionY(ref int positionY) {
			this.positionY = positionY;
		}
		public int GetLVL() {
			return this.lVL;
		}
		public void SetLVL(ref int lVL) {
			this.lVL = lVL;
		}
		public int GetEXP() {
			return this.eXP;
		}
		public void SetEXP(ref int eXP) {
			this.eXP = eXP;
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
		public Inventory GetInventory() {
			return this.inventory;
		}
		public void SetInventory(ref Inventory inventory) {
			this.inventory = inventory;
		}
		public EquipmentSlots GetEquipment() {
			return this.equipment;
		}
		public void SetEquipment(ref EquipmentSlots equipment) {
			this.equipment = equipment;
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

		private EquipmentSlots equipmentSlots;
		private Skill skill;

	}

}
