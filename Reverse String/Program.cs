namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] name = { 'J', 'u', 'n', 'a', 'i', 'd' };

            ReverseString(name);
        }
        
        public static void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            for (int i = 0; i < s.Length / 2; i++)
            {
                char c = s[left];
                s[left] = s[right];
                s[right] = c;

                left++;
                right--;
            }

            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }
    }
}
