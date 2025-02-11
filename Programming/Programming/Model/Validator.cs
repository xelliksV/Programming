using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Programming.Model
{
    internal static class Validator
    {
        public static bool assertOnPositiveValue(int value)
        {
            StackTrace trace = new StackTrace();
            if (value >= 0) return true;
            else
            {
                throw new ArgumentException("Некорректное значение " + trace.GetFrame(trace.FrameCount-5).GetMethod().Name);
            }
        }
        public static bool assertOnPositiveValue(double value)
        {
            StackTrace trace = new StackTrace();
            if (value >= 0) return true;
            else
            {
                throw new ArgumentException("Некорректное значение " + trace.GetFrame(trace.FrameCount - 5).GetMethod().Name);
            }
        }
        public static bool assertValueInRange(int value, int min, int max)
        {
            StackTrace trace = new StackTrace();
            if (value > min && value < max)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Некорректное значение " + trace.GetFrame(trace.FrameCount - 5).GetMethod().Name);
            }
        }
        public static bool assertValueInRange(double value, int min, int max)
        {
            StackTrace trace = new StackTrace();
            if (value > min && value < max)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Некорректное значение " + trace.GetFrame(trace.FrameCount - 5).GetMethod().Name);
            }
        }
    }
}
