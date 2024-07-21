using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Services;

namespace TS.TechnicalTest.Q2
{
    class DeepestPitAnswer
    {
        static void Main(string[] args)
        {
            // Dependancy Injection and Mocking would be greate.
            DeepestPit deepestPit = new DeepestPit();
            int[] array = { 0, 1, 3, -2, 0, -3, 2, 3 };

            Console.Write(deepestPit.GetPitDepth(array));

            Console.Read();
        }
    }
}
