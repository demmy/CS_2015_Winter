using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class NPC : AbstractPlayer , IPlayer
    {
        #region Fields
        public BodyPart targetPart = BodyPart.Head; 
        #endregion

        #region Constructors
        public NPC()
        {
            level = 1;
            name = "Bot";
            straight = 3;
            agility = 2;
            stamina = 3;
            hp = CalculateHp();
            exp = 0;
        }

        public NPC(int statsCount)
        {
            level = 1;
            name = "Bot";
            straight = 1;
            agility = 1;
            stamina = 1;
            //int startStats = 5;  // remove it to static class "GameOptions"
            Random rand = new Random();

            for (int i = 0; i < statsCount - 3; i++)  // -3 to evade 0 stats
            {
                switch (rand.Next(3))
                {
                    case 0:
                        {
                            straight++;
                            break;
                        }
                    case 1:
                        {
                            agility++;
                            break;
                        }
                    case 2:
                        {
                            stamina++;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            hp = CalculateHp();
            //exp = 0;
        }
        #endregion

        #region Methods
        public override void SetBlock(BodyPart part = BodyPart.Head)
        {
            Random r1 = new Random();
            base.blockedPart = (BodyPart)r1.Next(5);
        } 

        public void SetHit()
        {
            targetPart = (BodyPart)(new Random().Next(5));
        }
        #endregion
    }
}
