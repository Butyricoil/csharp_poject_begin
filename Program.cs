using System;

public class Program
{
    public bool IsPalindrome(int x)
    {
        int last = 0;
        int palindrom = 0;

        while (x > 0)
        {
            last = x % 10;
            palindrom = palindrom * 10 + last;
            x = x / 10;
        }

        if (palindrom == x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Main(string[] args)
    {
        Program solution = new Program();
        Console.WriteLine(solution.IsPalindrome(121));
    }
}