using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Validating
    {
        public static string FirstName(string firstname)
        {
            string pattern = "^[A-Z]{1}[a-z]{2}";

            if (Regex.IsMatch(firstname, pattern))
            {
                return "Happy";
            }

            else
            {
                return "Sad";

            }
        }
        public static string LastName(string lastname)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}";

            if (Regex.IsMatch(lastname, pattern))
            {
                return "Happy";

            }

            else
            {
                return "Sad";
            }
        }
        public static string Email(string emails)
        {
            string pattern = "^[a-zA-Z0-9]{1,}[.+-_]?[a-zA-z0-9]{1,}[@]{1}[0-9a-zA-Z]+.[a-zA-Z]{2,}([.]{0,1}[A-Za-z]{2,})+([.]{0,1}[A-Za-z]{2,})*[,]?$";

            if (Regex.IsMatch(emails, pattern))
            {
                return "Happy";
            }

            else
            {
                return "Sad";
            }
        }
        public static string PhoneNumber(string Number)
        {
            string pattern = "^[0-9]{2}\\s[0-9]{10}";

            if (Regex.IsMatch(Number, pattern))
            {
                return "Happy";
            }

            else
            {
                return "Sad";
            }
        }
        public static string Password(string password)
        {
            string pattern = "(?=.*[A-Z])(?=.*[0-9])(?=.*[~!@#$%^&*,.]{1}).{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                return "Happy";

            }

            else
            {
                return "Sad";
            }

        }
       

    }
}