
namespace pomodoro_timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.percentCompleteLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sessionLengthLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pomodoroBtn = new System.Windows.Forms.Button();
            this.shortBreakBtn = new System.Windows.Forms.Button();
            this.longBreakBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetBtn
            // 
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetBtn.Location = new System.Drawing.Point(242, 3);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(237, 60);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(0, 0);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 50);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(482, 433);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.AutoSize = true;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.Location = new System.Drawing.Point(3, 3);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(237, 60);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resetBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 367);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 66);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(482, 29);
            this.progressBar1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time Remaining:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Session Length:";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.Location = new System.Drawing.Point(135, 32);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(17, 20);
            this.timeRemainingLabel.TabIndex = 13;
            this.timeRemainingLabel.Text = "0";
            this.timeRemainingLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // percentCompleteLabel
            // 
            this.percentCompleteLabel.AutoSize = true;
            this.percentCompleteLabel.Location = new System.Drawing.Point(135, 64);
            this.percentCompleteLabel.Name = "percentCompleteLabel";
            this.percentCompleteLabel.Size = new System.Drawing.Size(29, 20);
            this.percentCompleteLabel.TabIndex = 9;
            this.percentCompleteLabel.Text = "0%";
            this.percentCompleteLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Percent Complete:";
            // 
            // sessionLengthLabel
            // 
            this.sessionLengthLabel.AutoSize = true;
            this.sessionLengthLabel.Location = new System.Drawing.Point(135, 1);
            this.sessionLengthLabel.Name = "sessionLengthLabel";
            this.sessionLengthLabel.Size = new System.Drawing.Size(17, 20);
            this.sessionLengthLabel.TabIndex = 11;
            this.sessionLengthLabel.Text = "0";
            this.sessionLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.sessionLengthLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.percentCompleteLabel);
            this.panel1.Controls.Add(this.timeRemainingLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(150, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 89);
            this.panel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Controls.Add(this.pomodoroBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.shortBreakBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.longBreakBtn, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 56);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // pomodoroBtn
            // 
            this.pomodoroBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pomodoroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pomodoroBtn.Location = new System.Drawing.Point(3, 3);
            this.pomodoroBtn.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pomodoroBtn.Name = "pomodoroBtn";
            this.pomodoroBtn.Size = new System.Drawing.Size(156, 50);
            this.pomodoroBtn.TabIndex = 0;
            this.pomodoroBtn.Text = "Pomodoro";
            this.pomodoroBtn.UseVisualStyleBackColor = true;
            this.pomodoroBtn.Click += new System.EventHandler(this.pomodoroBtn_Click);
            // 
            // shortBreakBtn
            // 
            this.shortBreakBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shortBreakBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortBreakBtn.Location = new System.Drawing.Point(161, 3);
            this.shortBreakBtn.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.shortBreakBtn.Name = "shortBreakBtn";
            this.shortBreakBtn.Size = new System.Drawing.Size(158, 50);
            this.shortBreakBtn.TabIndex = 1;
            this.shortBreakBtn.Text = "Short Break";
            this.shortBreakBtn.UseVisualStyleBackColor = true;
            this.shortBreakBtn.Click += new System.EventHandler(this.shortBreakBtn_Click);
            // 
            // longBreakBtn
            // 
            this.longBreakBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.longBreakBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longBreakBtn.Location = new System.Drawing.Point(321, 3);
            this.longBreakBtn.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.longBreakBtn.Name = "longBreakBtn";
            this.longBreakBtn.Size = new System.Drawing.Size(158, 50);
            this.longBreakBtn.TabIndex = 2;
            this.longBreakBtn.Text = "Long Break";
            this.longBreakBtn.UseVisualStyleBackColor = true;
            this.longBreakBtn.Click += new System.EventHandler(this.longBreakBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(482, 433);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pomodoro Timer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Label percentCompleteLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sessionLengthLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button pomodoroBtn;
        private System.Windows.Forms.Button shortBreakBtn;
        private System.Windows.Forms.Button longBreakBtn;
    }
}

