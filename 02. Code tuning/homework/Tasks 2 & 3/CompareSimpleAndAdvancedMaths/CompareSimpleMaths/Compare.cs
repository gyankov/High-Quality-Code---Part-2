using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    // public delegate void MyDelegate(string operat, string type); 
    class Compare
    {
        public const int LoopCount = 10000;

        static void Main(string[] args)
        {

            // Sorry for the copy-paste driven development, but for reseaching purposes it's okeyish (i guess)
            Console.WriteLine("-------------------Int-------------------");
            Console.WriteLine(string.Format("Summing timing: {0}", Timer(SumIntTiming)));
            Console.WriteLine(string.Format("Substracting timing: {0}", Timer(SubstractIntTiming)));
            Console.WriteLine(string.Format("Incrementing timing: {0}", Timer(IncrementIntTiming)));
            Console.WriteLine(string.Format("Multiplying timing: {0}", Timer(MultiplyIntTiming)));
            Console.WriteLine(string.Format("Dividing timing: {0}", Timer(DivideIntTiming)));
            Console.WriteLine("-------------------Long-------------------");
            Console.WriteLine(string.Format("Summing timing: {0}", Timer(SumLongTiming)));
            Console.WriteLine(string.Format("Substracting timing: {0}", Timer(SubstractLongTiming)));
            Console.WriteLine(string.Format("Incrementing timing: {0}", Timer(IncrementLongTiming)));
            Console.WriteLine(string.Format("Multiplying timing: {0}", Timer(MultiplyLongTiming)));
            Console.WriteLine(string.Format("Dividing timing: {0}", Timer(DivideLongTiming)));
            Console.WriteLine("-------------------Float-------------------");
            Console.WriteLine(string.Format("Summing timing: {0}", Timer(SumFloatTiming)));
            Console.WriteLine(string.Format("Substracting timing: {0}", Timer(SubstractFloatTiming)));
            Console.WriteLine(string.Format("Incrementing timing: {0}", Timer(IncrementFloatTiming)));
            Console.WriteLine(string.Format("Multiplying timing: {0}", Timer(MultiplyFloatTiming)));
            Console.WriteLine(string.Format("Dividing timing: {0}", Timer(DivideFloatTiming)));
            Console.WriteLine("-------------------Double-------------------");
            Console.WriteLine(string.Format("Summing timing: {0}", Timer(SumDoubleTiming)));
            Console.WriteLine(string.Format("Substracting timing: {0}", Timer(SubstractDoubleTiming)));
            Console.WriteLine(string.Format("Incrementing timing: {0}", Timer(IncrementDoubleTiming)));
            Console.WriteLine(string.Format("Multiplying timing: {0}", Timer(MultiplyDoubleTiming)));
            Console.WriteLine(string.Format("Dividing timing: {0}", Timer(DivideDoubleTiming)));
            Console.WriteLine("-------------------Decimal-------------------");
            Console.WriteLine(string.Format("Summing timing: {0}", Timer(SumDecimalTiming)));
            Console.WriteLine(string.Format("Substracting timing: {0}", Timer(SubstractDecimalTiming)));
            Console.WriteLine(string.Format("Incrementing timing: {0}", Timer(IncrementDecimalTiming)));
            Console.WriteLine(string.Format("Multiplying timing: {0}", Timer(MultiplyDecimalTiming)));
            Console.WriteLine(string.Format("Dividing timing: {0}", Timer(DivideDecimalTiming)));


        }




        public static TimeSpan Timer(Action act)
        {
            var timer = new Stopwatch();

            timer.Start();
            act();
            timer.Stop();
            return timer.Elapsed;
        }



        public static void SumIntTiming()
        {
            int tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i + j;
                }
            }
        }

        public static void SubstractIntTiming()
        {
            int tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i - j;
                }
            }
        }

        public static void IncrementIntTiming()
        {
            int tempValue = 0;

            for (int i = 0; i < LoopCount * LoopCount; i++)
            {
                tempValue++;
            }

        }

        public static void MultiplyIntTiming()
        {
            int tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i * j;
                }
            }
        }

        public static void DivideIntTiming()
        {
            int tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 1; j < LoopCount; j++)
                {
                    tempValue = i / j;
                }
            }
        }


        public static void SumLongTiming()
        {
            long tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i + j;
                }
            }
        }

        public static void SubstractLongTiming()
        {
            long tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i - j;
                }
            }
        }

        public static void IncrementLongTiming()
        {
            long tempValue = 0;

            for (int i = 0; i < LoopCount * LoopCount; i++)
            {
                tempValue++;
            }

        }

        public static void MultiplyLongTiming()
        {
            long tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i * j;
                }
            }
        }


        public static void DivideLongTiming()
        {
            long tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 1; j < LoopCount; j++)
                {
                    tempValue = i / j;
                }
            }
        }

        public static void SumFloatTiming()
        {
            float tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i + j;
                }
            }
        }

        public static void SubstractFloatTiming()
        {
            float tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i - j;
                }
            }
        }

        public static void IncrementFloatTiming()
        {
            float tempValue = 0;

            for (int i = 0; i < LoopCount * LoopCount; i++)
            {
                tempValue++;
            }

        }

        public static void MultiplyFloatTiming()
        {
            float tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i * j;
                }
            }
        }


        public static void DivideFloatTiming()
        {
            float tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 1; j < LoopCount; j++)
                {
                    tempValue = i / j;
                }
            }
        }

        public static void SumDoubleTiming()
        {
            double tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i + j;
                }
            }
        }

        public static void SubstractDoubleTiming()
        {
            double tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i - j;
                }
            }
        }

        public static void IncrementDoubleTiming()
        {
            double tempValue = 0;

            for (int i = 0; i < LoopCount * LoopCount; i++)
            {
                tempValue++;
            }

        }

        public static void MultiplyDoubleTiming()
        {
            double tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i * j;
                }
            }
        }


        public static void DivideDoubleTiming()
        {
            double tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 1; j < LoopCount; j++)
                {
                    tempValue = i / j;
                }
            }
        }

        public static void SumDecimalTiming()
        {
            decimal tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i + j;
                }
            }
        }

        public static void SubstractDecimalTiming()
        {
            decimal tempValue = 0;

            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i - j;
                }
            }
        }

        public static void IncrementDecimalTiming()
        {
            decimal tempValue = 0;

            for (int i = 0; i < LoopCount * LoopCount; i++)
            {
                tempValue++;
            }

        }

        public static void MultiplyDecimalTiming()
        {
            decimal tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 0; j < LoopCount; j++)
                {
                    tempValue = i * j;
                }
            }
        }


        public static void DivideDecimalTiming()
        {
            decimal tempValue = 0;
            for (int i = 0; i < LoopCount; i++)
            {
                for (int j = 1; j < LoopCount; j++)
                {
                    tempValue = i / j;
                }
            }
        }
    }
}
