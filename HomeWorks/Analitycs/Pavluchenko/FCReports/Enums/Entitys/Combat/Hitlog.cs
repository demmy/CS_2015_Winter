using Enums;

namespace FightClubReports.Entitys.Combat
{
    public class Hitlog
    {
        public int Id { get; set; }
        public PartOfBody Part { get; set; }
        bool IsSuccess { get; set; }
    }
}