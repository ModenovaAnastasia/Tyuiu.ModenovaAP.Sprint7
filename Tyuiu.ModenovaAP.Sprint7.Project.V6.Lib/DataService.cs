using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ModenovaAP.Sprint7.Project.V6.Lib
{
    public class DataService
    {
        public int TimesPatient(string[,] array, string name)
        {
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (array[i, 1] == name)
                    {
                        cnt++;
                    }
                }
                catch { }
            }
            return cnt;
        }

        public int MinTime(string[,] array, string name)
        {
            int min = 999999999;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (array[i, 1] == name)
                    {
                        try
                        {
                            min = Math.Min(min, Convert.ToInt32(array[i, 7]));
                        }
                        catch { }
                    }
                }
                catch { };
                if (min == 999999999)
                {
                    min = 0;
                }
            }
            return min;
        }

        public int MaxTime(string[,] array, string name)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (array[i, 1] == name)
                    {
                        try
                        {
                            max = Math.Max(max, Convert.ToInt32(array[i, 7]));
                        }
                        catch { }
                    }
                }
                catch { }

            }
            return max;
        }

        public int AvgTime(string[,] array, string name)
        {
            int avg = 0;
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (array[i, 1] == name)
                    {
                        try
                        {
                            avg += Convert.ToInt32(array[i, 7]);
                            cnt++;
                        }
                        catch { }
                    }
                }
                catch { }
            }
            if (cnt == 0)
            {
                return 0;
            }
            return avg / cnt;
        }   
    }
}

