using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate Tout SortingTypesDelegate<T1,T2,out Tout>(T1 a, T2 b);

    internal static class SortingAlgorithms<T> 
    {

        public static void BubbleSort(T[] arr, SortingTypesDelegate<T,T,bool> predicate)
        {
            if (arr?.Length > 0 && predicate is not null)
            { 
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - i - 1; j++)  
                        //if (arr[j] > arr[j + 1])
                        //if(predicate?.Invoke(arr[j],arr[j + 1]) ?? false) // this wrong
                        if(predicate.Invoke(arr[j],arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
            }
        }

        //public static void BubbleSort(int[] arr,Func<int,int,bool> predicate)
        //{
        //    if (arr?.Length > 0)
        //    { 
        //        int n = arr.Length;
        //        for (int i = 0; i < n - 1; i++)
        //            for (int j = 0; j < n - i - 1; j++)  
        //                //if (arr[j] > arr[j + 1])
        //                if(predicate.Invoke(arr[j],arr[j + 1]))
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //    }
        //}
        //public static void BubbleSortDesc(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    { 
        //        int n = arr.Length;
        //        for (int i = 0; i < n - 1; i++)
        //            for (int j = 0; j < n - i - 1; j++)  
        //                if (arr[j] < arr[j + 1])
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //    }
        //}

        public static void Swap(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
