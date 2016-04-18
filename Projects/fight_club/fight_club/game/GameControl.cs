using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class GameControl
    {
        #region Fields
        public AbstractPlayer player1;
        public AbstractPlayer player2;

        string Blockstring = "";
        string PunchString = "";

        Random rnd = new Random();
        #endregion

        #region Events
        //public delegate void DeathEvent(object sender, AbstractPlayer e);
        //public event DeathEvent GameOver;
        #endregion

        #region Constructors
        public GameControl(AbstractPlayer player1, AbstractPlayer player2)
        {
            if (player2 == null)
            {
                this.player1 = new Player(player1.Level, player1.Name, player1.Straight, player1.Agility, player1.Stamina, player1.Exp);
                this.player2 = new NPC(player1.Straight + player1.Agility + player1.Stamina);  // special Bot
            }
            else
            {
                this.player1 = new Player(player1.Level, player1.Name, player1.Straight, player1.Agility, player1.Stamina, player1.Exp);
                this.player2 = new Player(player2.Level, player2.Name, player2.Straight, player2.Agility, player2.Stamina, player2.Exp);
            }
        }
        #endregion

        #region Methods
        // упростить п*дец
        public string[] Turn(BodyPart player1punch, BodyPart player1block, BodyPart player2punch, BodyPart player2block)
        {
            string[] returnedString = { "", "", "" };
            string firstturn = "";
            string secondturn = "";
            string deathstring = "";
            int damage1, damage2;

            player1.Block += BlockHandler;
            player2.Block += BlockHandler;
            player1.Wound += WoundHandler;
            player2.Wound += WoundHandler;

            // round preparation
            player1.SetBlock(player1block);
            player2.SetBlock(player2block);

            if (player2 is NPC)  // bots behavior
            {
                (player2 as NPC).SetHit();
                player2punch = (player2 as NPC).targetPart;
            }

            // Бьет первый игрок
            damage1 = player2.GetHit(player1punch, new FightPapams(player1.Straight, player1.Agility));
            if (damage1 != 0)
            {
                firstturn = player1.Name + " punch " + player2.Name + " on " + damage1 + " on " + PunchString;
            }
            else
            {
                firstturn = player2.Name + " blocked punch of " + player1.Name + " on " + Blockstring;
            }

            // Бьет второй игрок
            damage2 = player1.GetHit(player2punch, new FightPapams(player2.Straight, player2.Agility));
            if (damage2 != 0)
            {
                secondturn = player2.Name + " punch " + player1.Name + " on " + damage2 + " on " + PunchString;
            }
            else
            {
                secondturn = player1.Name + " blocked punch " + player2.Name + " on " + Blockstring;
            }


            // Проверка смерти игрока и награда победителя
            if ((player1.Hp <= 0) && (player2.Hp > 0))  // player2 win
            {
                player2.AddExp((int)(player1.MaxHp * ((double)(player1.Straight + player1.Stamina + player1.Agility) / (double)(player2.Straight + player2.Stamina + player2.Agility))));
                if (!(player2 is NPC))
                {
                    MainForm.playerRepository.Add(new Player(player2.Level, player2.Name, player2.Straight, player2.Agility, player2.Stamina, player2.Exp));
                    MainForm.playerRepository.Save();
                }
                deathstring = "Player " + player2.Name + " win!";
            }
            if ((player2.Hp <= 0) && (player1.Hp > 0))  // player1 win
            {
                player1.AddExp((int)(player2.MaxHp * ((double)(player2.Straight + player2.Stamina + player2.Agility) / (double)(player1.Straight + player1.Stamina + player1.Agility))));

                MainForm.playerRepository.Add(new Player(player1.Level, player1.Name, player1.Straight, player1.Agility, player1.Stamina, player1.Exp));
                MainForm.playerRepository.Save();
                deathstring = "Player " + player1.Name + " win!";
            }
            if ((player1.Hp <= 0) && (player2.Hp <= 0))  // draw
            {
                deathstring = "Draw";
            }

            returnedString[0] = firstturn;
            returnedString[1] = secondturn;
            if (deathstring != "")
            {
                returnedString[2] = deathstring;
            }
            return returnedString;
        }

        public void BlockHandler(object sender, BodyPart e)
        {
            Blockstring = e.ToString();
        }

        public void WoundHandler(object sender, BodyPart e)
        {
            PunchString = e.ToString();
        } 
        #endregion
    }
}
