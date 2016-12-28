namespace _07.Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();
    
    public class Timer
    {
        private int interval;

        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public int Interval 
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval cannot be negative");
                }
                this.interval = value;
            }
        }

        public TimerDelegate TEvent { get; set; }

        public void DoIt()
        {
            while (!Console.KeyAvailable)
            {
                this.TEvent();
                Thread.Sleep(this.interval * 1000);
            }
        }
    }
}
