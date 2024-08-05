using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T> where T : IComparable
    {
        /// 1_ primary Constraint[0:1] Helper<T> where T :class, Icomparable<T>
        ///       1. General Primary Constraint
        ///            T must be >> Class /or struct /or Enum
        ///
        ///       2. special primary Constraint(user-defined class (except sealed))
        ///            T must be point or Another class inherits from point

        /// 2_ secondary Constraint(interface Constraint [0:M] Helper<T> where T : Icomparable<T>
        ///       Icomparable<T> >> T must be Class or Struct Implementing IComparable

        /// 3_ parameterless Constructor Constraint[0:1] Helper<T> where T :class, Icomparable<T> , new ()
        ///      T must be DataType Having Accessable[Non -private] parameterless constractor
        ///      Till C# 10.0 only one constructor constraint
        ///      can’t use new ()[constructor constraint] with struct [special primary constraint]


        // T Must Be Class or Struct Implementing the Built-in Interface "IComparable"
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
