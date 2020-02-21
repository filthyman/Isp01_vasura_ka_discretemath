using System;
using System.Collections.Generic;
using System.Text;

namespace array_sorting
{
    class Sorting
    {
        public static void Swap(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        public static void BubbleSort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return;

            bool numberWasSwapted = false;
            while (true)
            {
                numberWasSwapted = false;
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    if (arr[index] < arr[index + 1])
                    {
                        Swap(ref arr[index], ref arr[index + 1]);

                        numberWasSwapted = true;
                    }
                }
                if (!numberWasSwapted)
                    break;
            }
        }

        public static void SelectionSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            for (int index = 0; index < array.Length; index++)
            {
                int maxIndex = index;
                for (int next = index + 1; next < array.Length; next++)
                    if (array[maxIndex] < array[next])
                        maxIndex = next;

                if (maxIndex != index)
                    Swap(ref array[index], ref array[maxIndex]);

            }
        }
    }
}
