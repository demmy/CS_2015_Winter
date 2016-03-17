namespace FightClub.Game.Interfaces
{
    enum Part { Head = 1, Body, Legs }
    public delegate void GameForceHandler(object sender, GameEventArgs e);
    interface IPlayerModel
    {
        int Hp { get;  }
        string Log { get; set; }
        int Damage { get; set; }
        string Name { get; set; }
        int Hit { get; set; }
        int Set { get; }
        int GetHit(Part part);
        int SetBlock(Part part);
        int Recovery(bool h);
        int BonusHp();
        void ImproveDmg();
        event GameForceHandler Wound;
        event GameForceHandler Block;
        event GameForceHandler Death;
    }
}
