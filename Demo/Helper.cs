using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Generic Class

    internal static class Helper<T01> where T01 : class,ICloneable,IComparable,IComparer,new()
    {
// Generic Constraints:
// 1. Primary Constraints[0:1]
// 1.1. class
// 1.1. struct
// 1.1. special type point
//1.1. enum
//1.1. notnull

// 2. Secondary Constraints[0:M]
    //T Implement Interface

// 3. Constructor Constraints

// T: Must Be Type Which Implement The ICompareable Interface 
        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++) // 11
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }
    //public static void BubbleSort<T>(T[] Arr) where T : IComparable
    //    {
    //        if (Arr?.Length > 0)
    //        {
    //           for (int i = 0; i < Arr.Length; i++)
    //            {
    //                for (int j = 0; j < Arr.Length-i-1; j++) // 11
    //                { 
    //                   if (Arr[j].CompareTo(Arr[j + 1]) > 0)
    //                        SWAP(ref Arr[j], ref Arr[j + 1]);
    //            }
    //        }
    //    }
    //    }
        //public static void BubbleSort(int[] Arr) {

        //    if (Arr.Length > 0)
        //    {
        //        for (int i; 1 <Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length-i-1;j++) // 11
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j+1]);
        //                }
        //            }
        //        }

        //    } }

        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            for (int j = 0; j < Arr.Length; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1]) ;
        //                SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        // Generic Linear Search Method
        public static int LinearSearch<T>(T[] Arr, T Value)
        {
            if (Arr ?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {

                    if (Arr[i].Equals(Value)) return i;
                }

            }


            return -1;
        }

        public static int LinearSearch(int[] Arr, int Value) { 
if(Arr?.Length > 0)
{
                for (int i = 0; i < Arr.Length; i++)
                {

                    if (Arr[i] == Value) return 1;
                }
}

return -1;
    }

        //Generic SWAP Method
        public static void SWAP<T>(ref T X, ref T Y) {

            T Temp = X;
            X = Y;
        Y = Temp;
        }

        public static void Print(string data)
        {
            Console.WriteLine(data);
        }

//public static void Welcome<T1>(Ti t1)



public static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
            {
                Console.WriteLine(i);

            }
}

//public static void Welcome<T1>(T1 t1){}



public static void SWAP(ref int X, ref int Y)

        {
            int Temp = X;
            X = Y;
            Y = Temp;

        }

        public static void SWAP(ref double X, ref double Y) {

            double Temp = X;
            X = Y;
            Y = Temp;
            }

        public static void SWAP(ref Point X, ref Point Y)
        {

            Point Temp = X;
            X = Y;
            Y = Temp;
        }
    }
}
