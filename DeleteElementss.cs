using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class DeleteElementss

    {
        public static void DeleteElement(int[] arr, int delete)
        {
            int k = 0;
            int[] result = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }

                foreach (int j in result)
                {
                    Console.Write(j + " ");
                }
            }

        }
        public static void DeleteElement1(double[] arr, double delete)
        {
            int k = 0;
            double[] result = new double[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }

                foreach (double j in result)
                {
                    Console.Write(j + " ");
                }
            }
        }

        public static void DeleteElement2(char[] arr, char delete)
        {
            int k = 0;
            char[] result = new char[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }

                foreach (int j in result)
                {
                    Console.Write(j + " ");
                }
            }
        }

    }
}
