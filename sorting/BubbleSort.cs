using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSort
    {
        public static void Sort(int[] a, int n)
        {
            int x, j, temp;

            for(x = n - 2; x >=0; x--)
            {
                for (j = 0; j <= x; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }
}
