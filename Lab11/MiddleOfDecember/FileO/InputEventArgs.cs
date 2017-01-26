using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileO
{
    public delegate void InputEventHandler (object sender, InputEventArgs args);
    public class InputEventArgs : EventArgs
    {

        #region Properties
        public string LName
        {
            get;
        }

        public string FName
        {
            get;
        }

        public string Id
        {
            get;
        }

        public string Course
        {
            get;
        }

        public string Grade
        {
            get;
        } 
        #endregion

        public InputEventArgs(string ln, string fn, string id, string course, string grade)
        {
            LName = ln;
            FName = fn;
            Id = id;
            Course = course;
            Grade = grade;
        }

    }
}
