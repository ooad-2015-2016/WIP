using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Entity {
	public class Monster {
		private int ID = 0;
		private String name;
        private String description;
		private Image sprite;
		private int LVL = 1;
		private int health = 30;
		private int maxHealth = 30;
		private int mana = 20;
		private int maxMana = 20;
		private Atributes atributes;
		private List<Skill> skills;
		private List<StatusEffect> statusEffects;
        private AI ai;

        public Monster() {
            sprite  = new Image();
            skills = new List<Skill>();
            statusEffects = new List<StatusEffect>();
        }
        public int GetID() {
			return this.ID;
		}
		public void SetID(int ID) {
			this.ID = ID;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
        public String GetDescription()
        {
            return this.description;
        }
        public void SetDescription(String description)
        {
            this.description = description;
        }
        public Image GetSprite() {
			return this.sprite;
		}
		public void SetSprite(String text) {
            text = "ms-appx:" + text;
            Uri imageUri = new Uri(text, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            sprite.Source = imageBitmap;
		}
		public int GetLVL() {
			return this.LVL;
		}
		public void SetLVL(int LVL) {
			this.LVL = LVL;
		}
		public int GetHealth() {
			return this.health;
		}
		public void SetHealth(int health) {
			this.health = health;
		}
		public int GetMaxHealth() {
			return this.maxHealth;
		}
		public void SetMaxHealth(int maxHealth) {
			this.maxHealth = maxHealth;
		}
		public int GetMana() {
			return this.mana;
		}
		public void SetMana(ref int mana) {
			this.mana = mana;
		}
		public int GetMaxMana() {
			return this.maxMana;
		}
		public void SetMaxMana(ref int maxMana) {
			this.maxMana = maxMana;
		}
		public Atributes GetAtributes() {
			return this.atributes;
		}
		public void SetAtributes(ref Atributes atributes) {
			this.atributes = atributes;
		}
        public List<Skill> GetSkills()
        {
            return skills;
        }
        public void SetSkills(List<Skill> skills)
        {
            this.skills = skills;
        }
        public List<StatusEffect> GetStatusEffects()
        {
            return statusEffects;
        }
        public void SetStatusEffects(List<StatusEffect> statusEffects)
        {
            this.statusEffects = statusEffects;
        }
        public AI GetAI()
        {
            return ai;
        }
        public void SetAI(AI ai)
        {
            this.ai = ai;
        }

        public void LoseHealth(int health)
        {
            this.health -= health;
        }
        public void LoseMana(int mana)
        {
            this.mana -= mana;
        }
        public void AddSkill(Skill skill)
        {
            skills.Add(skill);
        }
        public void RemoveSkill(Skill skill)
        {
            skills.Remove(skill);
        }
        public void HardCopy(Monster monster)
        {
            ID = monster.GetID();
            name = monster.GetName();
            description = monster.GetDescription();
            sprite = monster.GetSprite();
            LVL = monster.GetLVL();
            health = monster.GetHealth();
            maxHealth = monster.GetMaxHealth();
            mana = monster.GetMana();
            maxMana = monster.GetMaxMana();
            atributes = monster.GetAtributes();
            skills = monster.GetSkills();
            statusEffects = monster.GetStatusEffects();
            ai = monster.GetAI();
        }
        public Skill AIDecide() {
			throw new System.Exception("Not implemented");
		}
		public Monster(ref object parameter) {
			throw new System.Exception("Not implemented");
		}

	}

}
