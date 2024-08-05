using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Helper<T> where T : IComparable<T>
    {
        public static void Sort(T[] Arr)
        {
            bool SWAP;

            for (int i = 0; i < Arr.Length; i++)
            {
                SWAP = false;

                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                    {
                        T temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                        SWAP = true;
                    }
                }

                if (SWAP == false)
                    break;
            }

        }
    }
}
