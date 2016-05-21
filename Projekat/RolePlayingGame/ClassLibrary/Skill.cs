using System;
using Windows.UI.Xaml.Controls;

namespace Entity {
	public class Skill {
		private int iD;
		private String name;
		private Image sprite;
		private int mainType;
		private int subType;
		private String description;
		private int power;
		private Double accuracy;
		private int manaCost;
		private StatusEffect newStatusEffect;
		private Double statusEffectChance;

		public Skill() {
			throw new System.Exception("Not implemented");
		}
		public void GetSkillInfo() {
			throw new System.Exception("Not implemented");
		}
		public void Operation() {
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
		public Image GetSprite() {
			return this.sprite;
		}
		public void SetSprite(ref Image sprite) {
			this.sprite = sprite;
		}
		public int GetMainType() {
			return this.mainType;
		}
		public void SetMainType(ref int mainType) {
			this.mainType = mainType;
		}
		public int GetSubType() {
			return this.subType;
		}
		public void SetSubType(ref int subType) {
			this.subType = subType;
		}
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(ref String description) {
			this.description = description;
		}
		public int GetPower() {
			return this.power;
		}
		public void SetPower(ref int power) {
			this.power = power;
		}
		public Double GetAccuracy() {
			return this.accuracy;
		}
		public void SetAccuracy(ref Double accuracy) {
			this.accuracy = accuracy;
		}
		public int GetManaCost() {
			return this.manaCost;
		}
		public void SetManaCost(ref int manaCost) {
			this.manaCost = manaCost;
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

		private Character character;

	}

}
