using System;
namespace Entity {
	public class Atributes : Monster  {
		private int strength;
		public int Strength {
			get {
				return strength;
			}
			set {
				strength = value;
			}
		}
		private int vitality;
		private int agility;
		private int intelligence;
		private int willpower;
		private int luck;
		public int Luck {
			get {
				return luck;
			}
			set {
				luck = value;
			}
		}

		public Atributes() {
			throw new System.Exception("Not implemented");
		}
		public int GetStrength() {
			return this.strength;
		}
		public void SetStrength(ref int strength) {
			this.strength = strength;
		}
		public int GetVitality() {
			return this.vitality;
		}
		public void SetVitality(ref int vitality) {
			this.vitality = vitality;
		}
		public int GetAgility() {
			return this.agility;
		}
		public void SetAgility(ref int agility) {
			this.agility = agility;
		}
		public int GetIntelligence() {
			return this.intelligence;
		}
		public void SetIntelligence(ref int intelligence) {
			this.intelligence = intelligence;
		}
		public int GetLuck() {
			return this.luck;
		}
		public void SetLuck(ref int luck) {
			this.luck = luck;
		}
		public String GetStrengthInfo() {
			throw new System.Exception("Not implemented");
		}
		public String GetVitalityInfo() {
			throw new System.Exception("Not implemented");
		}
		public String GerAgilityInfo() {
			throw new System.Exception("Not implemented");
		}
		public String GetIntelligenceInfo() {
			throw new System.Exception("Not implemented");
		}
		public String GetWilllpowerInfo() {
			throw new System.Exception("Not implemented");
		}
		public String GetLuckInfo() {
			throw new System.Exception("Not implemented");
		}
		public Double GetHitChance() {
			throw new System.Exception("Not implemented");
		}
		public Double GetDodgeChance() {
			throw new System.Exception("Not implemented");
		}
		public Double GetCritChance() {
			throw new System.Exception("Not implemented");
		}
		public Double GetCritMultiplyer() {
			throw new System.Exception("Not implemented");
		}

		private Character character;

	}

}
