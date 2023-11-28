using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyQuerySolver.Queries
{
    public class FrequencyQueryHandler
    {
        private readonly ElementFrequencyMap elementFrequencyMap;
        private readonly FrequencyCountMap frequencyCountMap;

        public FrequencyQueryHandler()
        {
            elementFrequencyMap = new ElementFrequencyMap();
            frequencyCountMap = new FrequencyCountMap();
        }

        public List<int> PerformQueries(int[][] queries)
        {
            List<int> result = new List<int>();

            foreach (var query in queries)
            {
                int operation = query[0];
                int dataElement = query.Length > 1 ? query[1] : 0;

                switch (operation)
                {
                    case 1:
                        elementFrequencyMap.Update(dataElement, 1);
                        frequencyCountMap.Update(elementFrequencyMap.GetPreviousFrequency(), elementFrequencyMap.GetCurrentFrequency());
                        break;

                    case 2:
                        elementFrequencyMap.Update(dataElement, -1);
                        frequencyCountMap.Update(elementFrequencyMap.GetPreviousFrequency(), elementFrequencyMap.GetCurrentFrequency());
                        break;

                    case 3:
                        result.Add(frequencyCountMap.Contains(dataElement) && frequencyCountMap.GetCount(dataElement) > 0 ? 1 : 0);
                        break;
                }
            }

            return result;
        }
    }
}
