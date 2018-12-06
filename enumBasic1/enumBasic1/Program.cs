using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            try // If error, display an error to the console
            {
                Console.WriteLine("What is the day of the week today?"); // Prompt the user to enter the current day of the week
                string currentday = Console.ReadLine();
                currentday = FirstCharToUpper(currentday); // Convert the first letter to an upper case
                DaysOfWeek day = (DaysOfWeek) Enum.Parse(typeof(DaysOfWeek), currentday); // Assign the input value to a variable of the enum data type 'DaysOfWeek' I created
                Console.WriteLine(day); // Display the value

                string FirstCharToUpper(string input) // Convert the first letter to an upper case
                {
                    if (String.IsNullOrEmpty(input))
                        throw new ArgumentException("ARGH!");
                    return input.First().ToString().ToUpper() + input.Substring(1);
                }
            }
            catch (ArgumentException) // Console if an error occurs
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();            
        }
        public enum DaysOfWeek // Create an enum for the days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
