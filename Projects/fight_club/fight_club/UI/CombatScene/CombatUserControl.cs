using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    public partial class CombatUserControl : BaseUserControl
    {
        public CombatScenePresenter presenter = null; 
        public BodyPart firstPlPunchChoosenPart;
        public BodyPart firstPlBlockChoosenPart;
        public BodyPart secondPlPunchChoosenPart;
        public BodyPart secondPlBlockChoosenPart;
        Player player1;

        public CombatUserControl()
        {
            InitializeComponent();
            //presenter = new CombatScenePresenter(this);
        }

        public CombatUserControl(object par1)
        {
            InitializeComponent();
            this.player1 = (Player)par1;
            presenter = new CombatScenePresenter(this , (AbstractPlayer)par1 , null);
        }

        public CombatUserControl(object par1 , object par2)
        {
            InitializeComponent();
            this.player1 = (Player)par1;
            presenter = new CombatScenePresenter(this , (AbstractPlayer)par1 , (AbstractPlayer)par2);
        }

        public void DrawPlayersInfo(string player1name, int player1hp, int player1maxhp, string player2name, int player2hp, int player2maxhp)
        {
            lbl_1st_name.Text = player1name;
            lbl_2nd_name.Text = player2name;
            prbar_1st_hp.Maximum = player1maxhp;
            if (player1hp >= 0)
            {
                prbar_1st_hp.Value = player1hp;
            }
            else
            {
                prbar_1st_hp.Value = 0;
            }
            prbar_2nd_hp.Maximum = player2maxhp;
            if (player2hp >= 0)
            {
                prbar_2nd_hp.Value = player2hp;
            }
            else
            {
                prbar_2nd_hp.Value = 0;
            }
            lbl_1st_hp.Text = player1hp + " / " + player1maxhp;
            lbl_2nd_hp.Text = player2hp + " / " + player2maxhp;
        }

        public void DrawTextLog(string[] str)
        {
            textlog.AppendText(str[0] + Environment.NewLine);
            textlog.AppendText(str[1] + Environment.NewLine);
            if (str[2] != "")
            {
                textlog.AppendText(str[2] + Environment.NewLine);
                MessageBox.Show(str[2]);
                if (presenter.gameType == GameType.PvP)
                {
                    MainForm.SecondPlayer = null;
                }
                SwitchScene(Scene.Menu , MainForm.playerRepository.Get(player1.Name));  // kostil
            }
            textlog.AppendText("----------------------------------------------------------------" + "\n");
        }


        private void CombatUserControl_Load(object sender, EventArgs e)
        {
            if (presenter.gameType == GameType.PvE)
            {
                pnl_2nd_player.Enabled = false;
            }
        }

        //  -------------------------------------------------------------------------


        #region Обработка заполнения выбора ударов
        public void Player1PunchClean(BodyPart part)
        {
            btn_1st_punch_head.UnMark();
            btn_1st_punch_body.UnMark();
            btn_1st_punch_feet.UnMark();
            btn_1st_punch_lefthand.UnMark();
            btn_1st_punch_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_1st_punch_head.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_1st_punch_body.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_1st_punch_feet.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_1st_punch_lefthand.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_1st_punch_righthand.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        public void Player1BlockClean(BodyPart part)
        {
            btn_1st_block_head.UnMark();
            btn_1st_block_body.UnMark();
            btn_1st_block_feet.UnMark();
            btn_1st_block_lefthand.UnMark();
            btn_1st_block_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_1st_block_head.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_1st_block_body.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_1st_block_feet.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_1st_block_lefthand.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_1st_block_righthand.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        public void Player2PunchClean(BodyPart part)
        {
            btn_2nd_punch_head.UnMark();
            btn_2nd_punch_body.UnMark();
            btn_2nd_punch_feet.UnMark();
            btn_2nd_punch_lefthand.UnMark();
            btn_2nd_punch_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_2nd_punch_head.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_2nd_punch_body.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_2nd_punch_feet.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_2nd_punch_lefthand.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_2nd_punch_righthand.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        public void Player2BlockClean(BodyPart part)
        {
            btn_2nd_block_head.UnMark();
            btn_2nd_block_body.UnMark();
            btn_2nd_block_feet.UnMark();
            btn_2nd_block_lefthand.UnMark();
            btn_2nd_block_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_2nd_block_head.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_2nd_block_body.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_2nd_block_feet.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_2nd_block_lefthand.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_2nd_block_righthand.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        #region HORROR(don't open!!!)
        private void button1_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.Head);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.Body);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.Feet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.LeftHand);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.RightHand);
        }

        private void btn_1st_block_head_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.Head);
        }

        private void btn_1st_block_body_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.Body);
        }

        private void btn_1st_block_feet_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.Feet);
        }

        private void btn_1st_block_lefthand_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.LeftHand);
        }

        private void btn_1st_block_righthand_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.RightHand);
        }

        private void btn_2nd_punch_head_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.Head);
        }

        private void btn_2nd_punch_body_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.Body);
        }

        private void btn_2nd_punch_feet_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.Feet);
        }

        private void btn_2nd_punch_lefthand_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.LeftHand);
        }

        private void btn_2nd_punch_righthand_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.RightHand);
        }

        private void btn_2nd_block_head_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.Head);
        }

        private void btn_2nd_block_body_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.Body);
        }

        private void btn_2nd_block_feet_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.Feet);
        }

        private void btn_2nd_block_lefthand_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.LeftHand);
        }

        private void btn_2nd_block_righthand_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.RightHand);
        }


        #endregion

        #endregion

        private void btn_1st_endturn_Click(object sender, EventArgs e)
        {
            btn_1st_endturn.Enabled = false;
            pnl_1st_block.Enabled = false;
            pnl_1st_punch.Enabled = false;
            EndTurn();
        }

        private void btn_2nd_endturn_Click(object sender, EventArgs e)
        {
            btn_2nd_endturn.Enabled = false;
            pnl_2nd_block.Enabled = false;
            pnl_2nd_punch.Enabled = false;
            EndTurn();
        }

        public void EndTurn()
        {
            if ((!btn_1st_endturn.Enabled) && (!btn_2nd_endturn.Enabled))
            {
                presenter.EndTurn((int)firstPlPunchChoosenPart, (int)firstPlBlockChoosenPart, (int)secondPlPunchChoosenPart, (int)secondPlBlockChoosenPart);

                btn_1st_endturn.Enabled = true;
                btn_2nd_endturn.Enabled = true;
                pnl_1st_block.Enabled = true;
                pnl_1st_punch.Enabled = true;
                pnl_2nd_block.Enabled = true;
                pnl_2nd_punch.Enabled = true;
            }
        }
    }
}
