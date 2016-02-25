using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class NPC : AbstractPlayer
    {
        public override void SetBlock(BodyPart part = BodyPart.Head)
        {
            Random r1 = new Random();
            base.blockedPart = (BodyPart)r1.Next(5);
        }
    }
}
