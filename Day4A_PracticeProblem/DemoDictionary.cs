using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    public class DemoDictionary
    {
        public void MethodDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Create 
            dict.Add(1, "Bike");
            dict.Add(2, "Car");
            dict.Add(3, "Truck");
            dict.Add(4, "Bicycle");
            dict.Add(5, "Bus");
            dict.Add(6, "Auto");
            // Read 
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            // Update 
            Console.WriteLine("*******Update in dictionary********");
            dict[5] = "Cab";
            dict[6] = "Duster";
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            // Delete 
            Console.WriteLine("********Delete in dictionary********");
            dict.Remove(3);
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
