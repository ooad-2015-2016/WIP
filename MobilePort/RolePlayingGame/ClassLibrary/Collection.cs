using System;
using System.Collections.Generic;

namespace Entity {
	public class Collection {
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
        int CurrentMapID = 0;
        Battle battle;
        String report;
        int option = 0;
        Random rand;

        public Collection() {
            Characters = new SortedDictionary<int, Character>();
            Monsters = new SortedDictionary<int, Monster>();
            Items = new SortedDictionary<int, Item>();
            Maps = new SortedDictionary<int, Map>();
            FunctionTiles = new SortedDictionary<int, FunctionTile>();
            SpawnTiles = new SortedDictionary<int, SpawnTile>();
            Skills = new SortedDictionary<int, Skill>();
            StatusEffects = new SortedDictionary<int, StatusEffect>();
            AllModifiers = new SortedDictionary<int, Modifiers>();
            Shops = new SortedDictionary<int, Shop>();
            NPCs = new SortedDictionary<int, NPC>();
            AIs = new SortedDictionary<int, AI>();
            rand = new Random();
        }
        public void AddCharacter(Character Element)
        {
            Characters.Add(Element.GetID(), Element);
        }
        public Character FindCharacter(int ID)
        {
            Character Element;
            if (Characters.ContainsKey(ID) != false)
                Element = Characters[ID];
            else Element = new Character();
            return Element;
        }
        public void RemoveCharacter(int ID)
        {
            Characters.Remove(ID);
        }
        public void AddMonster(Monster Element)
        {
            Monsters.Add(Element.GetID(), Element);
        }
        public Monster FindMonster(int ID)
        {
            Monster Element;
            if (Monsters.ContainsKey(ID) != false)
                Element = Monsters[ID];
            else Element = new Monster();
            return Element;
        }
        public void RemoveMonster(int ID)
        {
            Monsters.Remove(ID);
        }
        public void AddItem(Item Element)
        {
            Items.Add(Element.GetID(), Element);
        }
        public Item FindItem(int ID)
        {
            Item Element;
            if (Items.ContainsKey(ID) != false)
                Element = Items[ID];
            else Element = new Item();
            return Element;
        }
        public void RemoveItem(int ID)
        {
            Items.Remove(ID);
        }
        public void AddMap(Map Element)
        {
            Maps.Add(Element.GetID(), Element);
        }
        public Map FindMap(int ID)
        {
            Map Element;
            if (Maps.ContainsKey(ID) != false)
                Element = Maps[ID];
            else Element = new Map();
            return Element;
        }
        public void RemoveMap(int ID)
        {
            Maps.Remove(ID);
        }
        public void AddFunctionTile(FunctionTile Element)
        {
            FunctionTiles.Add(Element.GetID(), Element);
        }
        public FunctionTile FindFunctionTile(int ID)
        {
            FunctionTile Element;
            if (FunctionTiles.ContainsKey(ID) != false)
                Element = FunctionTiles[ID];
            else Element = new FunctionTile();
            return Element;
        }
        public void RemoveFunctionTile(int ID)
        {
            FunctionTiles.Remove(ID);
        }
        public void AddSpawnTile(SpawnTile Element)
        {
            SpawnTiles.Add(Element.GetID(), Element);
        }
        public SpawnTile FindSpawnTile(int ID)
        {
            SpawnTile Element;
            if (SpawnTiles.ContainsKey(ID) != false)
                Element = SpawnTiles[ID];
            else Element = new SpawnTile();
            return Element;
        }
        public void RemoveSpawnTile(int ID)
        {
            SpawnTiles.Remove(ID);
        }
        public void AddSkill(Skill Element)
        {
            Skills.Add(Element.GetID(), Element);
        }
        public Skill FindSkill(int ID)
        {
            Skill Element;
            if (Skills.ContainsKey(ID) != false)
                Element = Skills[ID];
            else Element = new Skill();
            return Element;
        }
        public void RemoveSkill(int ID)
        {
            Skills.Remove(ID);
        }
        public void AddStatusEffect(StatusEffect Element)
        {
            StatusEffects.Add(Element.GetID(), Element);
        }
        public StatusEffect FindStatusEffect(int ID)
        {
            StatusEffect Element;
            if (StatusEffects.ContainsKey(ID) != false)
                Element = StatusEffects[ID];
            else Element = new StatusEffect();
            return Element;
        }
        public void RemoveStatusEffect(int ID)
        {
            StatusEffects.Remove(ID);
        }
        public void AddModifiers(Modifiers Element)
        {
            AllModifiers.Add(Element.GetID(), Element);
        }
        public Modifiers FindModifiers(int ID)
        {
            Modifiers Element;
            if (AllModifiers.ContainsKey(ID) != false)
                Element = AllModifiers[ID];
            else Element = new Modifiers();
            return Element;
        }
        public void RemoveModifiers(int ID)
        {
            AllModifiers.Remove(ID);
        }
        public void AddShop(Shop Element)
        {
            Shops.Add(Element.GetID(), Element);
        }
        public Shop FindShop(int ID)
        {
            Shop Element;
            if (Shops.ContainsKey(ID) != false)
                Element = Shops[ID];
            else Element = new Shop();
            return Element;
        }
        public void RemoveShop(int ID)
        {
            Shops.Remove(ID);
        }
        public void AddNPC(NPC Element)
        {
            NPCs.Add(Element.GetID(), Element);
        }
        public NPC FindNPC(int ID)
        {
            NPC Element;
            if (NPCs.ContainsKey(ID) != false)
                Element = NPCs[ID];
            else Element = new NPC();
            return Element;
        }
        public void RemoveNPC(int ID)
        {
            Shops.Remove(ID);
        }
        public void AddAI(AI Element)
        {
            AIs.Add(Element.GetID(), Element);
        }
        public AI FindAI(int ID)
        {
            AI Element;
            if (AIs.ContainsKey(ID) != false)
                Element = AIs[ID];
            else Element = new AI();
            return Element;
        }
        public void RemoveAI(int ID)
        {
            AIs.Remove(ID);
        }
        public int GetCurrentMapID()
        {
            return CurrentMapID;
        }
        public void SetCurrentMapID(int ID)
        {
            CurrentMapID = ID;
        }
        public void SetBattle(Battle battle)
        {
            this.battle = battle;
        }
        public Battle GetBattle()
        {
            if (battle != null)
            {
                return battle;
            }
            return new Battle();
        }
        public void SetReport(String report)
        {
            this.report = report;
        }
        public String GetReport()
        {
            return report;
        }
        public void SetOption(int option)
        {
            this.option = option;
        }
        public int GetOption()
        {
            return option;
        }
        public Random GetRandom()
        {
            return rand;
        }
    }

}
