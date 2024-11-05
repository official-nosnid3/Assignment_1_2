using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1_2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /* Assignment 1.2.1
             * Write a C# Sharp program to accept two integers and check whether they are equal or not.
             * Test Data :
             * Input 1st number: 5
             * Input 2nd number: 5
             * Expected Output :
             * 5 and 5 are equal
             * Test Data :
             * Input 1st number: 5
             * Input 2nd number: 15
             * Expected Output :
             * 5 and 15 are not equal */

            Console.WriteLine("Input an integer:");
            int integerOne = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("\nInput a second integer:");
            int integerTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((integerOne == integerTwo) ? $"\n{integerOne} and {integerTwo} are equal." : $"\n{integerOne} and {integerTwo} are not equal.");


            /* Assignment 1.2.2
             * Write a C# Sharp program to find the sum of first 10 natural numbers.
             * Expected Output :
             * The first 10 natural number is :
             * 1 2 3 4 5 6 7 8 9 10
             * The Sum is : 55 */

            int sum = 0;
            for (int i = 0; i < 10; i++)
                sum += i + 1;
            Console.WriteLine("\n\nThe first 10 natural numbers are: \n1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine($"\nThe sum of these numbers is: {sum}");


            /* Assignment 1.2.3
             * Write a menu driven application to perform calculation functions like 
             * addition, subtraction, multiplication, and division. 
             * Call them appropriately when user selects the option. 
             * Give the user the option to continue or exit the program. */

}
}
