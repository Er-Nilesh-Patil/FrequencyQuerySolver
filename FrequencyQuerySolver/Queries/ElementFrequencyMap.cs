using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyQuerySolver.Queries
{
    public class ElementFrequencyMap
    {
        private readonly Dictionary<int, int> elementFrequencyMap = new Dictionary<int, int>();
        private int previousFrequency;
        private int currentFrequency;

        public void Update(int element, int increment)
        {
            if (elementFrequencyMap.TryGetValue(element, out previousFrequency) && previousFrequency > 0)
            {
                currentFrequency = previousFrequency + increment;
                elementFrequencyMap[element] = currentFrequency;
            }
            else
            {
                currentFrequency = increment;
                elementFrequencyMap[element] = increment;
            }
        }

        public int GetPreviousFrequency()
        {
            return previousFrequency;
        }

        public int GetCurrentFrequency()
        {
            return currentFrequency;
        }
    }
}
