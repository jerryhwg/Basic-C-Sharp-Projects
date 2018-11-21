using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseTitle = Console.ReadLine(); 
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string helpNeed = Console.ReadLine();
            bool helpNeedStatus = Convert.ToBoolean(helpNeed);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiencesShare = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedbackComment = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Your are on the course: " + courseTitle);
            Console.WriteLine("Your are on the page: " + pageNum);
            Console.WriteLine("Your answer for any help: " + helpNeedStatus);
            Console.WriteLine("Your positivfe experiences: " + experiencesShare);
            Console.WriteLine("Your other feedback: " + feedbackComment);
            Console.WriteLine("You studied " + studyHoursNum + " hours today!");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
