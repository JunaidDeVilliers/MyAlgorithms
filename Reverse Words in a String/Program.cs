public class Solution {
    public string ReverseWords(string s) 
    {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i].Equals(' '))
            {
                right = i - 1;
                Reverse(chars, left, right);
                left = right + 2;
            }
            else if (i == chars.Length - 1)
            {
                right = i;
                Reverse(chars, left, right);
            }
        }

        string result = new string(chars);
        
        return result;
    }
    
    public static char[] Reverse(char[] chars, int beg, int end)
    {
        double control = end - beg;
        for (int i = 0; i < control / 2; i++)
        {
            char temp = chars[beg];
            chars[beg] = chars[end];
            chars[end] = temp;

            beg++;
            end--;
        }
        return chars;
    }
}