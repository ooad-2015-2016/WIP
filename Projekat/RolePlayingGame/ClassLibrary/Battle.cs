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
            playerParty = new List<Character>();
            monsterParty = new List<Monster>();
		}
        public List<Character> GetPlayerParty()
        {
            return playerParty;
        }
        public void AddPlayer(Character player)
        {
            playerParty.Add(player);
        }
        public void RemovePlayer(Character player)
        {
            playerParty.Remove(player);
        }
        public List<Monster> GetMonsterParty()
        {
            return monsterParty;
        }
        public void AddMonster(Monster monster)
        {
            monsterParty.Add(monster);
        }
        public void RemoveMonster(Monster monster)
        {
            monsterParty.Remove(monster);
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
