using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpGenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo of Using Generics

            //Creates a list of strings
            List<string> nameList = new List<string>();

            //Creates a list of ints
            List<int> numberList = new List<int>();         

            //Demo of calling your own Generic method (see method down below)
            Console.WriteLine("** Generics **");

            //Swap 2 strings
            string cd = "Thing One";
            string ef = "Thing Two";
            Console.WriteLine($"Before swap, cd contains {cd} and ef contains {ef}.");
            SwapEm<string>(ref cd, ref ef);
            Console.WriteLine($"After swap, cd contains {cd} and ef contains {ef}.");

            //Swap 2 ints
            int ij = 5;
            int kl = 7;
            Console.WriteLine($"Before swap, ij contains {ij} and kl contains {kl}.");
            SwapEm<int>(ref ij, ref kl);
            Console.WriteLine($"After swap, ij contains {ij} and kl contains {kl}.");

            Console.ReadKey();
        }

        //Generic method
        /// <summary>
        /// Generic method that simply swaps 2 values passed in
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="thingOne"></param>
        /// <param name="thingTwo"></param>
        private static void SwapEm<T>(ref T thingOne, ref T thingTwo)
        {
            //Note that any time you see "T", thing of it as "whatever data type is passed in"
            //  At Run Time, T may turn into "string" or "int" or "long" or whatever
            T temp;
            temp = thingOne;
            thingOne = thingTwo;
            thingTwo = temp;
        }
    }

   
}

