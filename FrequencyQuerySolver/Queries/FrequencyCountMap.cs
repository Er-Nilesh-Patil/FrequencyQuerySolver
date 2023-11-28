using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyQuerySolver.Queries
{
    public class FrequencyCountMap
    {
        private readonly Dictionary<int, int> frequencyCountMap = new Dictionary<int, int>();

        public void Update(int previousFrequency, int currentFrequency)
        {
            if (frequencyCountMap.ContainsKey(previousFrequency))
            {
                frequencyCountMap[previousFrequency]--;
            }

            if (frequencyCountMap.ContainsKey(currentFrequency))
            {
                frequencyCountMap[currentFrequency]++;
            }
            else
            {
                frequencyCountMap[currentFrequency] = 1;
            }
        }

        public bool Contains(int key)
        {
            return frequencyCountMap.ContainsKey(key);
        }

        public int GetCount(int key)
        {
            return frequencyCountMap[key];
        }
    }
}
