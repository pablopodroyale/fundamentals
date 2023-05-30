namespace Challenges.Beginner
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            bool canConstruct = true;
            //loop through ransom note
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (magazine.Contains(ransomNote[i]))
                {
                    magazine = magazine.Remove(magazine.IndexOf(ransomNote[i]), 1);
                }
                else
                { 
                    canConstruct = false;
                    break;
                }
            }

            return canConstruct;
        }
    }
}
