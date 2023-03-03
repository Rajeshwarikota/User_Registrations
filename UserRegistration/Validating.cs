using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Validating
    {

        public static void ValidatingFirstName()
        {
            Console.WriteLine("enter the fitst name");
            string pattern = "^[A-Z]{1}[a-z]{2}";
            string input = Console.ReadLine();
            validatingpattern(input, pattern);
        }
        public static void ValidatingLastName()
        {
            Console.WriteLine("enter the last name");
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            string input = Console.ReadLine();
            validatingpattern(input, pattern);
        }
        public static void validatingpattern(string input, string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("{0} is valid ", input);
            }
            else
            {
                Console.WriteLine("{0} is not valid ", input);
            }

        }
    }
}