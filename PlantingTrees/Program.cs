using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantingTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new KattisHandler(Console.OpenStandardInput());
            Console.WriteLine(handler.Solve());
        }
    }
}
