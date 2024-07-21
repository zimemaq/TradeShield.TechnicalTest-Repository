using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain;

namespace TS.TechnicalTest
{
    class LongestSentanceAnswer
    {
        static void Main(string[] args)
        {
            // Dependancy Injection and Mocking would be greate.
            LongestSentance longestSentance = new LongestSentance();

            var input = $"We test coders. Give us a try";
            
            Console.Write(longestSentance.GetLongestSentance(input));

            Console.Read();
        }
    }
}
