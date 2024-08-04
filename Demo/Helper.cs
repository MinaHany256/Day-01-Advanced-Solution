using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T> 
    {
        #region Generic SWAP - Example 01
        #region Non - Generic
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    Console.WriteLine("====== SWAP =======");
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    Console.WriteLine("====== SWAP =======");
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Console.WriteLine("====== SWAP =======");
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion


        // Generic Type
        public static void SWAP(ref T X, ref T Y)
        {
            Console.WriteLine("====== SWAP =======");
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion

        #region Generic Search - Example 02
        public static int Search(T[] Arr, T Value)
        {
            if (Arr is not null && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                        return i;
                }
            }
            return -1;
        } 
        #endregion

    }
}
