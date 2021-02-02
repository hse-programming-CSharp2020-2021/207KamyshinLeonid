using System;

namespace Task2
{
    class PlayIsStartedEventArgs : EventArgs
    {
        public int SoundNumber { get; set; }
    }

    class Bandmaster
    {
        static Random rng = new Random();

        public event EventHandler<PlayIsStartedEventArgs> ev;
        
        public void StartPlay()
        {
            ev?.Invoke(this, new PlayIsStartedEventArgs() { SoundNumber = rng.Next(1, 11) });
        }
    }

    abstract class OrchestraPlayer
    {
        public string Name { get; set; }

        public abstract void PlayIsStartedEventArgs(object sender, PlayIsStartedEventArgs e);
    }

    class Violinist : OrchestraPlayer
    {
        public override void PlayIsStartedEventArgs(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Violinist {Name} plays composition {e.SoundNumber}: La-la!");
        }
    }

    class Hornist : OrchestraPlayer
    {
        public override void PlayIsStartedEventArgs(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Hornist {Name} plays composition {e.SoundNumber}: Du-du-du!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bandmaster master = new Bandmaster();
            Random rng = new Random();
            OrchestraPlayer[] arr = new OrchestraPlayer[10];
            for(int i = 0; i < 10; i++)
            {
                if(rng.Next(0,2)%2 == 0)
                {
                    arr[i] = new Violinist() { Name = "# " + rng.Next(1, 101).ToString() };
                }
                else
                {
                    arr[i] = new Hornist() { Name = "# " + rng.Next(1, 101).ToString() };

                }
                master.ev += arr[i].PlayIsStartedEventArgs;
            }
            Console.WriteLine("*******************************************");
            master.StartPlay();
        }
    }
}
