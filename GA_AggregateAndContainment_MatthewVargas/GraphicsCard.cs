using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GA_AggregateAndContainment_MatthewVargas
{

    public class GraphicsCard
    { 

        public enum Brand { Amd, Nvidia, Intel }
        Brand _graphicsCardBrand;

        public GraphicsCard(Brand graphicsCardBrand)
        {
            _graphicsCardBrand = graphicsCardBrand;
        }
}
}

