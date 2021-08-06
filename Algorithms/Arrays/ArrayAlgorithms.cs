using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public static class ArrayAlgorithms
    {
        public static int[] MergeSortedArrays(int[] arrayA, int[] arrayB)
        {
            int[] result = new int[arrayA.Length + arrayB.Length];
            var firstArraySize = arrayA.Length;
            var secondArraySize = arrayB.Length;

            int currentElementOfFirstArray = 0, currentElementOfSecondArray = 0, i = 0;


            while (currentElementOfFirstArray < firstArraySize && currentElementOfSecondArray < secondArraySize)
            {
                if (arrayA[currentElementOfFirstArray] < arrayB[currentElementOfSecondArray])
                    result[i++] = arrayA[currentElementOfFirstArray++];
                else
                    result[i++] = arrayB[currentElementOfSecondArray++];
            }

            while (currentElementOfFirstArray < firstArraySize)
                result[i++] = arrayA[currentElementOfFirstArray++];
            while (currentElementOfSecondArray < secondArraySize)
                result[i++] = arrayB[currentElementOfSecondArray++];

            return result;
        }
    }
}
