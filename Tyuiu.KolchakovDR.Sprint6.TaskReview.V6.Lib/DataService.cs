using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KolchakovDR.Sprint6.TaskReview.V6.Lib
{
    public class DataService 
    {
        public int[,] GetRandom(int n1, int n2, int r, int c)
        {
            Random rand = new Random();

            int[,] array = new int[r, c];

            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < c; j++)
                {
                    array[i, j] = rand.Next(n1, n2 - 1);

                    if (j % 2 != 0 )
                    {
                        if(array[i, j] > 0)
                        {
                            array[i, j] *= -1;
                        }
                        
                    }
                    if (j % 2 == 0)
                    {
                        if (array[i, j] < 0)
                        {
                            array[i, j] *= -1;
                        }
                    }
                }
            }
            return array;
        }

        public int GetMatrix(int [,] array, int c, int k, int l)
        {
            int res = 1;

            for (int i = k; i <= l; i++)
            {
                if (array[i, c] % 2 != 0)
                {
                    res *= array[i, c];
                }
            }
            return res;
        }
    }
}
