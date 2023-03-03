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
            Console.WriteLine(".....User Registration......");

            Validating validate = new Validating();
            Console.WriteLine("Please Choose \n1.firstname \n2.lastname \n3.email \n4.phonenum \n5.password  \n20.exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    validate.ValidatingFirstName();
                    break;
                case 2:
                    validate.ValidatingLastName();
                    break;
                case 3:
                    validate.ValidatingEmail();
                    break;
                case 4:
                    validate.ValidatingPhoneNumber();
                    break;
                case 5:
                    validate.Validatingpassword();
                    break;
              

                default:
                    Console.WriteLine("Choose the Correct Number !");
                    break;
            }
            Console.ReadLine();
        }
    }
}
