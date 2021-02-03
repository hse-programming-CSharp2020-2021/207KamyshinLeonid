using System;

namespace MyLib
{
    public class VetoEventArgs : EventArgs
    {
        public string Proposal { get; set; }

        public VetoVoter VetoBy { get; set; }

    }

    public class VetoCommission
    {
        public event EventHandler<VetoEventArgs> OnVote;

        public VetoEventArgs Vote(string proposal)
        {
            VetoEventArgs results = new VetoEventArgs() { Proposal = proposal };
            OnVote?.Invoke(this, results);
            return results;
        }
    }

    public class VetoVoter
    {
        static Random rng = new Random();

        public string Name { get; set; }

        public VetoVoter()
        {
            Name = "#" + rng.Next(1, 101);
        }

        public void Veto(object sender, VetoEventArgs e)
        {
            if (e.VetoBy != null)
            {
                return;
            }

            if (rng.Next(0, 100) % 5 == 0)
            {
                e.VetoBy = this;
            }

        }
    }
}
