using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace HellGateTimer
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL")]
        extern private static void Beep(int freq, int dur);

        private Thread TimerThread;

        private bool timerstop;
        private bool mutevolume = false;
        private double timersec;
        private double timermode;

        private delegate void SetTextCallback(string text);

        public MainForm()
        {
            InitializeComponent();

            TimerThread = new Thread(new ThreadStart(TimerThreadRun));
        }

        private void TimerStart(object sender, EventArgs e)
        {
            timerstop = false;

            timersec = int.Parse((string)(sender as Button).Tag) * 60;
            timermode = timersec;

            labelTimeStamp.Text = DateTime.Now.ToString("mm-ss");
            TimerThread.Start();

            TimerButtonFlip();
        }

        private void TimerReset(object sender, EventArgs e)
        {
            // 리셋
            timerstop = true;
            timersec = 0;
            labelTimeStamp.Text = "";
            
            TimerButtonFlip();
        }

        // TimerThreadRun function for Timer Handling
        private void TimerThreadRun()
        {
            Stopwatch TimerRunTime = new Stopwatch();

            int timercorrection = 0;

            while (!timerstop)
            {
                TimerRunTime.Start();

                int sleepsec = 500;

                timersec--;

                SetText(timersec.ToString());

                switch (timersec)
                {
                    case 12:
                        DoBeep(750,500);
                        break;
                    case 5:
                        DoBeep(500, 500);
                        break;
                    case 4:
                        DoBeep(500, 500);
                        break;
                    case 3:
                        DoBeep(500, 500);
                        break;
                    case 2:
                        DoBeep(1000, 500);
                        break;
                    case 0:
                        DoBeep(750, 500);
                        timersec = timermode;

                        //MessageBox.Show(TimerRunTime.ElapsedMilliseconds.ToString());
                        TimerRunTime.Reset();
                        break;
                    default:
                        sleepsec = sleepsec * 2;
                        break;
                }

                try
                {
                    Thread.Sleep(sleepsec - timercorrection);
                }
                catch { }

                timercorrection = (int)TimerRunTime.ElapsedMilliseconds % 1000;

                TimerRunTime.Stop();
                //MessageBox.Show(TimerRunTime.ElapsedMilliseconds.ToString());
                //MessageBox.Show((TimerRunTime.ElapsedMilliseconds % 1000).ToString());
            }

            SetText(timersec.ToString());

            TimerThread = new Thread(new ThreadStart(TimerThreadRun));
        }

        // SetText delegent for TimerThread thread
        private void SetText(string text)
        {
            if (labelLeftTime.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                labelLeftTime.Text = text;
            }
        }

        private void DoBeep(int sound, int sec)
        {
            if (mutevolume == true)
                Beep(0, sec);
            else
                Beep(sound, sec);

        }

        // Abort TimerThread when MainForm closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerThread.Interrupt();
            TimerThread.Abort();
        }

        private void TimerButtonFlip()
        {
            buttonTimerStart3m.Enabled = !buttonTimerStart3m.Enabled;
            buttonTimerStart6m.Enabled = !buttonTimerStart6m.Enabled;
            buttonTimerStart10m.Enabled = !buttonTimerStart10m.Enabled;
        }

        private void checkBoxMuteVolume_CheckedChanged(object sender, EventArgs e)
        {
            mutevolume = checkBoxMuteVolume.Checked;
        }

        private void checkBoxAllwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxAllwaysOnTop.Checked;
        }
    }
}
