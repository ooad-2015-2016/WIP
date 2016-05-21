using System;
using Windows.UI.Xaml.Controls;

namespace Entity {
	public class StatusEffect : Character  {
		private int iD;
		private String name;
		private Image sprite;
		private String description;
		private int value;
		private int duration;
		private bool beforeAttackPhase;

		public StatusEffect() {
			throw new System.Exception("Not implemented");
		}
		public override int GetID() {
			return this.iD;
		}
		public override void SetID(ref int iD) {
			this.iD = iD;
		}
		public override String GetName() {
			return this.name;
		}
		public override void SetName(ref String name) {
			this.name = name;
		}
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(ref String description) {
			this.description = description;
		}
		public int GetValue() {
			return this.value;
		}
		public void SetValue(ref int value) {
			this.value = value;
		}
		public int GetDuration() {
			return this.duration;
		}
		public void SetDuration(ref int duration) {
			this.duration = duration;
		}
		public bool GetBeforeAttackPhase() {
			return this.beforeAttackPhase;
		}
		public void SetBeforeAttackPhase(ref bool beforeAttackPhase) {
			this.beforeAttackPhase = beforeAttackPhase;
		}
		public String GetStatusEffectInfo() {
			throw new System.Exception("Not implemented");
		}
		public override Image GetSprite() {
			return this.sprite;
		}
		public void SetSprite(ref Image sprite) {
			this.sprite = sprite;
		}

	}

}
