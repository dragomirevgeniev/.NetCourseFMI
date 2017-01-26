using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileO
{
    public delegate void FileOpenEventHandler(object obj, FileOpenEventArgs args);

    public class FileOpenEventArgs : EventArgs
    {

    }
}
