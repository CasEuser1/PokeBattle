using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    public class Arena
    {
        private static int _totalRounds = 0;
        private static int _totalBattles = 0;

        public static void StartBattle(Trainer trainer1, Trainer trainer2)
        {
            _totalBattles++;
            Console.WriteLine($"\nStarting Battle #{_totalBattles} between {trainer1.Name} and {trainer2.Name}!");

            Battle battle = new Battle(trainer1, trainer2);
            battle.Fight();

            _totalRounds++;
            Console.WriteLine($"Battle #{_totalBattles} finished. Total Rounds: {_totalRounds}\n");
        }
    }
}
