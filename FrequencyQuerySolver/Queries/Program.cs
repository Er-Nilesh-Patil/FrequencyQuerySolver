using FrequencyQuerySolver.Queries;
class Program
{
    static void Main()
    {
        int[][] queries1 = {
            new int[] {1, 1},
            new int[] {2, 2},
            new int[] {3, 2},
            new int[] {1, 1},
            new int[] {1, 1},
            new int[] {2, 1},
            new int[] {3, 2}
        };

        int[][] queries2 = {
            new int[] {4},
            new int[] {3,4},
            new int[] {2,1003},
            new int[] {1,16},
            new int[] {3,1}
        };

        int[][] queries3 = {
            new int[] {10},
            new int[] {1, 3},
            new int[] {2, 3},
            new int[] {3, 2},
            new int[] {1, 4},
            new int[] {1, 5},
            new int[] {1, 5},
            new int[] {1, 4},
            new int[] {3, 2},
            new int[] {2, 4},
            new int[] {3, 2}
        };

        FrequencyQueryHandler queryHandler = new FrequencyQueryHandler();

        List<int> result1 = queryHandler.PerformQueries(queries1);
        List<int> result2 = queryHandler.PerformQueries(queries2);
        List<int> result3 = queryHandler.PerformQueries(queries3);

        Console.WriteLine("Results for queries set 1:");
        Console.WriteLine(string.Join(" ", result1));

        Console.WriteLine("\nResults for queries set 2:");
        Console.WriteLine(string.Join(" ", result2));

        Console.WriteLine("\nResults for queries set 3:");
        Console.WriteLine(string.Join(" ", result3));
    }
}




/*
using System;
using System.Collections.Generic;

class Program
{
    // Method to perform frequency queries on a given set of data
    static List<int> PerformFrequencyQueries(int[][] queries)
    {
        // Dictionary to store the frequency of each element
        Dictionary<int, int> elementFrequencyMap = new Dictionary<int, int>();

        // Dictionary to store the count of frequencies
        Dictionary<int, int> frequencyCountMap = new Dictionary<int, int>();

        // List to store the results of the queries
        List<int> result = new List<int>();

        foreach (var query in queries)
        {
            // Extracting operation and dataElement from the query
            int operation = query[0];
            int dataElement = query.Length > 1 ? query[1] : 0; // Ensure there is a second element in the query

            switch (operation)
            {
                case 1:
                    // Insert operation
                    UpdateFrequencyMaps(elementFrequencyMap, frequencyCountMap, dataElement, 1);
                    break;

                case 2:
                    // Delete operation
                    UpdateFrequencyMaps(elementFrequencyMap, frequencyCountMap, dataElement, -1);
                    break;

                case 3:
                    // Check operation
                    result.Add(frequencyCountMap.TryGetValue(dataElement, out int count) && count > 0 ? 1 : 0);
                    break;
            }
        }

        return result;
    }

    // Helper method to update the frequency maps
    static void UpdateFrequencyMaps(Dictionary<int, int> elementFrequencyMap, Dictionary<int, int> frequencyCountMap, int element, int increment)
    {
        // Update the frequency count
        if (elementFrequencyMap.TryGetValue(element, out int currentFrequency) && currentFrequency > 0)
        {
            frequencyCountMap[currentFrequency]--;
        }

        // Update the element frequency
        elementFrequencyMap[element] = currentFrequency + increment;

        // Update the count of the new frequency
        if (frequencyCountMap.ContainsKey(currentFrequency + increment))
        {
            frequencyCountMap[currentFrequency + increment]++;
        }
        else
        {
            frequencyCountMap[currentFrequency + increment] = 1;
        }
    }

    static void Main()
    {
        // Sample queries sets

        int[][] queries1 = {
            new int[] {1, 1},
            new int[] {2, 2},
            new int[] {3, 2},
            new int[] {1, 1},
            new int[] {1, 1},
            new int[] {2, 1},
            new int[] {3, 2}
        };
            
        int[][] queries2 = {
            new int[] {4},
            new int[] {3,4},
            new int[] {2,1003},
            new int[] {1,16},
            new int[] {3,1}
        };
              
        int[][] queries3 = {
            new int[] {10},
            new int[] {1, 3},
            new int[] {2, 3},
            new int[] {3, 2},
            new int[] {1, 4},
            new int[] {1, 5},
            new int[] {1, 5},
            new int[] {1, 4},
            new int[] {3, 2},
            new int[] {2, 4},
            new int[] {3, 2}
        };


        // Perform frequency queries on sets
        List<int> result1 = PerformFrequencyQueries(queries1);
       
        List<int> result2 = PerformFrequencyQueries(queries2);
       
        List<int> result3 = PerformFrequencyQueries(queries3);

        // Print results for sets
        Console.WriteLine("Results for queries set 1:");
        Console.WriteLine(string.Join(" ", result1));
       
        Console.WriteLine("\nResults for queries set 2:");
        Console.WriteLine(string.Join(" ", result2));

        Console.WriteLine("\nResults for queries set 3:");
        Console.WriteLine(string.Join(" ", result3));
    }
}
*/