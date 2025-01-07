using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    public class Battle
    {
        private Trainer _trainer1;
        private Trainer _trainer2;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            _trainer1 = trainer1;
            _trainer2 = trainer2;
        }

        public Trainer Fight()
        {
            Pokeball trainer1Pokeball;
            Pokeball trainer2Pokeball;
            Charmander trainer1Pokemon = null;
            Charmander trainer2Pokemon = null;

            while (true)
            {
                trainer1Pokeball = _trainer1.GetRandomPokeball();
                trainer2Pokeball = _trainer2.GetRandomPokeball();

                if (trainer1Pokeball == null && trainer2Pokeball == null)
                {
                    Console.WriteLine("It's a draw! Both trainers are out of Pokeballs.");
                    return null;
                }

                if (trainer1Pokeball != null)
                {
                    trainer1Pokemon = trainer1Pokeball.GetPokemon();
                    _trainer1.ThrowPokeball(trainer1Pokeball);
                }

                if (trainer2Pokeball != null)
                {
                    trainer2Pokemon = trainer2Pokeball.GetPokemon();
                    _trainer2.ThrowPokeball(trainer2Pokeball);
                }

                string result = DetermineWinner(trainer1Pokemon, trainer2Pokemon);

                if (result == "Trainer1")
                {
                    Console.WriteLine($"{_trainer1.Name} wins the round!");
                    if (trainer2Pokeball != null) _trainer2.ReturnPokemon(trainer2Pokeball);
                }
                else if (result == "Trainer2")
                {
                    Console.WriteLine($"{_trainer2.Name} wins the round!");
                    if (trainer1Pokeball != null) _trainer1.ReturnPokemon(trainer1Pokeball);
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                    if (trainer1Pokeball != null) _trainer1.ReturnPokemon(trainer1Pokeball);
                    if (trainer2Pokeball != null) _trainer2.ReturnPokemon(trainer2Pokeball);
                }
            }
        }

        private string DetermineWinner(Charmander pokemon1, Charmander pokemon2)
        {
            if (pokemon1 == null && pokemon2 == null) return "Draw";
            if (pokemon1 != null && pokemon2 == null) return "Trainer1";
            if (pokemon1 == null && pokemon2 != null) return "Trainer2";

            if (pokemon1.strength == "fire" && pokemon2.strength == "grass") return "Trainer1";
            if (pokemon1.strength == "grass" && pokemon2.strength == "water") return "Trainer1";
            if (pokemon1.strength == "water" && pokemon2.strength == "fire") return "Trainer1";

            if (pokemon2.strength == "fire" && pokemon1.strength == "grass") return "Trainer2";
            if (pokemon2.strength == "grass" && pokemon1.strength == "water") return "Trainer2";
            if (pokemon2.strength == "water" && pokemon1.strength == "fire") return "Trainer2";

            return "Draw";
        }
    }
}
