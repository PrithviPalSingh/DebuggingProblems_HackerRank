using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n, x;
            //int test_cases = 1;
            ////cin >> test_cases;

            //for (int cs = 1; cs <= test_cases; cs++)
            //{
            //    //cin >> n;
            //    n = 7;
            //    List<int> a = new List<int>();
            //    //for (int i = 0; i < n; i++)
            //    //{
            //    //    //cin >> x;
            //    //    x=
            //    //    a.push_back(x);
            //    //}
            //    a.Add(1);
            //    a.Add(2);
            //    a.Add(3);
            //    a.Add(4);
            //    a.Add(5);
            //    a.Add(6);
            //    a.Add(7);
            //   // a.Add(8);
            //    findZigZagSequence(a, n);
            //}

            //int result = findLuckyDates(02, 08, 2025, 04, 09, 2025);
            //Console.WriteLine(result);

            for (long x = 1092025; x <= 4092025; x = x + 1000000)
            {
                if (x % 4 == 0 && x % 7 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.Read();
        }

        static void findZigZagSequence(List<int> a, int n)
        {
            //sort(a.begin(), a.end());
            a.Sort();
            int mid = n / 2;
            swap(a, mid, n - 1);

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                swap(a, st, ed);
                st = st + 1;
                ed = ed - 1;
            }
            for (int i = 0; i < n; i++)
            {
                //if (i > 0) cout << " ";
                //cout << a[i];

                if (i > 0)
                    Console.WriteLine(" ");

                Console.WriteLine(a[i]);
            }
            //cout << endl;
            Console.WriteLine();
        }

        private static void swap(List<int> a, int x, int y)
        {
            int swap = a[x];
            a[x] = a[y];
            a[y] = swap;

        }

        static int[] month = new int[15];

        static void updateLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                month[2] = 29;
            }
            else if (year % 100 == 0)
            {
                month[2] = 28;
            }
            else if (year % 4 == 0)
            {
                month[2] = 29;
            }
            else
            {
                month[2] = 28;
            }
        }

        static void storeMonth()
        {
            month[1] = 31;
            month[2] = 28;
            month[3] = 31;
            month[4] = 30;
            month[5] = 31;
            month[6] = 30;
            month[7] = 31;
            month[8] = 31;
            month[9] = 30;
            month[10] = 31;
            month[11] = 30;
            month[12] = 31;
        }

        static int findLuckyDates(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            storeMonth();

            int result = 0;

            while (true)
            {
                int x = d1;
                x = x * 100 + m1;
                x = x * 10000 + y1;
                if (x % 4 == 0 || x % 7 == 0)
                {
                    result = result + 1;
                }
                if (d1 == d2 && m1 == m2 && y1 == y2)
                {
                    break;
                }
                updateLeapYear(y1);
                d1 = d1 + 1;
                if (d1 > month[m1])
                {
                    m1 = m1 + 1;
                    d1 = 1;
                    if (m1 > 12)
                    {
                        y1 = y1 + 1;
                        m1 =  1;
                    }
                }
            }
            return result;
        }
    }
}
