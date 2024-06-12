using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPracticeProgram.Models
{
    internal class Helpers
    {

        public static string GetUSerInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            Console.Clear();
            return input;

        }
    }
}
