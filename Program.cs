
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace Generics_Code

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // Console.WriteLine("Hello, World!");

            //  Using_Genericss<string>  obj= new Using_Genericss<string>("Generics");
            ////  Console.WriteLine(obj);
            //  two obj1 = new two();
            //  obj1.method<string>("Ajay");
            //  obj1.method("Ajay");
            //  //
            //  Delegatess.Add(10);

            //Console.WriteLine("Enter age");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if(age>=18 && age<=60)
            //{
            //    Console.WriteLine("Eligible");
            //}
            //else if (age<18)
            //{ Console.WriteLine("Not eligible"); }

            //else { Console.WriteLine("Stay Home"); }

            ////

            //Console.WriteLine("Enter day number");
            //int day = Convert.ToInt32(Console.ReadLine());
            //switch (day) 
            //{
            //    case 1: Console.WriteLine("Sunday");break;
            //    case 2: Console.WriteLine("Monday");break;
            //    case 3: Console.WriteLine("Tuesday"); break;
            //    case 4: Console.WriteLine("wednesday"); break;
            //    case 5: Console.WriteLine("Thrusday"); break;
            //    case 6: Console.WriteLine("Friday"); break;
            //    case 7: Console.WriteLine("Saturday"); break;

            //        default: Console.WriteLine("Days of week");break;
            //}

            //ReverseAstring words = new ReverseAstring();
            //words.reverse();

           // new NewClass<int>(10, 20);

            Console.WriteLine("Add the no of elements");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            // int[] arr = { 10, 20, 30 };
            Console.WriteLine("Enter the elements");
            foreach (int j in arr)
            {
                arr[j] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(j + " ");
            }
            Console.WriteLine("\n Plese pickup one element to delete");
            int delte = Convert.ToInt32(Console.ReadLine());
            Generic_Class<int>.DeleteElement(arr, delte);



        }
    }
}