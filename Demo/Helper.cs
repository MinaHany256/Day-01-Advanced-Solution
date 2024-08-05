using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T> where T : IComparable
    {   // T Must Be Class or Struct Implementing the Built-in Interface "IComparable"
        public static void Sort(T[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    //if (Arr[j] > Arr[j + 1])
                    if (Arr[j].CompareTo(Arr[j+1]) == 1)
                        SWAP(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }

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
