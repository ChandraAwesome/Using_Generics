using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Code
{
    public class Using_Genericss<S>
    {
        public Using_Genericss(S msg, int v)
        {
            Console.WriteLine(msg);
        }
    }

    public  class two
    {
        public void method<S>(S msg1)
        {
            Console.WriteLine(msg1);
        }
    }

    public class NewClass<D>
    {
        public NewClass(D firstvalue, D secondvalue)
        {
            Console.WriteLine("Adding the both input value : "+firstvalue+secondvalue);
        }
    }
}
