using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    public class Trainer
    {
        public string Name { get; private set; }
        private List<Pokeball> _belt;

        public Trainer(string name)
        {
            Name = name;
            _belt = new List<Pokeball>();
            for (int i = 0; i < 6; i++)
            {
                _belt.Add(new Pokeball(new Charmander($"Charmander {i + 1}")));
            }
        }

        public Pokeball GetRandomPokeball()
        {
            var availablePokeballs = _belt.FindAll(p => !p.IsOpen);
            if (availablePokeballs.Count == 0) return null;

            Random random = new Random();
            return availablePokeballs[random.Next(availablePokeballs.Count)];
        }

        public void ThrowPokeball(Pokeball pokeball)
        {
            pokeball.Throw();
        }

        public void ReturnPokemon(Pokeball pokeball)
        {
            pokeball.Return();
        }
    }
}
