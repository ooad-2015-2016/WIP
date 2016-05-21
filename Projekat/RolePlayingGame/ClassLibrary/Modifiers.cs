using System;
using Windows.UI.Xaml.Controls;

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
		public Skill GetDescription() {
			throw new System.Exception("Not implemented");
		}
		public void SetDescription(ref Skill description) {
			throw new System.Exception("Not implemented");
		}
		public int GetValue() {
			return this.value;
		}
		public void SetValue(ref int value) {
			this.value = value;
		}
		public Bool GetAddOrMultiply() {
			return this.addOrMultiply;
		}
		public void SetAddOrMultiply(ref Bool addOrMultiply) {
			this.addOrMultiply = addOrMultiply;
		}
		public Bool GetTargetsSelf() {
			return this.targetsSelf;
		}
		public void SetTargetsSelf(ref Bool targetsSelf) {
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
