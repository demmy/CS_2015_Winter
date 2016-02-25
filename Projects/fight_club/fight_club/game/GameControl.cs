using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class GameControl
    {
        public AbstractPlayer player1;
        public AbstractPlayer player2;

        string Blockstring = "";
        string PunchString = "";

        Random rnd = new Random();
        public delegate void DeathEvent(object sender, AbstractPlayer e);
        public event DeathEvent GameOver;

        public GameControl()
        {
            //player1 = new Player(2 , "Jack" , 3 , 3 , 2);
            //player2 = new Player(2, "Ted", 2, 2, 4); 
            if (MainForm.SecondPlayer == null)
            {
                Player player = MainForm.FirstPlayer;
                player1 = new Player(player.Level, player.Name, player.Straight, player.Agility, player.Stamina, player.Exp);
                player2 = new NPC();
            }
            else
            {
                Player plr1 = MainForm.FirstPlayer;
                Player plr2 = MainForm.SecondPlayer;
                player1 = new Player(plr1.Level, plr1.Name, plr1.Straight, plr1.Agility, plr1.Stamina, plr1.Exp);
                player2 = new Player(plr2.Level, plr2.Name, plr2.Straight, plr2.Agility, plr2.Stamina, plr2.Exp);
            }
        }

        public void NewGame(AbstractPlayer player)
        {
            //player1 = player;
            player1 = new Player(player.Level, player.Name, player.Straight, player.Agility, player.Stamina, player.Exp);
            player2 = new NPC();  
        }

        public void NewGame(AbstractPlayer player1 , AbstractPlayer player2)
        {
            player1 = new Player(player1.Level, player1.Name, player1.Straight, player1.Agility, player1.Stamina, player1.Exp);
            player2 = new Player(player2.Level, player2.Name, player2.Straight, player2.Agility, player2.Stamina, player2.Exp);
            //this.player1 = player1;
            //this.player2 = player2;
        }

        public string[] Turn(BodyPart player1punch , BodyPart player1block , BodyPart player2punch , BodyPart player2block)
        {
            if (player2 is NPC)   // remove to bots behaviour
            {
                player2punch = (BodyPart)rnd.Next(5);
            }


            string[] returnedString = {"" , "" , ""};
            string firstturn = "";
            string secondturn = "";
            string deathstring = "";
            int d1, d2;


            player1.Block += BlockHandler;
            player2.Block += BlockHandler;
            player1.Wound += WoundHandler;
            player2.Wound += WoundHandler;
            player1.Death += DeathHandler;
            player2.Death += DeathHandler;


            player1.SetBlock(player1block);
            player2.SetBlock(player2block);

            // Бьет первый игрок
            d1 = player2.GetHit(player1punch, new FightPapams(player1.Straight, player1.Agility));
            if (d1 != 0)
            {
                firstturn = player1.Name + " punch " + player2.Name  + " on " + d1 + " on " + PunchString;   //как вызывать ревкцию события прямо тут?
            }
            else
            {
                firstturn = player2.Name + " blocked punch of " + player1.Name + " on " + Blockstring;       //как вызывать ревкцию события прямо тут?
            }

            // Бьет второй игрок
            d2 = player1.GetHit(player2punch, new FightPapams(player2.Straight, player2.Agility));
            if (d2 != 0)
            {
                secondturn = player2.Name + " punch " + player1.Name + " on " + d2 + " on " + PunchString;   //как вызывать ревкцию события прямо тут?
            }
            else
            {
                secondturn = player1.Name + " blocked punch " + player2.Name + " on " + Blockstring;         //как вызывать ревкцию события прямо тут?
            }


            if ((player1.Hp <= 0) && (player2.Hp > 0))
            {
                player2.AddExp((int)(player1.MaxHp * ((double)(player1.Straight + player1.Stamina + player1.Agility) / (double)(player2.Straight + player2.Stamina + player2.Agility))));
                if (!(player2 is NPC))
                {
                    MainForm.playerRepository.Add((Player)player2);
                }                
                deathstring = "Player " + player2.Name +  " win!";
            }
            if ((player2.Hp <= 0) && (player1.Hp > 0))
            {
                //int addingexp = 0;
                //addingexp = (int)(player2.MaxHp * ((double)(player2.Straight + player2.Stamina + player2.Agility) / (double)(player1.Straight + player1.Stamina + player1.Agility)));
                player1.AddExp((int)(player2.MaxHp * ((double)(player2.Straight + player2.Stamina + player2.Agility) / (double)(player1.Straight + player1.Stamina + player1.Agility))));
                MainForm.playerRepository.Add((Player)player1);
                deathstring = "Player " + player1.Name + " win!";
            }
            if ((player1.Hp <= 0) && (player2.Hp <= 0))
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



        public void BlockHandler(object sender , BodyPart e)
        {
            Blockstring = e.ToString();
        }

        public void WoundHandler(object sender, BodyPart e)
        {
            PunchString = e.ToString();
        }

        public void DeathHandler(object sender, BodyPart e)  //
        {
            //GameOver.Invoke(sender, player1);
        }
    }
}
