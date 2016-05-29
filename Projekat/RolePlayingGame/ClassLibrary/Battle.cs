using System;
using System.Collections.Generic;

namespace Entity {
	public class Battle {
		private List<Character> playerParty;
		private List<Monster> monsterParty;
		private int target;
		private bool targetFriendly;
		private int damageDealt;
        private bool battleEnd = false;

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
            Monster real = new Monster();
            real.HardCopy(monster);
            monsterParty.Add(real);
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
        public bool DidBattleEnd()
        {
            return battleEnd;
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
        public void UseSkill(Skill skill, int target, int caster = 0)
        {
            // ako je target = 0, skill pogadja player-a
            // a ako je 1, 2, 3 pogadja odgovarajuceg neprijatelja
            // caster = 0 player koristi skill
            // caster = 1, 2, 3 odgovarajuci neprijatelj koristi skill
            damageDealt = skill.GetPower();
            if (target == 0)
            {
                monsterParty[caster - 1].LoseMana(skill.GetManaCost());
                playerParty[0].LoseHealth(damageDealt);
                if (playerParty[0].GetHealth() <= 0) playerParty[0].SetID(0);
            }
            else
            {
                playerParty[0].LoseMana(skill.GetManaCost());
                monsterParty[target - 1].LoseHealth(damageDealt);
                if (monsterParty[target - 1].GetHealth() <= 0) monsterParty[target - 1].SetID(0);
            }
        }
		public void ControlBattle() {
			throw new System.Exception("Not implemented");
		}
		public void BeginTurn() {
			throw new System.Exception("Not implemented");
		}
        public String EndTurn(Skill skill, int target) {
            String report;
            if (playerParty[0].GetMana() >= skill.GetManaCost())
            {
                UseSkill(skill, target);
                Monster monster = monsterParty[target - 1];
                report = playerParty[0].GetName() + " used " + skill.GetName() 
                    + " on " + monster.GetName() + " and did " + damageDealt + " damage.\n";
                if(monster.GetID() == 0)
                {
                    int exp = monster.GetEXPReward(), gold = monster.GetGoldReward();
                    playerParty[0].IncreaseEXP(exp);
                    playerParty[0].IncreaseGold(gold);
                    report += "You killed " + monster.GetName() + " and recieved "
                        + exp + " EXP and " + gold + " gold\n";
                }
                report += "\n";
                report = MonsterTurn(report);
            }
            else
            {
                throw new System.ArgumentException("You dont have enough mana", "original");
            }
            return report;
        }
        public void ChooseTarget() {
			throw new System.Exception("Not implemented");
		}
        public Skill AIDecide(int monsterPosition, Random x)
        {
            List<Skill> skills = new List<Skill>(), allskills = monsterParty[monsterPosition].GetSkills();
            int n = allskills.Count;
            for (int i = 0; i < n; i++)
            {
                if(monsterParty[monsterPosition].GetMana() >= allskills[i].GetManaCost())
                {
                    skills.Add(allskills[i]);
                }
            }
            int m = skills.Count;
            int skillposition = x.Next(0, m);
            return skills[skillposition];
        }
		public String MonsterTurn(String report) {
            Random x = new Random();
            int n = monsterParty.Count, m = 0;
            for(int i = 0; i < n; i++)
            {
                if(monsterParty[i].GetID() != 0)
                {
                    Skill skill = AIDecide(i, x);
                    UseSkill(skill, 0, i + 1);
                    report += monsterParty[i].GetName() + " used " + skill.GetName()
                    + " on " + playerParty[0].GetName() + " and did " + damageDealt + " damage.\n";
                    m++;
                }
            }
            if (m == 0) battleEnd = true;
            return report;        
		}
		public void Render() {
			throw new System.Exception("Not implemented");
		}

	}

}
