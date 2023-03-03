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
        public static void ValidatingEmail()
        {
            Console.WriteLine("enter the Email");
            string pattern = "^[a,b,c]{3}[.][A-Z]{3}[@][b,l]{2}[.][c,o]{2}[.][a-z]{2}";
            string input = Console.ReadLine();
            validatingpattern(input, pattern);
        }
        public static void ValidatingPhoneNumber()
        {
            Console.WriteLine("enter the phone number");
            string pattern = "^[0-9]{2}\\s[0-9]{10}";
            string input = Console.ReadLine();
            validatingpattern(input, pattern);
        }
        public static void Validatingpassword()
        {
            Console.WriteLine("enter the 8 character");
            string pattern = "^[a-zA-Z0-9]{8}";
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