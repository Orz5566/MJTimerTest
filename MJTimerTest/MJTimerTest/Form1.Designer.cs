
namespace MJTimerTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.PostTimer = new System.Windows.Forms.Timer(this.components);
            this.userControl14 = new MJTimerTest.UserControl1();
            this.userControl13 = new MJTimerTest.UserControl1();
            this.userControl12 = new MJTimerTest.UserControl1();
            this.userControl11 = new MJTimerTest.UserControl1();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label1.Location = new System.Drawing.Point(20, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 24);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Standby";
            // 
            // PostTimer
            // 
            this.PostTimer.Interval = 1000;
            this.PostTimer.Tick += new System.EventHandler(this.PostTimer_Tick);
            // 
            // userControl14
            // 
            this.userControl14.ActiveMochiColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userControl14.ActiveTurnColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl14.GoalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl14.Location = new System.Drawing.Point(14, 102);
            this.userControl14.Margin = new System.Windows.Forms.Padding(5);
            this.userControl14.MaxCallSec = 3;
            this.userControl14.MaxMochiSec = 60;
            this.userControl14.MaxTurnSec = 6;
            this.userControl14.MinusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControl14.MochiSec = 60;
            this.userControl14.Name = "userControl14";
            this.userControl14.NoneColor = System.Drawing.Color.Gray;
            this.userControl14.PreTimerMS = 1000;
            this.userControl14.SecColor = System.Drawing.Color.White;
            this.userControl14.Selection = MJTimerTest.UserControl1.Choice.None;
            this.userControl14.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userControl14.Size = new System.Drawing.Size(412, 61);
            this.userControl14.Stat = MJTimerTest.UserControl1.状態.待機中;
            this.userControl14.TabIndex = 3;
            this.userControl14.TimeoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControl14.TurnSec = 6;
            this.userControl14.WaitingColor = System.Drawing.Color.Goldenrod;
            this.userControl14.ButtonPushed += new MJTimerTest.UserControl1.ButtonPushedEventHandler(this.UserControl1_ButtonPushed);
            this.userControl14.Paused += new MJTimerTest.UserControl1.PausedEventHandler(this.UserControl1_Paused);
            this.userControl14.Resumed += new MJTimerTest.UserControl1.ResumedEventHandler(this.UserControl1_Resumed);
            // 
            // userControl13
            // 
            this.userControl13.ActiveMochiColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userControl13.ActiveTurnColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl13.GoalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl13.Location = new System.Drawing.Point(254, 14);
            this.userControl13.Margin = new System.Windows.Forms.Padding(5);
            this.userControl13.MaxCallSec = 3;
            this.userControl13.MaxMochiSec = 60;
            this.userControl13.MaxTurnSec = 6;
            this.userControl13.MinusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControl13.MochiSec = 60;
            this.userControl13.Name = "userControl13";
            this.userControl13.NoneColor = System.Drawing.Color.Gray;
            this.userControl13.PreTimerMS = 1000;
            this.userControl13.SecColor = System.Drawing.Color.White;
            this.userControl13.Selection = MJTimerTest.UserControl1.Choice.None;
            this.userControl13.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userControl13.Size = new System.Drawing.Size(412, 61);
            this.userControl13.Stat = MJTimerTest.UserControl1.状態.待機中;
            this.userControl13.TabIndex = 3;
            this.userControl13.TimeoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControl13.TurnSec = 6;
            this.userControl13.WaitingColor = System.Drawing.Color.Goldenrod;
            this.userControl13.ButtonPushed += new MJTimerTest.UserControl1.ButtonPushedEventHandler(this.UserControl1_ButtonPushed);
            this.userControl13.Paused += new MJTimerTest.UserControl1.PausedEventHandler(this.UserControl1_Paused);
            this.userControl13.Resumed += new MJTimerTest.UserControl1.ResumedEventHandler(this.UserControl1_Resumed);
            // 
            // userControl12
            // 
            this.userControl12.ActiveMochiColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userControl12.ActiveTurnColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl12.GoalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl12.Location = new System.Drawing.Point(493, 102);
            this.userControl12.Margin = new System.Windows.Forms.Padding(5);
            this.userControl12.MaxCallSec = 3;
            this.userControl12.MaxMochiSec = 60;
            this.userControl12.MaxTurnSec = 6;
            this.userControl12.MinusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControl12.MochiSec = 60;
            this.userControl12.Name = "userControl12";
            this.userControl12.NoneColor = System.Drawing.Color.Gray;
            this.userControl12.PreTimerMS = 1000;
            this.userControl12.SecColor = System.Drawing.Color.White;
            this.userControl12.Selection = MJTimerTest.UserControl1.Choice.None;
            this.userControl12.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userControl12.Size = new System.Drawing.Size(412, 61);
            this.userControl12.Stat = MJTimerTest.UserControl1.状態.待機中;
            this.userControl12.TabIndex = 3;
            this.userControl12.TimeoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControl12.TurnSec = 6;
            this.userControl12.WaitingColor = System.Drawing.Color.Goldenrod;
            this.userControl12.ButtonPushed += new MJTimerTest.UserControl1.ButtonPushedEventHandler(this.UserControl1_ButtonPushed);
            this.userControl12.Paused += new MJTimerTest.UserControl1.PausedEventHandler(this.UserControl1_Paused);
            this.userControl12.Resumed += new MJTimerTest.UserControl1.ResumedEventHandler(this.UserControl1_Resumed);
            // 
            // userControl11
            // 
            this.userControl11.ActiveMochiColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userControl11.ActiveTurnColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl11.GoalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControl11.Location = new System.Drawing.Point(254, 194);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5);
            this.userControl11.MaxCallSec = 3;
            this.userControl11.MaxMochiSec = 60;
            this.userControl11.MaxTurnSec = 6;
            this.userControl11.MinusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControl11.MochiSec = 60;
            this.userControl11.Name = "userControl11";
            this.userControl11.NoneColor = System.Drawing.Color.Gray;
            this.userControl11.PreTimerMS = 1000;
            this.userControl11.SecColor = System.Drawing.Color.White;
            this.userControl11.Selection = MJTimerTest.UserControl1.Choice.None;
            this.userControl11.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userControl11.Size = new System.Drawing.Size(412, 61);
            this.userControl11.Stat = MJTimerTest.UserControl1.状態.待機中;
            this.userControl11.TabIndex = 3;
            this.userControl11.TimeoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControl11.TurnSec = 6;
            this.userControl11.WaitingColor = System.Drawing.Color.Goldenrod;
            this.userControl11.ButtonPushed += new MJTimerTest.UserControl1.ButtonPushedEventHandler(this.UserControl1_ButtonPushed);
            this.userControl11.Paused += new MJTimerTest.UserControl1.PausedEventHandler(this.UserControl1_Paused);
            this.userControl11.Resumed += new MJTimerTest.UserControl1.ResumedEventHandler(this.UserControl1_Resumed);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Gray;
            this.radioButton1.Location = new System.Drawing.Point(10, 10);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "親決め";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton1.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.Controls.Add(this.radioButton5);
            this.flowLayoutPanel1.Controls.Add(this.radioButton10);
            this.flowLayoutPanel1.Controls.Add(this.radioButton6);
            this.flowLayoutPanel1.Controls.Add(this.radioButton7);
            this.flowLayoutPanel1.Controls.Add(this.radioButton8);
            this.flowLayoutPanel1.Controls.Add(this.radioButton9);
            this.flowLayoutPanel1.Controls.Add(this.radioButton11);
            this.flowLayoutPanel1.Controls.Add(this.radioButton12);
            this.flowLayoutPanel1.Controls.Add(this.radioButton13);
            this.flowLayoutPanel1.Controls.Add(this.radioButton14);
            this.flowLayoutPanel1.Controls.Add(this.radioButton15);
            this.flowLayoutPanel1.Controls.Add(this.radioButton16);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 279);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(912, 189);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Gray;
            this.radioButton2.Location = new System.Drawing.Point(10, 54);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(219, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "配牌（ちょんちょんなし）";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton2.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Gray;
            this.radioButton3.Location = new System.Drawing.Point(10, 98);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 24);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "牌を取る";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton3.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Gray;
            this.radioButton4.Location = new System.Drawing.Point(10, 142);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(107, 24);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "牌を捨てる";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton4.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Gray;
            this.radioButton5.Location = new System.Drawing.Point(249, 10);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(187, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "吃／碰する搭子を晒す";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton5.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.ForeColor = System.Drawing.Color.Gray;
            this.radioButton10.Location = new System.Drawing.Point(249, 54);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(187, 24);
            this.radioButton10.TabIndex = 4;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "大明槓する刻子を晒す";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton10.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Gray;
            this.radioButton6.Location = new System.Drawing.Point(249, 98);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(123, 24);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "捨て牌を取る";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton6.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.Color.Gray;
            this.radioButton7.Location = new System.Drawing.Point(249, 142);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(123, 24);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "嶺上牌を取る";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton7.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.Color.Gray;
            this.radioButton8.Location = new System.Drawing.Point(456, 10);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(203, 24);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "加槓／暗槓する牌を晒す";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton8.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.ForeColor = System.Drawing.Color.Gray;
            this.radioButton9.Location = new System.Drawing.Point(456, 54);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(187, 24);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "花牌／抜きドラを晒す";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton9.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.ForeColor = System.Drawing.Color.Gray;
            this.radioButton11.Location = new System.Drawing.Point(456, 98);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(171, 24);
            this.radioButton11.TabIndex = 4;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "ツモ和了を精算する";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton11.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.ForeColor = System.Drawing.Color.Gray;
            this.radioButton12.Location = new System.Drawing.Point(456, 142);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(171, 24);
            this.radioButton12.TabIndex = 4;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "ロン和了を精算する";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton12.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.ForeColor = System.Drawing.Color.Gray;
            this.radioButton13.Location = new System.Drawing.Point(679, 10);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(171, 24);
            this.radioButton13.TabIndex = 4;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "搶槓和了を精算する";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton13.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.ForeColor = System.Drawing.Color.Gray;
            this.radioButton14.Location = new System.Drawing.Point(679, 54);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(91, 24);
            this.radioButton14.TabIndex = 4;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "対局中断";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton14.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.ForeColor = System.Drawing.Color.Gray;
            this.radioButton15.Location = new System.Drawing.Point(679, 98);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(187, 24);
            this.radioButton15.TabIndex = 4;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "最後の捨て牌から再開";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton15.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.ForeColor = System.Drawing.Color.Gray;
            this.radioButton16.Location = new System.Drawing.Point(679, 142);
            this.radioButton16.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(235, 24);
            this.radioButton16.TabIndex = 4;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "反則・ボタンミスタッチなど";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.Enter += new System.EventHandler(this.radioButton1_Enter);
            this.radioButton16.Leave += new System.EventHandler(this.radioButton1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 489);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        private UserControl1 userControl14;
        internal System.Windows.Forms.Timer PostTimer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
    }
}

