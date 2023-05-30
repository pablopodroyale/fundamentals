namespace Challenges.Beginner
{
    public class NumberOfSteps
    {
        public int NumberOfStepsSolution(int num)
        {
            int steps = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num = (num / 2);
                }
                else
                { 
                    num -= 1;
                }

                steps++;
            }

            return steps;
        }
    }
}
