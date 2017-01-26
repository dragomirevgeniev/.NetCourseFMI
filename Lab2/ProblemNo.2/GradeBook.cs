using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._2
{
    public class GradeBook
    {
        private string courseName; // course name for this GradeBook
        private string courseInstructor; // course instructor name

        // constructor initializes courseName with string supplied as argument
        public GradeBook(string courseName, string courseInstructor)
        {
            CourseName = courseName; // initialize courseName using property
            CourseInstructor = courseInstructor; // initialize CourseInstructor using property
        } // end constructor

        // property to get and set the course name
        public string CourseName
        {
            get
            {
                return courseName;
            } // end get
            set
            {
                courseName = value;
            } // end set
        } // end property CourseName

        public string CourseInstructor { get; set; } // property to get and set the course instructor name

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            // use properties CourseName and CourseInstructor to get the 
            // name of the course that this GradeBook represents and its instructor
            Console.WriteLine("Welcome to the grade book for\n{0}!\nThis course is presented by:\n{1}",
               CourseName, CourseInstructor);
        } // end method DisplayMessage
    } // end class GradeBook

}
