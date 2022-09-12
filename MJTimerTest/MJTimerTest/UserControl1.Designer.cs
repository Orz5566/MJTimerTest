
namespace MJTimerTest
{
    partial class UserControl1
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.MochiLabel = new System.Windows.Forms.Label();
            this.GoalButton = new System.Windows.Forms.Button();
            this.CallButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.PreTimer = new System.Windows.Forms.Timer(this.components);
            this.PushTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TurnLabel
            // 
            this.TurnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TurnLabel.ForeColor = System.Drawing.Color.White;
            this.TurnLabel.Location = new System.Drawing.Point(313, 0);
            this.TurnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(99, 20);
            this.TurnLabel.TabIndex = 6;
            this.TurnLabel.Text = "10";
            this.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MochiLabel
            // 
            this.MochiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MochiLabel.ForeColor = System.Drawing.Color.White;
            this.MochiLabel.Location = new System.Drawing.Point(0, 0);
            this.MochiLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MochiLabel.Name = "MochiLabel";
            this.MochiLabel.Size = new System.Drawing.Size(313, 20);
            this.MochiLabel.TabIndex = 7;
            this.MochiLabel.Text = "60";
            this.MochiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GoalButton
            // 
            this.GoalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GoalButton.Location = new System.Drawing.Point(195, 3);
            this.GoalButton.Name = "GoalButton";
            this.GoalButton.Size = new System.Drawing.Size(60, 35);
            this.GoalButton.TabIndex = 2;
            this.GoalButton.Tag = "4";
            this.GoalButton.Text = "Win";
            this.GoalButton.UseVisualStyleBackColor = true;
            this.GoalButton.Click += new System.EventHandler(this.Button_Click);
            this.GoalButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EndButton_MouseDown);
            // 
            // CallButton
            // 
            this.CallButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CallButton.Location = new System.Drawing.Point(109, 3);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(60, 35);
            this.CallButton.TabIndex = 3;
            this.CallButton.Tag = "3";
            this.CallButton.Text = "Call";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.Button_Click);
            this.CallButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EndButton_MouseDown);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(3, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 35);
            this.OKButton.TabIndex = 4;
            this.OKButton.Tag = "1";
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.Button_Click);
            this.OKButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EndButton_MouseDown);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(0, 23);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(150, 35);
            this.EndButton.TabIndex = 5;
            this.EndButton.Tag = "2";
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.Button_Click);
            this.EndButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EndButton_MouseDown);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // PreTimer
            // 
            this.PreTimer.Interval = 1000;
            this.PreTimer.Tick += new System.EventHandler(this.PTimer_Tick);
            // 
            // PushTimer
            // 
            this.PushTimer.Interval = 1000;
            this.PushTimer.Tick += new System.EventHandler(this.PushTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Controls.Add(this.CallButton);
            this.panel1.Controls.Add(this.GoalButton);
            this.panel1.Location = new System.Drawing.Point(153, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 41);
            this.panel1.TabIndex = 8;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.MochiLabel);
            this.Controls.Add(this.EndButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(412, 61);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label TurnLabel;
        internal System.Windows.Forms.Label MochiLabel;
        internal System.Windows.Forms.Button GoalButton;
        internal System.Windows.Forms.Button CallButton;
        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.Button EndButton;
        internal System.Windows.Forms.Timer MainTimer;
        internal System.Windows.Forms.Timer PreTimer;
        internal System.Windows.Forms.Timer PushTimer;
        private System.Windows.Forms.Panel panel1;
    }
}
