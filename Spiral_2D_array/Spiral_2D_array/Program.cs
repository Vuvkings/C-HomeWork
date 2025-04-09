using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spiral_2D_array
{
    class Program
    {
        static int MAX = 100;
        static void spiralFill(int m, int n, int[,] a)
        {
            // Initialize value to be filled in matrix
            int val = 1;
            int iter = 1;
            /*  k - starting row index
            m - ending row index
            l - starting column index
            n - ending column index */
            int k = 0, l = 0;
            while (k < m && l < n)  //k < m && l < n
            {
                /* Print the first row from the remaining
              rows. Move right */
                for (int i = l; i < n; ++i)
                {
                    a[k, i] = val++;
                    
                }

                k++;

                /* Print the last column from the remaining
              columns. Move down */
                for (int i = k; i < m; ++i)
                {
                    a[i, n - 1] = val++;
                    
                }
                n--;

                /* Print the last row from the remaining
               rows. Move left */
                if (k < m)
                {
                    for (int i = n - 1; i >= l; --i)
                    {
                        a[m - 1, i] = val++;
                        
                    }
                    m--;
                }

                /* Print the first column from the remaining
               columns. Move up */
                if (l < n)
                {
                    for (int i = m - 1; i >= k; --i)
                    {
                        a[i, l] = val++;
                        
                    }
                    l++;
                }
            }
        }

            static void Main()
        {


            int m = 3, n = 3;
            int[,] a = new int[MAX, MAX];
            spiralFill(m, n, a);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\n");
            }
        }


    }
    
}
