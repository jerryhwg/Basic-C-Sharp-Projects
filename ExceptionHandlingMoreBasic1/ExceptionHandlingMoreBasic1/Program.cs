using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingMoreBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            try // use try..catch for exception handling
            {
                Console.WriteLine("How old are you? Tell me what year you were born."); // ask the year a user was born
                int birthYear = Convert.ToInt32(Console.ReadLine()); // display the birthyear
                if (birthYear <= 0) // check if user enters 0 or negative number
                {
                    throw new ArgumentException(); // catch 'ArgumentException'
                }
                Console.WriteLine("You were born in {0}", birthYear); // display the birthyear if no exception
                Console.ReadLine();
            }
            catch (ArgumentException) // display appropriate error messages if user enters 0 or negative numbers
            {
                Console.WriteLine("Please enter the valid year. No zero or negative number.");
                Console.ReadLine();
                return;
            }
            catch (Exception) // display a general message if exception caused by anything else e.g. non integer
            {
                Console.WriteLine("An error occurred. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
