//Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace CCAD16_Assignment5_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of numbers, each separated by a space: ");
            string userInput = Console.ReadLine();
            int[] userArray = userInput.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"Your string of numbers is: [{string.Join(" , ", userArray)}]");

            int sum = 0;

            for (int i = 0; i < userArray.Length; i++)
            {
                sum += userArray[i];
            }

            Console.WriteLine($"The sum of your array is: {sum}");
        }
    }
}
