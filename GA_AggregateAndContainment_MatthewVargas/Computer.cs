using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_MatthewVargas
{

    internal class Computer
    {
        string cpu;
        string _mother;
        GraphicsCard _graphicsCard;

        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard = graphicsCard;
        }
    }
}
