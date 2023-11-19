using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    public partial class Stoper : Form
    {
        private enum StoperStatus
        {
            stoperOff,
            stoperOn,
            stoperPause
        }

        private static StoperStatus status = StoperStatus.stoperOff;
        private static Stopwatch stopwatch = new Stopwatch();
        public static string elapsedTime;

        public Stoper()
        {
            InitializeComponent();
        }

        private void Stoper_Load(object sender, EventArgs e)
        {
            switch (status)
            {
                case StoperStatus.stoperOff:
                    StoperOff();
                    break;
                case StoperStatus.stoperOn:
                    StoperOn();
                    break;
                case StoperStatus.stoperPause:
                    StoperPause();
                    timerStoper.Start();
                    break;
            }
        }

        private void timeStartStop_Click(object sender, EventArgs e)
        {
            if (status == StoperStatus.stoperOff)
            {
                status = StoperStatus.stoperOn;
                Thread timeCount = new Thread(TimeCount);
                timeCount.Start();
                stopwatch.Restart();
                StoperOn();
            }
            else if (status == StoperStatus.stoperOn)
            {
                stopwatch.Stop();
                status = StoperStatus.stoperPause;
                StoperPause();
                timerStoper.Stop();
            }
        }

        private void timeResume_Click(object sender, EventArgs e)
        {
            status = StoperStatus.stoperOn;
            StoperOn();
        }

        private void timeReset_Click(object sender, EventArgs e)
        {
            status = StoperStatus.stoperOff;
            StoperOff();
            timerStoper.Stop();
            stopwatchText.Text = "00:00.00";
            timeStartStop.Text = "Rozpocznij";
        }

        private void timerStoper_Tick(object sender, EventArgs e)
        {
            stopwatchText.Text = elapsedTime;
        }

        private void StoperOff()
        {
            timeResume.Visible = false;
            timeReset.Visible = false;
            timeStartStop.Visible = true;
        }

        private void StoperOn()
        {
            stopwatch.Start();
            timerStoper.Start();
            timeStartStop.Text = "stop";
            timeResume.Visible = false;
            timeReset.Visible = false;
            timeStartStop.Visible = true;
        }

        private void StoperPause()
        {
            timeStartStop.Text = "Wznów";
            timeResume.Visible = true;
            timeReset.Visible = true;
            timeStartStop.Visible = false;
        }

        private void TimeUpdate()
        {
            TimeSpan ts = stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void TimeCount()
        {
            while (Application.AllowQuit)
            {
                if (status == StoperStatus.stoperOn)
                    TimeUpdate();
                Thread.Sleep(10);
            }
        }
    }
}
