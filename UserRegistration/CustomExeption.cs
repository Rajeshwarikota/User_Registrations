using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class CustomExeption:Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_PHONENUMBER, INVALID_EMAIL, INVALID_PASSWORD
        }
        public ExceptionType Type;
        public CustomExeption(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}

