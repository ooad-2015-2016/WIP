using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Entity {
	public class Character {
		private int ID;
		private String name;
		private int HeroClass;
		private Image sprite;
		private int positionX;
		private int positionY;
		private int LVL;
		private long EXP;
        private int gold;
		private int health;
		private int maxHealth;
		private int mana;
		private int maxMana;
		private Atributes atributes;
		private Inventory inventory;
		private EquipmentSlots equipment;
		private List<Skill> skills;
		private List<StatusEffect> statusEffects;
        private int ChangedLVL = 0;

		public Character()
        {
            ID = 1; name = "";  LVL = 1;
            sprite = new Image();
            maxHealth = 100; health = maxHealth;
            maxMana = 50; mana = maxMana;
            skills = new List<Skill>();
            statusEffects = new List<StatusEffect>();
            atributes = new Atributes();
            inventory = new Inventory();
        }
		public void LevelUp(ref string report) {
            LVL++; ChangedLVL--;
            maxHealth += (int)(maxHealth / 2);
            maxMana += (int)(maxMana / 4);
            health = maxHealth;
            mana = maxMana;
            report = "Your maximum health has increased to " + maxHealth + " HP"
                + "\nYour maximum mana has increased to " + maxMana + " MP"
                + "\nYour health and mana has been restored.";
            int SP = GetAtributePoints(), atribute;
            Random x = new Random();
            int str = 0, vit = 0, ag = 0, inte = 0, will = 0, lck = 0; 
            while (SP > 0)
            {
                atribute = x.Next(1, 6);
                switch(atribute)
                {
                    case 1:
                        atributes.IncreaseStrength();
                        str++;
                        break;
                    case 2:
                        atributes.IncreaseVitality();
                        vit++;
                        break;
                    case 3:
                        atributes.IncreaseAgility();
                        ag++;
                        break;
                    case 4:
                        atributes.IncreaseIntelligence();
                        inte++;
                        break;
                    case 5:
                        atributes.IncreaseWillpower();
                        will++;
                        break;
                    default:
                        atributes.IncreaseLuck();
                        lck++;
                        break;
                }
                SP--;
            }
            if (str > 0) report += "\nYour Strength has increased by " + str;
            if (vit > 0) report += "\nYour Vitality has increased by " + vit;
            if (ag > 0) report += "\nYour Agility has increased by " + ag;
            if (inte > 0) report += "\nYour Intelligence has increased by " + inte;
            if (will > 0) report += "\nYour Willpower has increased by " + will;
            if (lck > 0) report += "\nYour Luck has increased by " + lck;
        }
		public void IncreaseHealth(int x) {
            health += x;
            if (health > maxHealth) health = maxHealth;
        }
		public void LoseHealth(int x) {
            health -= x;
            if (health < 0) health = 0;
        }
		public void IncreaseMana(int x) {
            mana += x;
            if (mana > maxMana) mana = maxMana;
        }
		public void LoseMana(int x) {
            mana -= x;
            if (mana < 0) mana = 0;
        }
        public void IncreaseEXP(int x)
        {
            EXP += x;
            while (EXP >= GetMaxEXP())
            {
                EXP -= GetMaxEXP();
                ChangedLVL++;
            }
        }
        public void IncreaseGold(int x)
        {
            gold += x;
        }
        public Atributes GetAtributes() {
			return this.atributes;
		}
		public void SetAtributes(Atributes atributes) {
			this.atributes = atributes;
		}
		public void Equip(Item item) {
            Equipable equip = (Equipable)item;
            if(equip.GetMainType() == 1)
            {
                equipment.SetPrimary(equip);
            }
            else if (equip.GetMainType() == 2)
            {
                equipment.SetSecondary(equip);
            }
            else
            {
                equipment.SetArmor(equip);
            }

        }
		public void Unequip(ref object item) {
			throw new System.Exception("Not implemented");
		}
		public void AddSkill(Skill skill) {
            skills.Add(skill);
		}
		public void RemoveSkill(Skill skill) {
            skills.Remove(skill);
		}
		public String GetSkillsInfo() {
			throw new System.Exception("Not implemented");
		}
		public void AddStatusEffect(ref object statusEffect) {
			throw new System.Exception("Not implemented");
		}
		public void RemoveStatusEffect(ref object statusEffect) {
			throw new System.Exception("Not implemented");
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
		public int GetClass() {
			return this.HeroClass;
		}
		public void SetHeroClass(int HeroClass) {
			this.HeroClass = HeroClass;
		}
		public Image GetSprite() {
			return this.sprite;
		}
		public void SetSprite(string text) {
            text = "ms-appx:" + text;
            Uri imageUri = new Uri(text, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            sprite.Source = imageBitmap;
		}
		public int GetPositionX() {
			return this.positionX;
		}
		public void SetPositionX(int positionX) {
			this.positionX = positionX;
		}
		public int GetPositionY() {
			return this.positionY;
		}
		public void SetPositionY(int positionY) {
			this.positionY = positionY;
		}
		public int GetLVL() {
			return this.LVL;
		}
		public void SetLVL(int lVL) {
			this.LVL = lVL;
		}
		public long GetEXP() {
			return this.EXP;
		}
		public void SetEXP(long eXP) {
			this.EXP = eXP;
		}
        public int GetGold()
        {
            return this.gold;
        }
        public void SetGold(int gold)
        {
            this.gold = gold;
        }
        public long GetMaxEXP()
        {
            long max = (long)(50 * Math.Pow((LVL+ChangedLVL), 3) 
                - 300 * Math.Pow((LVL + ChangedLVL), 2) + 750 * (LVL + ChangedLVL) - 400);
            return max;
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
		public void SetMana(int mana) {
			this.mana = mana;
		}
		public int GetMaxMana() {
			return this.maxMana;
		}
		public void SetMaxMana(int maxMana) {
			this.maxMana = maxMana;
		}
		public Inventory GetInventory() {
			return this.inventory;
		}
		public void SetInventory(Inventory inventory) {
			this.inventory = inventory;
		}
		public EquipmentSlots GetEquipment() {
			return this.equipment;
		}
		public void SetEquipment(EquipmentSlots equipment) {
			this.equipment = equipment;
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
        public int GetChangedLVL()
        {
            return ChangedLVL;
        }
        public void SetChangedLVL(int lvl)
        {
            this.ChangedLVL = lvl;
        }
        public int GetAtributePoints()
        {
            int x = (int)Math.Floor(2.403 * Math.Pow(LVL, 0.2532) - 1.443);
            return x;
        }
        //public void UseItem(Item item)
        //{
        //    inventory.RemoveItem(item);
        //}
    }

}
