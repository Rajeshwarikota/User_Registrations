﻿using System;
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
            Validating.ValidatingFirstName();
            Validating.ValidatingLastName();
            Console.ReadLine();
        }
    }
}
