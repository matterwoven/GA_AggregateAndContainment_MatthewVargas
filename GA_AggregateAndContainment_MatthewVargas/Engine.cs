using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_MatthewVargas
{
    internal class Engine
    {
        int _hp;

        public Engine(int hp)
        {
            _hp = hp;
        }

        public int Hp
        {
            get => _hp;


            set
            {
                if (value >= 50)
                {
                    _hp = value;
                }
                else
                {
                    throw new Exception("Please enter a valid Horse Power");
                }
            }

        }
    }
}
