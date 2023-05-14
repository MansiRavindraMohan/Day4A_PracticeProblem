using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            DemoArrayList demoArrayList = new DemoArrayList();
            demoArrayList.MethodArrayList();
            //Dictionary
            DemoDictionary demoDictionary = new DemoDictionary();
            demoDictionary.MethodDictionary();
            Console.ReadLine();
        }
    }
}
