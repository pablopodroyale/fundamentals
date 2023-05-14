using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.RomanNumbers
{
    public class RomanNumberNotFoundException: Exception
    {
        static readonly string ERROR_MESSAGE = "Error, roman number not found";
        public RomanNumberNotFoundException(): base(ERROR_MESSAGE)
        {
        }
    }
}
