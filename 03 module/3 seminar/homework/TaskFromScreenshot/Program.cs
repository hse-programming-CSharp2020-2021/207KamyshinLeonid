using System;
using MyLib;

namespace TaskFromScreenshot
{
    class Program
    {
        static void Main(string[] args)
        {
            VetoCommission vetoCommission = new VetoCommission();
            VetoVoter[] vetoVoters = new VetoVoter[5];
            for (int i = 0; i < vetoVoters.Length; i++)
            {
                vetoVoters[i] = new VetoVoter();
                vetoCommission.OnVote += vetoVoters[i].Veto;
            }
            var result = vetoCommission.Vote("Idea #1");
            if(result.VetoBy != null)
            {
                Console.WriteLine($"Proposal {result.Proposal} was denied by {result.VetoBy.Name}");
            }
            else
            {
                Console.WriteLine($"Proposal {result.Proposal} was approved");
            }
        }
    }
}
