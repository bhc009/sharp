using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_type
{
    class MenuMaker
    {
        public Random m_randomizer;

        string[] Meats = { "meat1", "meat2", "meat3", "meat4", "meat5" };
        string[] Condiments = { "Condiments1", "Condiments2", "Condiments3", "Condiments4", "Condiments5", "Condiments6" };
        string[] Breads = { "bread1", "bread2", "bread3", "bread4", "bread5", "bread6" };

        public string GetMenuItem()
        {
            string rndMeat = Meats[m_randomizer.Next(Meats.Length)];
            string rndCondiment = Condiments[m_randomizer.Next(Condiments.Length)];
            string rndBread = Breads[m_randomizer.Next(Breads.Length)];

            return rndMeat + " with " + rndCondiment + " on " + rndBread;
        }
    }
}
