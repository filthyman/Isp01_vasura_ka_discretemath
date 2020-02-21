using System;

namespace array_sorting
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] bubbleArray = { 6, 10, 5, 3, 2, 1 };
            Sorting.BubbleSort(bubbleArray);

            int[] selectonArray = { 6, 10, 5, 3, 2, 1 };
            Sorting.SelectionSort(selectonArray);

            Console.WriteLine("Сортировка пузырьком:");
            foreach (var item in bubbleArray)
                Console.Write(item + " ");

            Console.WriteLine();
            Console.WriteLine("Сортировка выборкой:");
            foreach (var item in selectonArray)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
