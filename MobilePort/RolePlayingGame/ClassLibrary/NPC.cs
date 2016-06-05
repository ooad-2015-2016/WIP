using System;
namespace Entity {
	public class NPC {
        private int ID = 0;

        public int GetID()
        {
            return this.ID;
        }
        public void SetID(ref int iD)
        {
            this.ID = iD;
        }
        
        public NPC() { }
    }

}
