using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox
{
    public class ListBoxTest
    {
        private string[] myStrings;
        private int counter;

        /// <summary>
        /// Properties
        /// </summary>
        #region Properties
        public string[] MyStrings
        {
            get
            {
                return myStrings;
            }
            set
            {
                if (value != null && value.Length != 0)
                {
                    myStrings = value;
                }
            }
        }
        public int Counter
        {
            get
            {
                return counter;
            }
            private set
            {
                counter = value;
            }
        }
        #endregion

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="i">The current index</param>
        /// <returns></returns>
        public string this[int i]
        {
            get
            {
                return myStrings[i];
            }
            set
            {
                MyStrings[i] = value;
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="myStrings"></param>
        #region Constructors
        public ListBoxTest(string[] myStrings)
        {
            MyStrings = myStrings;
            Counter = myStrings.Length;
        }

        public ListBoxTest() : this(new string[] { string.Empty })
        {
            Counter = 0;
        }

        public ListBoxTest(ListBoxTest listBox) : this(listBox.MyStrings)
        {
            Counter = listBox.Counter;
        }
        #endregion
    }
}
