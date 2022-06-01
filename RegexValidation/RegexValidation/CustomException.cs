using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexValidation
{
    public class RegexValidationCustomException : Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            LASTNAME_INVALID, FIRSTNAME_INVALID
        }
        public RegexValidationCustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
