using System;
using System.Collections.Generic;
namespace List_calsswork
{
    class Program
    {
        static List<int> SelectionPositiveNumber(List<int> array)
        {
            List<int> resArr = array.FindAll(i => i >= 0);
            return resArr;
        }

        static List<int> NumberInsertionAfterPositiveNumbers(List<int> array, int number)
        {
            List<int> resArr = new List<int>();

            for (int index = 0; index < array.Count; index++)
            {
                if (array[index] > 0)
                {
                    resArr.Add(array[index]);
                    resArr.Add(number);
                }
                else
                    resArr.Add(array[index]);
            }
            return resArr;
        }

        static List<int> RemoveInappriateNumbers(List<int> array) 
        {
            array.RemoveAll(i => i % 2 < 0 || i == 0 || i == 1);
            return array;
        }

        static List<int> tryToCovertInNumbers(List<string> set) 
        {
            List<int> resultSet = new List<int>(10);
            int result = 0;
            for (int index = 0, resultSetValue = 0; index < set.Count; index++)
            {
                bool success = Int32.TryParse(set[index], out result);
                if (success)
                {
                    resultSet.Insert(resultSetValue,result);
                    resultSetValue++;
                }
            }
            return resultSet;


        }
        static void Main()
        {
            List<int> set = new List<int>() { 1, -3, 0, -10, 4, -32, 5, 20 };
            foreach (var item in RemoveInappriateNumbers(set))
                Console.Write(item + " ");

            List<int> set2 = new List<int>() { 1, -3, 0, -10, 4, -32 };
            Console.WriteLine();
            foreach (var item in SelectionPositiveNumber(set2))
                Console.Write(item + " ");

            List<int> set3 = new List<int>() { 1, -3, 0, -10, 4, -32 };
            Console.WriteLine();
            foreach (var item in NumberInsertionAfterPositiveNumbers(set3, 8))
                Console.Write(item + " ");

            Console.WriteLine();
            List<string> setString = new List<string>() { "Если это вывелось, значит где то ошибка", "12", " 12" };
            foreach (var item in tryToCovertInNumbers(setString))
                Console.Write(item + " ");






        }
    }
}
