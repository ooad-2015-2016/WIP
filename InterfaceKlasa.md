#Interface Klasa

Sadrzaj
========

* [Sadržaj](#sadrzaj)
* [Collection](#collection)
  * [Atributi](#atributi)
  * [Metode](#metode)
* [Monster](#collection)
  * [Atributi](#atributi)
  * [Metode](#metode)


Collection
==========

Atributi
--------

Služi za pohranjivanje svih instanci klase koje će se koristiti u projektu.

        SortedDictionary<int, Character> Characters;
        SortedDictionary<int, Monster> Monsters;
        SortedDictionary<int, Item> Items;
        SortedDictionary<int, Map> Maps;
        SortedDictionary<int, FunctionTile> FunctionTiles;
        SortedDictionary<int, SpawnTile> SpawnTiles;
        SortedDictionary<int, Skill> Skills;
        SortedDictionary<int, StatusEffect> StatusEffects;
        SortedDictionary<int, Modifiers> AllModifiers;
        SortedDictionary<int, Shop> Shops;
        SortedDictionary<int, NPC> NPCs;
        SortedDictionary<int, AI> AIs;
        Battle Fight;

Metode
------

Sadrži Add, Find i Remove metode za pojedinačne skupove klasa.

        public void AddCharacter(Character Element)
        public Character FindCharacter(int ID)
        public void RemoveCharacter(int ID)
        public void AddMonster(Monster Element)
        public Monster FindMonster(int ID)
        public void RemoveMonster(int ID)
        public void AddItem(Item Element)
        public Item FindItem(int ID)
        public void RemoveItem(int ID)
        public void AddMap(Map Element)
        public Map FindMap(int ID)
        public void RemoveMap(int ID)
        public void AddFunctionTile(FunctionTile Element)
        public FunctionTile FindFunctionTile(int ID)
        public void RemoveFunctionTile(int ID)
        public void AddSpawnTile(SpawnTile Element)
        public SpawnTile FindSpawnTile(int ID)
        public void RemoveSpawnTile(int ID)
        public void AddSkill(Skill Element)
        public Skill FindSkill(int ID)
        public void RemoveSkill(int ID)
        public void AddStatusEffect(StatusEffect Element)
        public StatusEffect FindStatusEffect(int ID)
        public void RemoveStatusEffect(int ID)
        public void AddModifiers(Modifiers Element)
        public Modifiers FindModifiers(int ID)
        public void RemoveModifiers(int ID)
        public void AddShop(Shop Element)
        public Shop FindShop(int ID)
        public void RemoveShop(int ID)
        public void AddNPC(NPC Element)
        public NPC FindNPC(int ID)
        public void RemoveNPC(int ID)
        public void AddAI(AI Element)
        public AI FindAI(int ID)
        public void RemoveAI(int ID)
        private AI think;

Monster
=======

Atributi
--------

private int ID;
		private String name;
		private Image sprite;
		private int LVL;
		private int health;
		private int maxHealth;
		private int mana;
		private int maxMana;
		private Atributes atributes;
		private List<Skill> skills;
		private List<StatusEffect> statusEffects;

Metode
------

public int GetID()
		public void SetID(ref int ID)
		public String GetName()
		public void SetName(ref String name)
		public Image GetSprite()
		public void SetSprite(ref Image sprite)
		public int GetLVL()
		public void SetLVL(ref int LVL)
		public int GetHealth()
		public void SetHealth(ref int health)
		public int GetMaxHealth()
		public void SetMaxHealth(ref int maxHealth)
		public int GetMana()
		public void SetMana(ref int mana)
		public int GetMaxMana()
		public void SetMaxMana(ref int maxMana)
		public Atributes GetAtributes()
		public void SetAtributes(ref Atributes atributes)
		//public void<Skill> GetSkills()
		//public void SetSkills(ref object<Skill> skills)
		//public void<StatusEffect> GetStatusEffects()
		//public void SetStatusEffects(ref object<StatusEffect> statusEffects) 
		public Monster()
		public Skill AIDecide()
		public Monster(ref object parameter)