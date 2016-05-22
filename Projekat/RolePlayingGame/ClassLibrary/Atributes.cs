using System;
namespace Entity {
	public class Atributes : Monster  {
		private int strength = 10;
		private int vitality = 10;
		private int agility = 10;
		private int intelligence = 10;
		private int willpower = 10;
		private int luck = 10;
//Atributes go from 10 to 50
		public Atributes() { }
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
            double dodge = Math.Ceiling(-323.7*Math.Pow(agility, -0.7553) + 56.86);
            return dodge;
    
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
