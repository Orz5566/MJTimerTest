using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJTimerTest
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public enum 状態
        {
            待機中,
            手番進行中,
            他家選択待ち,
            鳴き選択中,
            搶槓選択中,
            和了宣言,
            対局中断
        }

        public enum Choice
        {
            None,
            OK,
            End,
            Call,
            Goal
        }

        private 状態 _stat = 状態.待機中;
        private Choice _selection;
        private int _maxMochiSec = 60;
        private int _maxTurnSec = 6;
        private int _maxCallSec = 3;
        private int _mochiSec = 60;
        private int _turnSec = 6;
        private Button _BtnGoingToPush;
        private List<Button> _PressedBtns = new List<Button>();
        private int[] _CountInPressing = new int[(int)Choice.Goal + 1];

        public event ButtonPushedEventHandler ButtonPushed;

        public delegate void ButtonPushedEventHandler(UserControl1 sender, Choice selection);

        public event PausedEventHandler Paused;

        public delegate void PausedEventHandler(UserControl1 sender);

        public event ResumedEventHandler Resumed;

        public delegate void ResumedEventHandler(UserControl1 sender);

        public 状態 Stat
        {
            get
            {
                return _stat;
            }
            set
            {
                _stat = value;
                if (value == 状態.手番進行中)
                {
                    TurnSec = MaxTurnSec;
                    TurnLabel.Text = TurnSec.ToString();
                    PreTimer.Start();
                }
                else if (value == 状態.鳴き選択中 || value == 状態.搶槓選択中)
                {
                    TurnSec = MaxCallSec;
                    TurnLabel.Text = TurnSec.ToString();
                    PreTimer.Start();
                }
                else
                    TurnLabel.Text = "";
                UpdateLabelBar();
                SetAvailableButtons();
            }
        }

        public Choice Selection
        {
            get
            {
                return _selection;
            }
            set
            {
                _selection = value;
                if (Stat == 状態.鳴き選択中 || Stat == 状態.搶槓選択中)
                {
                    if (_selection != Choice.End)
                    {
                        OKButton.ForeColor = value == Choice.OK ? SelectionColor : Color.Black;
                        CallButton.ForeColor = value == Choice.Call ? SelectionColor : Color.Black;
                        GoalButton.ForeColor = value == Choice.Goal ? SelectionColor : Color.Black;
                    }
                }
                else
                {
                    OKButton.ForeColor = Color.Black;
                    CallButton.ForeColor = Color.Black;
                    GoalButton.ForeColor = Color.Black;
                }
            }
        }

        public int MochiSec
        {
            get
            {
                return _mochiSec;
            }
            set
            {
                _mochiSec = value;
                MochiLabel.Text = value.ToString();
                UpdateLabelBar();
            }
        }

        public int TurnSec
        {
            get
            {
                return _turnSec;
            }
            set
            {
                _turnSec = value;
                if (Stat == 状態.手番進行中 || Stat == 状態.鳴き選択中 || Stat == 状態.搶槓選択中)
                    TurnLabel.Text = value.ToString();
                else
                    TurnLabel.Text = "";
                UpdateLabelBar();
            }
        }

        public int MaxMochiSec
        {
            get
            {
                return _maxMochiSec;
            }
            set
            {
                _maxMochiSec = value;
                UpdateLabelBar();
            }
        }

        public int MaxTurnSec
        {
            get
            {
                return _maxTurnSec;
            }
            set
            {
                _maxTurnSec = value;
                UpdateLabelBar();
            }
        }

        public int MaxCallSec
        {
            get
            {
                return _maxCallSec;
            }
            set
            {
                _maxCallSec = value;
                UpdateLabelBar();
            }
        }

        public int PreTimerMS
        {
            get
            {
                return PreTimer.Interval;
            }
            set
            {
                PreTimer.Interval = value;
            }
        }

        public List<Button> PressedBtns
        {
            get
            {
                return _PressedBtns;
            }
        }

        //public int WrongCallPenalty { get; set; } = 5;  // useless

        public Color NoneColor { get; set; } = Color.Gray;
        public Color ActiveMochiColor { get; set; } = Color.FromArgb(0, 192, 0);
        public Color ActiveTurnColor { get; set; } = Color.FromArgb(128, 128, 255);
        public Color WaitingColor { get; set; } = Color.Goldenrod;
        public Color GoalColor { get; set; } = Color.FromArgb(255, 128, 255);
        public Color TimeoutColor { get; set; } = Color.FromArgb(255, 64, 64);
        public Color SecColor { get; set; } = Color.White;
        public Color MinusColor { get; set; } = Color.FromArgb(255, 192, 192);
        public Color SelectionColor { get; set; } = Color.FromArgb(192, 64, 0);

        private void UpdateLabelBar()
        {
            int totalSec = MaxMochiSec + MaxTurnSec;
            MainTimer.Stop();
            if (totalSec == 0)
                return;
            MochiLabel.ForeColor = MochiSec < 0 ? MinusColor : SecColor;
            MochiLabel.Width = Width * MaxMochiSec / totalSec;
            TurnLabel.Width = Width - MochiLabel.Width;
            TurnLabel.Left = Width - TurnLabel.Width;
            switch (_stat)
            {
                case 状態.待機中:
                    {
                        MochiLabel.BackColor = NoneColor;
                        TurnLabel.BackColor = NoneColor;
                        break;
                    }

                case 状態.手番進行中:
                case 状態.鳴き選択中:
                case 状態.搶槓選択中:
                case 状態.対局中断:
                    {
                        if (PreTimer.Enabled)
                        {
                            MochiLabel.BackColor = _stat == 状態.手番進行中 ? ActiveMochiColor : WaitingColor;
                            TurnLabel.BackColor = _stat == 状態.手番進行中 ? ActiveMochiColor : WaitingColor;
                        }
                        else
                        {
                            MochiLabel.BackColor = MochiSec < 0 ? TimeoutColor : ActiveMochiColor;
                            TurnLabel.BackColor = _stat == 状態.鳴き選択中 || _stat == 状態.搶槓選択中 ? WaitingColor : ActiveTurnColor;
                            if (MochiSec >= 0)
                                MochiLabel.Width = Width * MochiSec / totalSec;
                            TurnLabel.Width = Width * TurnSec / totalSec;
                            if (_stat == 状態.対局中断)
                            {
                                MochiLabel.BackColor = NoneColor;
                                TurnLabel.BackColor = NoneColor;
                            }
                            else
                                MainTimer.Start();
                        }

                        break;
                    }

                case 状態.他家選択待ち:
                    {
                        MochiLabel.BackColor = WaitingColor;
                        TurnLabel.BackColor = WaitingColor;
                        break;
                    }

                case 状態.和了宣言:
                    {
                        MochiLabel.BackColor = GoalColor;
                        TurnLabel.BackColor = GoalColor;
                        break;
                    }
            }
        }

        private void SetAvailableButtons()
        {
            switch (Stat)
            {
                case 状態.待機中:
                    {
                        //OKButton.Enabled = true;
                        //EndButton.Enabled = false;
                        CallButton.Enabled = false;
                        GoalButton.Enabled = false;
                        break;
                    }

                case 状態.手番進行中:
                    {
                        //OKButton.Enabled = false;
                        //EndButton.Enabled = true;
                        CallButton.Enabled = true;
                        GoalButton.Enabled = true; // for self-goal
                        break;
                    }

                case 状態.他家選択待ち:
                    {
                        //OKButton.Enabled = false;
                        //EndButton.Enabled = false;
                        CallButton.Enabled = false;
                        GoalButton.Enabled = false;
                        break;
                    }

                case 状態.鳴き選択中:
                    {
                        //OKButton.Enabled = true;
                        //EndButton.Enabled = false;
                        CallButton.Enabled = true;
                        GoalButton.Enabled = true;
                        break;
                    }

                case 状態.搶槓選択中:
                    {
                        //OKButton.Enabled = true;
                        //EndButton.Enabled = false;
                        CallButton.Enabled = false;
                        GoalButton.Enabled = true; // for robbing
                        break;
                    }

                case 状態.和了宣言:
                    {
                        //OKButton.Enabled = false;
                        //EndButton.Enabled = true;
                        CallButton.Enabled = false;
                        GoalButton.Enabled = false;
                        break;
                    }

                case 状態.対局中断:
                    {
                        //OKButton.Enabled = true;
                        //EndButton.Enabled = true;
                        CallButton.Enabled = true;
                        GoalButton.Enabled = true;
                        break;
                    }
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (TurnSec > 0)
                TurnSec -= 1;
            else
                MochiSec -= 1;
        }

        private void PTimer_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            UpdateLabelBar();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tagNo = Convert.ToInt32(btn.Tag);
            // when short-push
            if (PushTimer.Enabled)
            {
                PushTimer.Stop();
                if (Stat == 状態.対局中断)
                {
                    _CountInPressing[tagNo] += 1;
                    if (_PressedBtns.Contains(EndButton))
                    {
                        if (_CountInPressing[(int)Choice.OK] == 3)
                        {
                            // resume command
                            Stat = 状態.他家選択待ち;
                            Resumed?.Invoke(this);
                        }
                    }
                    else
                    {
                        _CountInPressing[tagNo] -= 1;
                        // adjust mochi sec in pause phase
                        if (tagNo == (int)Choice.Call)
                            MochiSec -= 1;
                        else if (tagNo == (int)Choice.Goal)
                            MochiSec += 1;
                    }
                }
                else if (_PressedBtns.Count == 0)
                {
                    // normal push, no pressing button
                    Selection = (Choice)tagNo;
                    // timer shouldn't stop when active one pushes ok
                    if (Stat != 状態.手番進行中 || Selection != Choice.OK)
                        MainTimer.Stop();
                    ButtonPushed?.Invoke(this, Selection);
                }
                else
                {
                    // any button pressed
                    _CountInPressing[tagNo] += 1;
                    if (_PressedBtns.Contains(OKButton) && _CountInPressing[(int)Choice.End] == 3)
                    {
                        Stat = 状態.対局中断;
                        Paused?.Invoke(this);
                    }
                }
                SetBtnPressed(_BtnGoingToPush, false);
            }

            // sound effect
            try
            {
                var player = new SoundPlayer("click.wav");
                player.Play();
            }
            catch (Exception)
            {
                SystemSounds.Question.Play();
            }
        }

        public void ResetSec()
        {
            TurnSec = MaxTurnSec;
            MochiSec = MaxMochiSec;
        }

        private void SetBtnPressed(Button btn, bool pressed = true)
        {
            if (pressed)
            {
                // 長押し状態にする（Windowsサンプルとしての苦肉の策）
                btn.FlatStyle = FlatStyle.Flat;
                _PressedBtns.Add(btn);
            }
            else
            {
                // 長押し解除
                btn.FlatStyle = FlatStyle.Standard;
                _PressedBtns.Remove(btn);
                if (_PressedBtns.Count == 0)
                {
                    // clear in-pressing counter
                    for (int i = 0; i < _CountInPressing.Length; i++)
                    {
                        _CountInPressing[i] = 0;
                    }
                }
            }
            _BtnGoingToPush = null;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            ResetSec();
        }

        private void EndButton_MouseDown(object sender, MouseEventArgs e)
        {
            PushTimer.Start();
            _BtnGoingToPush = (Button)sender;
        }

        private void PushTimer_Tick(object sender, EventArgs e)
        {
            PushTimer.Stop();
            SetBtnPressed(_BtnGoingToPush);
        }
    }
}
