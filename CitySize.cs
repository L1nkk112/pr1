using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CitySize
    {
        int population;
        public CitySize(int population)
        {
            this.population = population;
        }
        public string CityPopulation(int population)
        {
            string CitySize = "";
                if (population < 50000)
                { CitySize = "малый"; }
                else if (population >= 50000 && population < 100000)
                { CitySize = "средний"; }
                else if (population >= 100000 && population < 250000)
                CitySize = "большой";
                else if (population >= 250000 && population < 1000000)
                CitySize = "крупный";
                else CitySize = "крупнейший";
                return CitySize;
        }
    }
}
