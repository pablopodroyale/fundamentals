namespace Challenges.Beginner
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            int acum = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    acum += accounts[i][j];
                }

                if (acum > max)
                {
                    max = acum;
                }

                acum = 0;
            }

            return max;
        }
    }
}
