namespace FClub.Game.Fighter
{
    abstract class BaseFighter : IFighter
    {
        public BaseFighter(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public BaseFighter()
        {

        }

        public event FighterEventHandler WasBlocked;

        public event FighterEventHandler WasDamaged;

        public event FighterEventHandler WasKilled;

        protected void Blocked()
        {
            if (WasBlocked != null)
            {
                WasBlocked(this, new FighterEventArgs() { Name = this.Name, HP = this.HP});
            }
        }

        int hp = 0;
        public int HP
        {
            get { return hp; }
        }

        string name = string.Empty;
        public string Name
        {
            get { return name; }
        }

        Part part = Part.Head;
        public Part BlockedPart
        {
            get { return part; }
            protected set { part = value; }
        }

        public abstract void GetHit(Part part);


        public abstract void SetBlock(Part part);

    }
}