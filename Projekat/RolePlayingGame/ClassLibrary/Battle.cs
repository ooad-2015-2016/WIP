using System;
using System.Collections.Generic;

namespace Entity {
	public class Battle {
		private List<Character> playerParty;
		private List<Monster> monsterParty;
		private int target;
		private bool targetFriendly;
		private int damageDealt;

		public Battle() {
			throw new System.Exception("Not implemented");
		}
		public void<Character> GetPlayerParty() {
			throw new System.Exception("Not implemented");
		}
		public void SetPlayerParty(ref object<Character> playerParty) {
			throw new System.Exception("Not implemented");
		}
		public void<Monster> GetMonsterParty() {
			throw new System.Exception("Not implemented");
		}
		public void SetMonsterParty(ref object<Monster> monsterParty) {
			throw new System.Exception("Not implemented");
		}
		public int GetTarget() {
			return this.target;
		}
		public void SetTarget(ref int target) {
			this.target = target;
		}
		public bool GetTargetFriendly() {
			return this.targetFriendly;
		}
		public void SetTargetFriendly(ref bool targetFriendly) {
			this.targetFriendly = targetFriendly;
		}
		public int GetDamageDealt() {
			return this.damageDealt;
		}
		public void SetDamageDealt(ref int damageDealt) {
			this.damageDealt = damageDealt;
		}
		public Double GetTotalHitChance() {
			throw new System.Exception("Not implemented");
		}
		public Double GetTotalDodgeChance() {
			throw new System.Exception("Not implemented");
		}
		public Double GetTotalCritChance() {
			throw new System.Exception("Not implemented");
		}
		public Double GetTotalCritMultiplyer() {
			throw new System.Exception("Not implemented");
		}
		public void ControlBattle() {
			throw new System.Exception("Not implemented");
		}
		public void BeginTurn() {
			throw new System.Exception("Not implemented");
		}
		public void EndTurn() {
			throw new System.Exception("Not implemented");
		}
		public void UseSkill() {
			throw new System.Exception("Not implemented");
		}
		public void ChooseTarget() {
			throw new System.Exception("Not implemented");
		}
		public void MonsterTurn() {
			throw new System.Exception("Not implemented");
		}
		public void Render() {
			throw new System.Exception("Not implemented");
		}

	}

}
