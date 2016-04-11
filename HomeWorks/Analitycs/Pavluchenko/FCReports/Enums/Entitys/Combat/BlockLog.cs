using Enums;
namespace FightClubReports.Entitys.Combat
{
    public class BlockLog
    {
        public int Id { get; set; }
        public PartOfBody Part { get; set; }
        public bool isSuccess { get; set; }
    }
}