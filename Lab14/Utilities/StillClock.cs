using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Utilities
{
    public class StillClock : Panel
    {
        private int hour;
        private int minute;
        private int second;

        /** Construct a default clock with the current time*/
        public StillClock()
        {
            this.Size = new Size(200, 200);
            this.Paint += OnPaint;
            setCurrentTime();
        }

        /** Construct a clock with specified hour, minute, and second */
        public StillClock(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        /** Return hour */
        public int getHour()
        {
            return hour;
        }

        /** Set a new hour */
        public void setHour(int hour)
        {
            this.hour = hour;
            this.Refresh();
        }

        /** Return minute */
        public int getMinute()
        {
            return minute;
        }

        /** Set a new minute */
        public void setMinute(int minute)
        {
            this.minute = minute;
            this.Refresh();
        }

        /** Return second */
        public int getSecond()
        {
            return second;
        }

        /** Set a new second */
        public void setSecond(int second)
        {
            this.second = second;
            this.Refresh();
        }

        /** Draw the clock */
        private void OnPaint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            // Initialize clock parameters
            int clockRadius =
              (int)(Math.Min(this.Size.Width, this.Size.Height) * 0.8 * 0.5);
            float xCenter = Size.Width / 2.0f;
            float yCenter = Size.Height / 2.0f;

            // Draw circle
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, xCenter - clockRadius, yCenter - clockRadius,
              2 * clockRadius, 2 * clockRadius);

            g.DrawString("12", new Font("System", 8), new SolidBrush(Color.Black), xCenter - 5f, yCenter - clockRadius + 12f - 10);
            g.DrawString("9", new Font("System", 8), new SolidBrush(Color.Black), xCenter - clockRadius + 3f, yCenter + 5f - 10);
            g.DrawString("3", new Font("System", 8), new SolidBrush(Color.Black), xCenter + clockRadius - 10f, yCenter + 3f - 10);
            g.DrawString("6", new Font("System", 8), new SolidBrush(Color.Black), xCenter - 3f, yCenter + clockRadius - 3f - 10);

            // Draw second hand
            int sLength = (int)(clockRadius * 0.8);
            int xSecond = (int)(xCenter + sLength *
              Math.Sin(second * (2 * Math.PI / 60)));
            int ySecond = (int)(yCenter - sLength *
              Math.Cos(second * (2 * Math.PI / 60)));

            g.DrawLine(new Pen(Color.Red), xCenter, yCenter, xSecond, ySecond);

            // Draw minute hand
            int mLength = (int)(clockRadius * 0.65);
            int xMinute = (int)(xCenter + mLength *
              Math.Sin(minute * (2 * Math.PI / 60)));
            int yMinute = (int)(yCenter - mLength *
              Math.Cos(minute * (2 * Math.PI / 60)));

            g.DrawLine(new Pen(Color.Blue), xCenter, yCenter, xMinute, yMinute);

            // Draw hour hand
            int hLength = (int)(clockRadius * 0.5);
            int xHour = (int)(xCenter + hLength *
              Math.Sin((hour % 12 + minute / 60.0) * (2 * Math.PI / 12)));
            int yHour = (int)(yCenter - hLength *
              Math.Cos((hour % 12 + minute / 60.0) * (2 * Math.PI / 12)));

            g.DrawLine(new Pen(Color.Black), (float)xCenter, (float)yCenter, (float)xHour, (float)yHour);
        }

        public void setCurrentTime()
        {
            // Construct a calendar for the current date and time


            // Set current hour, minute and second
            this.hour = DateTime.Now.Hour;
            this.minute = DateTime.Now.Minute;
            this.second = DateTime.Now.Second;
        }

    }
}
