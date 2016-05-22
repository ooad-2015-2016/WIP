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
        Battle Fight;

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
        }
        public void AddCharacter(Character Element)
        {
            Characters.Add(Element.GetID(), Element);
        }
        public Character FindCharacter(int ID)
        {
            Character Element = Characters[ID];
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
            Monster Element = Monsters[ID];
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
            Item Element = Items[ID];
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
            Map Element = Maps[ID];
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
            FunctionTile Element = FunctionTiles[ID];
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
            SpawnTile Element = SpawnTiles[ID];
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
            Skill Element = Skills[ID];
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
            StatusEffect Element = StatusEffects[ID];
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
            Modifiers Element = AllModifiers[ID];
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
            Shop Element = Shops[ID];
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
            NPC Element = NPCs[ID];
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
            AI Element = AIs[ID];
            return Element;
        }
        public void RemoveAI(int ID)
        {
            AIs.Remove(ID);
        }
    }

}
