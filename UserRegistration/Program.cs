using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration Problem statement");

            string[] email = new string[] { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmai.com.com", "abc+100@gmail.com" };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose \n1.First Name \n2.Last Name \n3.Email  \n4.phone Number \n5.Password \n6.Check Multiple Emails \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter First name :");
                        string firstname = Console.ReadLine();
                        Validating.FirstName(firstname);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last name :");
                        string lastname = Console.ReadLine();
                        Validating.LastName(lastname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id :");
                        string emails = Console.ReadLine();
                        Validating.Email(emails);
                        break;
                   
                    case 4:
                        Console.WriteLine("Enter phone no. :");
                        string Number= Console.ReadLine();
                        Validating.PhoneNumber(Number);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password :");
                        string password = Console.ReadLine();
                        Validating.Password(password);
                        break;
                    
                    case 6:
                        foreach (string s in email)
                        {
                            Console.Write("\n" + s + " -");
                            Console.WriteLine(Validating.Email(s));
                        }
                        break;

                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the above option ");
                        break;
                }
              
            }
        }
    }
}






