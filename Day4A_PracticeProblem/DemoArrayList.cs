using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    public class DemoArrayList
    {
        public void MethodArrayList()
        {
            ArrayList list = new ArrayList();
            // Create 
            list.Add("apple");
            list.Add("banana");
            list.Add("cherry");
            list.Add("blueberry");
            list.Add("guava");
            list.Add("mango");
            // Read 
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            // Update 
            Console.WriteLine("*******Update in list********");
            list[1] = "orange";
            list[2] = "pineapple";
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            // Delete 
            Console.WriteLine("********Delete in list********");
            list.Remove("guava");
            list.Remove("mango");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
