using System;

namespace palindrome_number__
{
    class Program
    {
        /*
          Write a function called palindrome_number() that takes one integer number as parameter. The function will find if the number is palindrome or not and then print the results on the screen.
        Note: A palindromic number is a number (such as 16461) that remains the same when its digits are reversed.
        Input: 121
        Output: palindrome number
        Input: 113
        Output: Not palindrome numbe
        */
        static void Main(string[] args)
        {
            int num, tem, revnum = 0, rem;
            Console.WriteLine("Please enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            tem = num; 
            while(num>0)
            { rem = num % 10;
                revnum = revnum * 10 + rem;
                num = num / 10;
            }

            if (revnum == tem)
                Console.WriteLine("number is Palindrome.");
            else
                Console.WriteLine("number is not Palindrome.");

            Console.ReadLine();

        }

    }
}
