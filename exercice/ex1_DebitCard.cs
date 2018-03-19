using System;

namespace ex01_DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {forthNum:D4}");
        }
    }
}
