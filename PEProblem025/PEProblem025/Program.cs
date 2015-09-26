using System;
/*
 * The Fibonacci sequence is defined by the recurrence relation:
 * Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
 * 
 * Hence the first 12 terms will be:
 * F1 = 1
 * F2 = 1
 * F3 = 2
 * F4 = 3
 * F5 = 5
 * F6 = 8
 * F7 = 13
 * F8 = 21
 * F9 = 34
 * F10 = 55
 * F11 = 89
 * F12 = 144
 * 
 * The 12th term, F12, is the first term to contain three digits.
 * 
 * What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
 */
namespace PEProblem025
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int fnNumber = 3;
            int[] fn2 = new int[1004];
            int[] fn1 = new int[1004];

            for (int i = 0; i < 1004; i++)
            {
                fn1[i] = 0;
                fn2[i] = 0;
            }

            fn1[0] = 1;
            fn2[0] = 1;
            int tmp = 0;
            int tmp2 = 0;

            while (fn2[999] == 0)
            {
                tmp = 0;
                tmp2 = 0;

                if (fnNumber % 2 == 0)
                {
                    for (int i = 0; i < 1004; i++)
                    {
                        tmp = fn1[i] + fn2[i] + tmp2;
                        tmp2 = tmp / 10;
                        fn2[i] = tmp - tmp2 * 10;
                    }
                }
                else
                {
                    for (int i = 0; i < 1004; i++)
                    {
                        tmp = fn1[i] + fn2[i] + tmp2;
                        tmp2 = tmp / 10;
                        fn1[i] = tmp - tmp2 * 10;
                    }
                }
                fnNumber++;
            }
            fnNumber--;

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + fnNumber.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
