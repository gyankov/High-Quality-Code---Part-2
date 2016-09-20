using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompareSimpleMaths;
using System.Diagnostics;

namespace CompareAdvancedMaths
{
    public class Compare
    {
        public const int LoopCount = 10000;

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Float-------------------");
            Console.WriteLine(string.Format("Square root timing: {0}", Timer(SqrtFloatTiming)));
            Console.WriteLine(string.Format("Natural logarithm timing: {0}", Timer(LogFloatTiming)));
            Console.WriteLine(string.Format("Sin timing: {0}", Timer(SinFloatTiming)));
            Console.WriteLine("-------------------Double-------------------");
            Console.WriteLine(string.Format("Square root timing: {0}", Timer(SqrtDoubleTiming)));
            Console.WriteLine(string.Format("Natural logarithm timing: {0}", Timer(LogDoubleTiming)));
            Console.WriteLine(string.Format("Sin timing: {0}", Timer(SinDoubleTiming)));
            Console.WriteLine("-------------------Decimal-------------------");
            Console.WriteLine(string.Format("Square root timing: {0}", Timer(SqrtDecimalTiming)));
            Console.WriteLine(string.Format("Natural logarithm timing: {0}", Timer(LogDecimalTiming)));
            Console.WriteLine(string.Format("Sin timing: {0}", Timer(SinDecimalTiming)));





        }

        public static TimeSpan Timer(Action act)
        {
            var timer = new Stopwatch();

            timer.Start();
            act();
            timer.Stop();
            return timer.Elapsed;
        }

        public static void SqrtFloatTiming()
        {
            float tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = (float)Math.Sqrt(i);
            }
        }

        public static void LogFloatTiming()
        {
            float tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = (float)Math.Log(i);
            }
        }

        public static void SinFloatTiming()
        {
            float tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = (float)Math.Sin(i);
            }

        }

        public static void SqrtDoubleTiming()
        {
            double tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = Math.Sqrt(i);
            }
        }

        public static void LogDoubleTiming()
        {
            double tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = Math.Log(i);
            }
        }

        public static void SinDoubleTiming()
        {
            double tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = Math.Sin(i);
            }

        }

        public static void SqrtDecimalTiming()
        {
            decimal tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = (decimal)Math.Sqrt(i);
            }
        }

        public static void LogDecimalTiming()
        {
            decimal tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = (decimal)Math.Log(i);
            }
        }

        public static void SinDecimalTiming()
        {
            decimal tempValue = 1;

            for (int i = 1; i < LoopCount * LoopCount; i++)
            {
                tempValue = (decimal)Math.Sin(i);
            }

        }

    }
}
