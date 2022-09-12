using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static MJTimerTest.UserControl1;

namespace MJTimerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private 状態 _currentPhase = 状態.待機中;
        private List<UserControl1> ctrlList = new List<UserControl1>();
        private List<UserControl1> decidedCtrls = new List<UserControl1>();
        private int rotation = 1;
        private int callCtrl = 0;
        private int goalCtrl = 0;
        private int maxCallerNum;

        public 状態 CurrentPhase
        {
            get
            {
                return _currentPhase;
            }
            set
            {
                _currentPhase = value;
                Label1.Text = _currentPhase.ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ctrlList.Add(userControl11);
            ctrlList.Add(userControl12);
            ctrlList.Add(userControl13);
            ctrlList.Add(userControl14);
            maxCallerNum = ctrlList.Count - 1;
            CurrentPhase = 状態.待機中;
        }

        private void UserControl1_ButtonPushed(UserControl1 sender, Choice selection)
        {
            switch (CurrentPhase)
            {
                case 状態.待機中:
                    {
                        if (selection == Choice.OK)
                        {
                            // start
                            sender.Stat = 状態.手番進行中;
                            CurrentPhase = 状態.手番進行中;
                        }

                        break;
                    }

                case 状態.手番進行中:
                    {
                        if (sender.Stat == 状態.手番進行中)
                        {
                            if (selection == Choice.Goal)
                            {
                                // self-goal
                                SetStat(sender, 状態.和了宣言, 状態.待機中);
                                CurrentPhase = 状態.和了宣言;
                            }
                            else if (selection == Choice.Call)
                            {
                                // in-turn call
                                SetStat(sender, 状態.他家選択待ち, 状態.搶槓選択中);
                                CurrentPhase = 状態.搶槓選択中;
                            }
                            else if (selection == Choice.End)
                            {
                                // end turn -> waiting phase
                                SetStat(sender, 状態.他家選択待ち, 状態.鳴き選択中);
                                CurrentPhase = 状態.鳴き選択中;
                            }
                        }

                        break;
                    }

                case 状態.鳴き選択中:
                case 状態.搶槓選択中:
                    {
                        // waiting for decisions
                        if ((sender.Stat == 状態.鳴き選択中 || sender.Stat == 状態.搶槓選択中) && !decidedCtrls.Contains(sender))
                            decidedCtrls.Add(sender);
                        if (decidedCtrls.Count >= maxCallerNum)
                        {
                            if (!PostTimer.Enabled)
                                PostTimer.Start();
                        }

                        break;
                    }

                case 状態.和了宣言:
                    {
                        if (sender.Stat == 状態.和了宣言 && selection == Choice.End)
                        {
                            sender.Stat = 状態.他家選択待ち;
                            if (!StatusExists(状態.和了宣言))
                            {
                                // all paid
                                SetStat(sender, 状態.待機中, 状態.待機中);
                                CurrentPhase = 状態.待機中;
                                ResetAllSec();
                            }
                        }

                        break;
                    }
            }
        }

        private UserControl1 NextOf(UserControl1 ctrl, int num = 1)
        {
            int i = ctrlList.IndexOf(ctrl) + rotation * num;
            return ctrlList[i % ctrlList.Count];
        }

        private void ResetCallParam()
        {
            callCtrl = 0;
            goalCtrl = 0;
            decidedCtrls.Clear();
            foreach (UserControl1 ctrl in ctrlList)
                ctrl.Selection = Choice.None;
        }

        private bool StatusExists(状態 stat)
        {
            foreach (UserControl1 ctrl in ctrlList)
            {
                if (ctrl.Stat == stat)
                    return true;
            }
            return false;
        }

        private void PostTimer_Tick(object sender, EventArgs e)
        {
            // After last one made decision for 1 sec
            PostTimer.Stop();
            foreach (UserControl1 ctrl in decidedCtrls)
            {
                if (ctrl.Selection == Choice.Call)
                    callCtrl += 1;
                else if (ctrl.Selection == Choice.Goal)
                    goalCtrl += 1;
            }

            if (goalCtrl > 0)
            {
                // Goal suspend
                SetGoalStat();
                CurrentPhase = 状態.和了宣言;
            }
            else if (callCtrl > 0)
            {
                // Move to furthest caller
                FurthestCallerTurn();
                CurrentPhase = 状態.手番進行中;
            }
            else
            {
                if (CurrentPhase == 状態.鳴き選択中)
                    // no call, move to next one
                    NextTurn();
                else if (CurrentPhase == 状態.搶槓選択中)
                    ContinueTurn();
                CurrentPhase = 状態.手番進行中;
            }
            ResetCallParam();
        }

        private UserControl1 GetValidCaller(UserControl1 current, UserControl1 caller = null, int iteration = 0)
        {
            iteration += 1;
            if (iteration > ctrlList.Count)
                return caller;
            else if (current.Stat == 状態.鳴き選択中 && current.Selection == Choice.Call)
                caller = current;
            return GetValidCaller(NextOf(current), caller, iteration);
        }

        private void SetStat(UserControl1 sender, 状態 stat, 状態 otherStat)
        {
            foreach (UserControl1 ctrl in ctrlList)
            {
                if (ctrl.Equals(sender))
                    ctrl.Stat = stat;
                else
                    ctrl.Stat = otherStat;
            }
        }

        private void NextTurn()
        {
            foreach (UserControl1 ctrl in ctrlList)
            {
                if (ctrl.Stat == 状態.他家選択待ち)
                {
                    NextOf(ctrl).Stat = 状態.手番進行中;
                    break;
                }
            }
            foreach (UserControl1 ctrl in ctrlList)
            {
                if (ctrl.Stat != 状態.手番進行中)
                    ctrl.Stat = 状態.待機中;
            }
        }

        private void ContinueTurn()
        {
            foreach (UserControl1 ctrl in ctrlList)
            {
                if (ctrl.Stat == 状態.他家選択待ち)
                    ctrl.Stat = 状態.手番進行中;
                else
                    ctrl.Stat = 状態.待機中;
            }
        }

        private void FurthestCallerTurn()
        {
            foreach (UserControl1 ctrl in ctrlList)
            {
                if (ctrl.Stat == 状態.他家選択待ち)
                {
                    UserControl1 validCaller = GetValidCaller(ctrl);
                    foreach (UserControl1 c in ctrlList)
                    {
                        if (c.Equals(validCaller))
                            c.Stat = 状態.手番進行中;
                        else
                            c.Stat = 状態.待機中;
                    }
                    break;
                }
            }
        }

        private void SetGoalStat()
        {
            foreach (UserControl1 ctrl in ctrlList)
            {
                if ((ctrl.Stat == 状態.鳴き選択中 || ctrl.Stat == 状態.搶槓選択中) && ctrl.Selection == Choice.Goal)
                    ctrl.Stat = 状態.和了宣言;
                else
                    ctrl.Stat = 状態.待機中;
            }
        }

        private void ResetAllSec()
        {
            foreach (UserControl1 ctrl in ctrlList)
            {
                ctrl.ResetSec();
            }
        }

        private void UserControl1_Paused(UserControl1 sender)
        {
            SetStat(sender, 状態.対局中断, 状態.対局中断);
            CurrentPhase = 状態.対局中断;
        }

        private void UserControl1_Resumed(UserControl1 sender)
        {
            SetStat(sender, 状態.他家選択待ち, 状態.鳴き選択中);
            CurrentPhase = 状態.鳴き選択中;
        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            rb.ForeColor = Color.FromArgb(192, 0, 0);
        }

        private void radioButton1_Leave(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            rb.ForeColor = Color.Gray;
            rb.Checked = false;
        }
    }
}
