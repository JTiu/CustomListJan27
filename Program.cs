using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListAndTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> JtsList = new List<int>();
            JtsList.Add(1);
            Console.WriteLine(JtsList.Capacity);
            Console.ReadLine();
        }
    }
}
