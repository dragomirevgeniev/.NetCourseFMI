using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileO;
using AppLayer;

namespace CreateFileOfStudent
{
    public partial class InputFileForm : Form
    {

        private BinaryFormatter bf;
        private StreamWriter sw;
        private FileStream fs;



        public InputFileForm()
        {
            InitializeComponent();
            uiFileInput.Button1.Click += SelectFileName;
            uiFileInput.ButtonOpenFile.Click += QuitAPP;
            uiFileInput.Input += SelectFileName;


        }

        private void SelectFileName(object sender, FileOpenEventArgs args)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            string fileName = ofd.FileName;
            sw = new StreamWriter(fileName);
            bf = new BinaryFormatter();
        }

        private void SelectFileName(object sender, EventArgs args)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            string fileName = ofd.FileName;
            sw = new StreamWriter(fileName);
            bf = new BinaryFormatter();
        }

        private void QuitAPP(object sender, EventArgs args)
        {
            if (sw != null)
            {
                sw.Close();
            }
            Application.Exit();
        }

        private void SelectFileName(object sender, InputEventArgs args)
        {
            Student std1 = new Student(args.LName, args.FName, args.Id, args.Course, args.Grade);
            Student std2 = new Student(uiFileInput.LastName, uiFileInput.FirstName, 
                uiFileInput.Id, uiFileInput.Course, uiFileInput.Grade);
            // Above examples do the same


            bf.Serialize(fs, std1);

        }
    }
}
