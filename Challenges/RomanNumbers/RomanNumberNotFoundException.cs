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
