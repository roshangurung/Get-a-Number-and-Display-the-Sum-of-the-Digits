using System;

namespace Get_a_Number_and_Display_the_Sum_of_the_Digits
{
    class Program///In this C# program, we are reading a number using ‘num’ variable. Using while loop computes the sum of the digits. The digit sum of a given integer is the sum of all its digits.//
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;////Compute the modulus of the value of ‘num’ variable by 10. Divide the value of ‘num’ variable by 10. Compute the summation of the value of ‘sum’ variable with the value of ‘r’ variable. Print the sum of the digits.////
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();
        }
    }
}
////Output:Enter a Number : 123
////Sum of Digits of the Number : 6
