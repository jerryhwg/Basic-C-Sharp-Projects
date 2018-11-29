using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main()
        {
        // 1: Create a list of integers. Ask the user for a number to divide each number in the list by.
        // Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

        try
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
            Console.WriteLine("Input your number to divide a list of numbers: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two and results are: ");

            foreach (var number in numbers)
            {
                int result = number / yourNumber;
                Console.WriteLine(result);
            }
        }
        catch (DivideByZeroException msg)
        {
            Console.WriteLine("zero is not a valid number to divide.");
        }
        catch (FormatException msg)
        {
            Console.WriteLine("string is not a vaild input, use an integer.");
        }
        catch (Exception msg)
        {
            Console.WriteLine(msg.Message);
        }
        finally
        {
            Console.WriteLine("The result is recorded.");
        }

        // 2: Run that code, entering in non-zero numbers as the user. Look at the displayed results.
        // Result: 2, 4, 6, 8, 10

        // 3: Run that code, entering in zero as the number to divide by. Note any error messages you get.
        // Result: Exception error "System.DivideByZeroException: 'Attempted to divide by zero.'"

        // 4: Run that code, entering in a string as the number to divide by. Note any error messages you get.
        // Result: Exception error "System.FormatException: 'Input string was not in a correct format.'"

        // 5: Now put the loop in a try/catch block.
        // Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
        // In the catch block, display the error message to the screen. 
        // Then try various combinations of user input: valid numbers, zero and a string.
        // Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

        Console.ReadLine();
    }
}