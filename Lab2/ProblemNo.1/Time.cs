using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemNo._1
{
    public class Time
    {
        #region Fields
        private int hour;
        private int minute;
        private int second;
        #endregion

        #region Constructos
        public Time() { }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        #endregion

        #region Properties
        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                if (value <= 24 && hour >= 0)
                {
                    hour = value;
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }

            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                if (value >= 0 && value < 60)
                {
                    second = value;
                }
            }
        }
        #endregion
    }
}