using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    public class Pokeball
    {
        private Charmander _charmander;
        private bool _isOpen;

        public Pokeball(Charmander charmander)
        {
            _charmander = charmander;
            _isOpen = false;
        }

        public void Throw()
        {
            if (_isOpen)
            {
                Console.WriteLine("The Pokeball is already open!");
                return;
            }

            _isOpen = true;
            Console.WriteLine("Pokeball thrown!");
            _charmander?.BattleCry();
        }

        public void Return()
        {
            if (!_isOpen)
            {
                Console.WriteLine("The Pokeball is already closed!");
                return;
            }

            _isOpen = false;
            Console.WriteLine("Charmander returned to the Pokeball.");
        }

        public bool IsOpen => _isOpen;
        public Charmander GetPokemon() => _charmander;
    }
}