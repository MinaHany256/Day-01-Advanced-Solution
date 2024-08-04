using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper
    {
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
        public static void SWAP<T>(ref T X, ref T Y)
        {
            Console.WriteLine("====== SWAP =======");
            T Temp = X;
            X = Y;
            Y = Temp;
        }

    }
}
