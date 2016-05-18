using System;
namespace Entity {
	public class Equipable : Item  {
		private List<Modifier> modifiers;
		private Image sprite;
		private int mainType;
		private int subType;
		private int power;

		public override int GetID() {
			throw new System.Exception("Not implemented");
		}
		public override void SetID(ref int iD) {
			throw new System.Exception("Not implemented");
		}
		public override String GetName() {
			throw new System.Exception("Not implemented");
		}
		public override void SetName(ref String name) {
			throw new System.Exception("Not implemented");
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
		public override String GetDescription() {
			throw new System.Exception("Not implemented");
		}
		public override void SetDescription(ref String description) {
			throw new System.Exception("Not implemented");
		}
		public int GetPower() {
			return this.power;
		}
		public void SetPower(ref int power) {
			this.power = power;
		}
		public Modifiers GetModifiers() {
			throw new System.Exception("Not implemented");
		}
		public void SetModifiers(ref Modifiers modifiers) {
			throw new System.Exception("Not implemented");
		}

		private EquipmentSlots equipmentSlots;

	}

}
