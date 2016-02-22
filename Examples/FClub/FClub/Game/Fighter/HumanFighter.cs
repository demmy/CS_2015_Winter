namespace FClub.Game.Fighter
{
    internal class HumanFighter : BaseFighter
    {
        public override void GetHit(Part part)
        {
            if (BlockedPart == part)
            {
                // hit blocked
                Blocked();
            }
            else
            {
                //get damage
            }
        }





        public override void SetBlock(Part part)
        {
            BlockedPart = part;
        }
    }
}