using System;
using System.Timers;

namespace Pde.CodingExercise.RandomNumberGenerator
{
    public class NumberGenerator
    {
        public event EventHandler<NumberGeneratedEventArgs> NumberGenerated;

        Timer timer;
        Random r = new Random();

        public NumberGenerator()
        {
            timer = new Timer(500);
        }

        public void Start() 
        {
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OnNumberGenerated(new EventArgs());
        }

        protected virtual void OnNumberGenerated(EventArgs e)
        {
            EventHandler<NumberGeneratedEventArgs> handler = NumberGenerated;

            NumberGeneratedEventArgs args = new NumberGeneratedEventArgs();
            args.Number = r.Next(-1000, 1000);

            handler?.Invoke(this, args);
        }
    }

    public class NumberGeneratedEventArgs : EventArgs
    {
        public int Number { get; set; }
    }
}
