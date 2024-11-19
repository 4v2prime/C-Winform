using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IncrementCode
{
    public class Program
    {
       static string NewCandidateCode;
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the code:");
            string code= Console.ReadLine();
            Console.WriteLine(dothingincrement(code));
            Console.ReadLine();
        }
        public static string dothingincrement(string CandidateCode)
        {
            string characters = Regex.Match(CandidateCode, @"^[A-Za-z]+").Value;

            string digitsString = Regex.Match(CandidateCode, @"\d+$").Value;
            int digits = int.Parse(digitsString);

            int NewCount = digits + 1;

            NewCandidateCode = characters + NewCount.ToString();
            return NewCandidateCode;
        }
    }
}
