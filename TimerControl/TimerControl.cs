using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TimerControl
{
    public partial class TimeControl : UserControl
    {
        private Timer timer;
        private int startingSeconds = 0;
        public int seconds
        {
            get
            {
                return GetSeconds();
            }
        }

        public delegate void TimerEnd();
        public event TimerEnd End;

        public TimeControl()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += Tick;
            End += OnEnd;
        }

        private void OnEnd()
        {
        }
       

        private int GetSeconds()
        {
            return this.hoursBox.Value * 3600 + this.minutesBox.Value * 60 + this.secondsBox.Value;
        }

        private int TimeRatio()
        {
            return (int)((float) (timer.Enabled ? seconds : 0) / (timer.Enabled ? startingSeconds : seconds > 0 ? seconds : 100) * 150f);
        }


        private void Tick(object sender, EventArgs e)
        {
            if (this.seconds > 0)
            {
                Invalidate();
                if (secondsBox.HasTime())
                {
                    secondsBox.Decrement();
                }
                else if(minutesBox.HasTime())
                {
                    minutesBox.Decrement();
                    secondsBox.Reset();
                }
                else if(hoursBox.HasTime())
                {
                    hoursBox.Decrement();
                    minutesBox.Reset();
                    secondsBox.Reset();
                }
            }
            else
            {
                End();
                timer.Stop();
                hoursBox.Enabled = true;
                minutesBox.Enabled = true;
                secondsBox.Enabled = true;
            }
        }

        public void Start()
        {
            this.startingSeconds = seconds;
            Console.WriteLine(seconds);
            timer.Interval = 500;
            timer.Start();
            hoursBox.Enabled = false;
            minutesBox.Enabled = false;
            secondsBox.Enabled = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(Color.DodgerBlue);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 60, TimeRatio(), 5));
            myBrush.Color = Color.Gray;
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
