using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    [Serializable]
    public class Student
    {
        private string lastName;
        private string firstName;
        private string id;
        private string grade;
        private string course;


        // TO DO : ADD VALIDATION IN PROPERTIES
        #region Properties

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        #endregion

        public Student(string ln, string fn, string id, string course, string grade)
        {
            LastName = ln;
            FirstName = fn;
            Id = id;
            Course = course;
            Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}:{3}:{4}:{5} ", lastName, firstName, id, course, grade);
        }
    }
}
