using System.Collections;

namespace Assignment
{

    internal class Program
    {
        #region 3. You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

        //public static ArrayList ReverseArrayList(ArrayList Arr)
        //{
        //    int start = 0;
        //    int end = Arr.Count - 1;

        //    while (start < end)
        //    {
        //        object temp = Arr[start];
        //        Arr[start] = Arr[end];
        //        Arr[end] = temp;
        //        start++;
        //        end--;
        //    }

        //    return Arr;


        //} 
        #endregion


        static void Main(string[] args)
        {
            #region 1. The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm  And implement the code of this optimized bubble sort algorithm

            //int[] numbers = { 8,6,2,4 };

            //Helper<int>.Sort(numbers);

            //foreach (int i in numbers)
            //    Console.WriteLine(i);


            #endregion

            #region 2. create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.

            //Range<int> range = new Range<int>(10, 20);

            //int value = 5;
            //bool result = range.IsInRange(value);
            //int length = range.Length();

            //Console.WriteLine($"{value} is in Range : {result}");
            //Console.WriteLine($"Length = {length}");

            #endregion

            #region 3. You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList Arr = new ArrayList() { 1, 2, 3, 4, 5 };
            //ArrayList Result = ReverseArrayList(Arr);

            //foreach (int i in Result)
            //    Console.WriteLine(i);

            #endregion



        }
    }
}
