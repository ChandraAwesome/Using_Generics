using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Code
{
    internal class Generic_Class<G>
    {
        public static void DeleteElement(G[] arr,  G delete)
        {
            int k = 0;
            G[] result = new G[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (delete.Equals(arr[i]))
                {
                    result[k] = arr[i];
                    k++;
                }

                foreach (G j in result)
                {
                    Console.Write(j + " ");
                }
            }

        }
    }
}
