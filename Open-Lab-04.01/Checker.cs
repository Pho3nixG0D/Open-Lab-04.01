namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            for (int i = 0; i+1 < str.Length; i++)
            {
                int x = i + 1;
                if (str[i] == str[x])
                {
                    return true;
                }
            };
            return false;



        }
    }
}
