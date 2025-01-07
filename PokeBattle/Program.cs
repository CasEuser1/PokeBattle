using PokeBattle;
using System;

class PokemonBattleSimulator
{
    static void Main(string[] args)
    {
        Console.Write("Enter name for Trainer 1: ");
        string trainer1Name = Console.ReadLine();
        Trainer trainer1 = new Trainer(trainer1Name);

        Console.Write("Enter name for Trainer 2: ");
        string trainer2Name = Console.ReadLine();
        Trainer trainer2 = new Trainer(trainer2Name);

        bool playAgain = true;

        while (playAgain)
        {
            Arena.StartBattle(trainer1, trainer2);

            Console.Write("Would you like to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }
}

