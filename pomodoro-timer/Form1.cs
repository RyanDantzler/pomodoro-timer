using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro_timer
{
    public partial class Form1 : Form
    {
        private static readonly int SECONDS_PER_MINUTE = 60;

        private static readonly int DEFAULT_POMODORO_LENGTH = 25;
        private static readonly int DEFAULT_SHORT_BREAK_LENGTH = 5;
        private static readonly int DEFAULT_LONG_BREAK_LENGTH = 15;

        private int pomodoroLength = DEFAULT_POMODORO_LENGTH;
        private int shortBreakLength = DEFAULT_SHORT_BREAK_LENGTH;
        private int longBreakLength = DEFAULT_LONG_BREAK_LENGTH;
        private int timeRemaining;
        private bool displayInfo = false;
        private PomodoroMode timerMode = PomodoroMode.Pomodoro;

        private enum PomodoroMode
        {
            Pomodoro,
            ShortBreak,
            LongBreak
        }

        public Form1()
        {
            InitializeComponent();
            setTimer(timerMode);
            panel1.Visible = displayInfo;
        }

        private void updateTimerDisplay()
        {
            int minutes = timeRemaining / SECONDS_PER_MINUTE;
            int seconds = timeRemaining % SECONDS_PER_MINUTE;
            timeLabel.Text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
            timeRemainingLabel.Text = timeRemaining.ToString();

            int sessionLength = timerMode == PomodoroMode.Pomodoro ? pomodoroLength : 
                timerMode == PomodoroMode.ShortBreak ? shortBreakLength : longBreakLength;

            sessionLength *= SECONDS_PER_MINUTE;

            sessionLengthLabel.Text = sessionLength.ToString();

            double timeElapsed = sessionLength - timeRemaining;
            double percentComplete = (timeElapsed / sessionLength) * 100;

            percentCompleteLabel.Text = percentComplete.ToString("0") + "%";
            progressBar1.Value = Convert.ToInt32(percentComplete);
        }

        private void StartTimer()
        {
            timer1.Start();
            startBtn.Text = "Pause";
        }

        private void StopTimer()
        {
            timer1.Stop();
            startBtn.Text = "Start";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            setTimer(timerMode);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                StartTimer();
            }
            else
            {
                StopTimer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeRemaining == 0) 
            {
                StopTimer();
                MessageBox.Show("Your time is up!", "Timer");
            } 
            else 
            {
                timeRemaining--;
                updateTimerDisplay();
            }
        }

        private void pomodoroBtn_Click(object sender, EventArgs e)
        {
            timerMode = PomodoroMode.Pomodoro;

            setTimer(PomodoroMode.Pomodoro);
        }

        private void shortBreakBtn_Click(object sender, EventArgs e)
        {
            timerMode = PomodoroMode.ShortBreak;

            setTimer(PomodoroMode.ShortBreak);
        }

        private void longBreakBtn_Click(object sender, EventArgs e)
        {
            timerMode = PomodoroMode.LongBreak;

            setTimer(PomodoroMode.LongBreak);
        }

        private void setTimer(PomodoroMode mode)
        {
            if (timer1.Enabled)
            {
                StopTimer();
            }

            int sessionLength = mode == PomodoroMode.Pomodoro ? pomodoroLength :
                mode == PomodoroMode.ShortBreak ? shortBreakLength : longBreakLength;

            timeRemaining = sessionLength * SECONDS_PER_MINUTE;
            updateTimerDisplay();
        }
    }
}
