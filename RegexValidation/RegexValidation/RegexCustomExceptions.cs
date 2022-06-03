using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexValidation
{
    public class RegexCustomException : Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            FIRSTNAME_INVALID, LASTNAME_INVALID, EMAILID_INVALID, MOBILE_INVALID, PASSWORD_INVALID
        }
        public RegexCustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
