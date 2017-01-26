using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileO
{
    public partial class UIFileInput : UserControl
    {

        public event FileOpenEventHandler FileOpen;
        public event InputEventHandler Input;

        private string lastName;
        private string firstName;
        private string id;
        private string grade;
        private string course;

        #region Properties

        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        public string Id
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }

        public string Course
        {
            get { return txtCourse.Text; }
            set { txtCourse.Text = value; }
        }

        public string Grade
        {
            get { return txtGrade.Text; }
            set { txtGrade.Text = value; }
        } 
        #endregion

        public Button ButtonOpenFile
        {
            get
            {
                return btnOpenFile;
            }
        }

        public Button Button1
        {
            get
            {
                return btnButton1;
            }
        }

        public Button ButtonReadFromFile
        {
            get
            {
                return btnReadFromFile;
            }
        }

        public Button ButtonWriteInFile
        {
            get
            {
                return btnWriteInFile;
            }
        }

        public UIFileInput()
        {
            InitializeComponent();
        }

        private void UIFileInput_Load(object sender, EventArgs e)
        {

        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWriteInFile_Click(object sender, EventArgs e)
        {
            if (FileOpen != null)
            {
                FileOpen(this, new FileOpenEventArgs());
            }
        }

        // Button1
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpen != null)
            {
                FileOpen(this, new FileOpenEventArgs());
            }
        }

        //Button3
        private void btnButton1_Click(object sender, EventArgs e)
        {
            if (Input != null)
            {
                Input(this, new InputEventArgs(txtLastName.Text, txtFirstName.Text,
                    txtID.Text, txtCourse.Text, txtGrade.Text));
            }
        }
    }
}
