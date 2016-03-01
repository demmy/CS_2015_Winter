/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 25.02.2016
 * Time: 23:13
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of BattlePresenter.
    /// </summary>
    public class BattlePresenter
    {
        GameControl Battle;
        BattleUserControl View;
        public BattlePresenter(BattleUserControl view)
        {
            View = view;
            Battle = new GameControl(ProgramData.PlayerName);
            View.BattleFirstPlayerName = Battle.Human.Name;
            View.BattleFirstPlayerHpMax = Battle.Human.MaxHp;
            View.BattleSecondPlayerName = Battle.Npc.Name;
            View.BattleSecondPlayerHpMax = Battle.Npc.MaxHp;
            RefreshHealthProgressBars();
            View.CreateRadioButtons();
        }

        public void NextRound(BodyPart attackPoint, BodyPart blockPoint)
        {
            AddToLog("---==================---");
            ParseInputLog(Battle.MakeRound((BodyPart)attackPoint, (BodyPart)blockPoint));
            RefreshHealthProgressBars();
        }
        
        protected void ParseInputLog(List<Message> Log)
        {
            foreach (Message nextLine in Log)
            {
                Message temp = nextLine;
                switch (temp.Action)
                {
                    case GameControl.RoundAction.attacked:
                        AddToLog(String.Format("{0} : {1} влепил удар и нанес {2} урон {3} HP!", DateTime.Now.ToString("HH:mm:ss"), temp.Attacker, temp.Defender, temp.Damage));
                        break;
                    case GameControl.RoundAction.blocked:
                        AddToLog(String.Format("{0} : {1} старался, но {2} заблокировал удар.", DateTime.Now.ToString("HH:mm:ss"), temp.Attacker, temp.Defender, temp.Damage));
                        break;
                    case GameControl.RoundAction.dead:
                        AddToLog(String.Format("{0} : {1} пошатнулся и упал... Скорая в документах зафиксировала время {0}...", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        break;
                    case GameControl.RoundAction.draw:
                        AddToLog(String.Format("{0} : Редкий случай! Ничья!!!", DateTime.Now.ToString("HH:mm:ss")));
                        View.RadioButtonsVisible = false;
                        View.NewBattleButtonVisible = true;
                        View.BattleResultMessage = "All Dead!";
                        break;
                    case GameControl.RoundAction.win:
                        AddToLog(String.Format("{0} : И-и-и-и... победил {1}!!!", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        IncreaseWinsInTable(temp.Name);
                        View.RadioButtonsVisible = false;
                        View.NewBattleButtonVisible = true;
                        View.BattleResultMessage = temp.Name + " Win!";
                        break;
                    default:
                        AddToLog(String.Format("{0} : Это что-то новенькое! Комментатор не в курсе об этом действии...", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        break;
                        
                }
            }
        }
        
        public void AddToLog(string text)
        {
            View.AddBattleLog = text + Environment.NewLine;
        }
        
        void IncreaseWinsInTable(string name)
        {
            if (CheckFileExist(ProgramData.RatingFilePath))
            {
                bool newPlayer = false;
                foreach (var record in ProgramData.Rating)
                {
                    if (record.Key == name)
                    {
                        newPlayer = false;
                    }
                    else
                    {
                        newPlayer = true;
                    }
                }
                if (!newPlayer)
                {
                    ProgramData.Rating[name] += 1;
                }
                else
                {
                    ProgramData.Rating.Add(name, 1);
                }
            }
            else
            {
                using (File.Create(ProgramData.RatingFilePath))
                {
                }
                ProgramData.Rating = new Dictionary<string, int>();
                ProgramData.Rating.Add(name, 1);
            }
            SaveRecordsTableToFile();
        }
        
        
        bool CheckFileExist(string file)
        {
            if (!File.Exists(file))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void SaveRecordsTableToFile()
        {
            using (StreamWriter sw = new StreamWriter(ProgramData.RatingFilePath))
            {
                foreach (var line in ProgramData.Rating)
                {
                    sw.WriteLine("{0};{1}", line.Key, line.Value);
                }
            }
        }
        
        public void RefreshHealthProgressBars()
        {
            if (Battle.Human.Hp >= 0)
            {
                View.BattleFirstPlayerHP = Battle.Human.Hp;
            }
            else
            {
                View.BattleFirstPlayerHP = 0;
            }
            
            if (Battle.Npc.Hp >= 0)
            {
                View.BattleSecondPlayerHP = Battle.Npc.Hp;
            }
            else
            {
                View.BattleSecondPlayerHP = 0;
            }
        }

    }
}
