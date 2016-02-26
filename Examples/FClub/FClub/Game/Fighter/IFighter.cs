namespace FClub.Game.Fighter
{
    public delegate void FighterEventHandler(object sender, FighterEventArgs args);

    public enum Part {Head, Body, Legs}

    public interface IFighter
    {
        event FighterEventHandler WasBlocked;
        event FighterEventHandler WasDamaged;
        event FighterEventHandler WasKilled;

        int HP { get; }
        string Name { get; }
        //Part BlockedPart { get; protected set; }

        void GetHit(Part part);
        void SetBlock(Part part);
    }
}