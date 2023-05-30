namespace Challenges.RomanNumbers
{
    public class RomanNumbersCalculator
    {
        public RomanNumbersCalculator() { }

        public int GetNumber(string number)
        { 
            int result = 0;
            char[] numberArray = number.ToUpper()
                                       .ToCharArray();
            int numberAux = 0;
            int next = 0;
            char currentChar;
            char nextChar;
            var romanKeys = Enum.GetNames(typeof(RomanNumbers)).ToList();

            for (int i = 0; i < numberArray.Length; i++) 
            {
                currentChar = numberArray[i];

                if (!romanKeys.Contains(currentChar.ToString()))
                {
                    throw new RomanNumberNotFoundException();
                }

                nextChar = i + 1 < numberArray.Length ? numberArray[i + 1] : ' ';
                Enum.TryParse(currentChar.ToString(), out RomanNumbers numberAuxEnum);
                Enum.TryParse(nextChar.ToString(), out RomanNumbers nextEnum);

                numberAux = (int)numberAuxEnum;
                next = (int)nextEnum;
                
                if (next > numberAux) 
                {
                    numberAux = -numberAux;
                }

                result += numberAux;
            }

            return result;
        }
    }
}
