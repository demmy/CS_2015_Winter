using FightClubReports.Entitys.Combat;

namespace FightClubReports
{
    public class RoundLog
    {   
        public int Id { get; set; }
        public ActionLog Player1 { get; set; }
        public ActionLog Player2 { get; set; }
    }
}