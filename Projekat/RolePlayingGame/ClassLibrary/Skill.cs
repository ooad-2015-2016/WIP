using System;
using Windows.UI.Xaml.Controls;

namespace Entity {
	public class Skill {
		private int ID;
		private String name;
		private String sprite;
		private int mainType;
		private int subType;
		private String description;
		private int power;
		private Double accuracy;
		private int manaCost;
		private StatusEffect newStatusEffect;
		private Double statusEffectChance;

		public Skill() { }
		public void GetSkillInfo() {
			throw new System.Exception("Not implemented");
		}
		public void Operation() {
			throw new System.Exception("Not implemented");
		}
		public int GetID() {
			return this.ID;
		}
		public void SetID(int iD) {
			this.ID = iD;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public String GetSprite() {
			return this.sprite;
		}
		public void SetSprite(String sprite) {
			this.sprite = sprite;
		}
		public int GetMainType() {
			return this.mainType;
		}
		public void SetMainType(int mainType) {
			this.mainType = mainType;
		}
		public int GetSubType() {
			return this.subType;
		}
		public void SetSubType(int subType) {
			this.subType = subType;
		}
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(String description) {
			this.description = description;
		}
		public int GetPower() {
			return this.power;
		}
		public void SetPower(int power) {
			this.power = power;
		}
		public Double GetAccuracy() {
			return this.accuracy;
		}
		public void SetAccuracy(Double accuracy) {
			this.accuracy = accuracy;
		}
		public int GetManaCost() {
			return this.manaCost;
		}
		public void SetManaCost(int manaCost) {
			this.manaCost = manaCost;
		}
		public StatusEffect GetNewStatusEffect() {
			return this.newStatusEffect;
		}
		public void SetNewStatusEffect(StatusEffect newStatusEffect) {
			this.newStatusEffect = newStatusEffect;
		}
		public Double GetStatusEffectChance() {
			return this.statusEffectChance;
		}
		public void SetStatusEffectChance(Double statusEffectChance) {
			this.statusEffectChance = statusEffectChance;
		}

		private Character character;

	}

}
