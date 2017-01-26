using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._2
{
    public class GradeBookTest
    {
        // Main method begins program execution
        public static void Main(string[] args)
        {
            // create GradeBook object
            GradeBook gradeBook1 = new GradeBook( // invokes constructor
               "CS101 Introduction to C# Programming", "Dragomir Evgeniev");
            GradeBook gradeBook2 = new GradeBook( // invokes constructor
               "CS102 Data Structures in C#", "Evgeni Dragomirov");

            // display initial value of courseName  and CourseInstructor for each GradeBook
            Console.WriteLine("gradeBook1 course name is: {0}\ngradeBook1 course instructor name is: {1}",
               gradeBook1.CourseName, gradeBook1.CourseInstructor);
            Console.WriteLine("gradeBook2 course name is: {0}\ngradeBook2 course instructor name is: {1}",
               gradeBook2.CourseName, gradeBook2.CourseInstructor);
        } // end Main
    } // end class GradeBookTest
}
