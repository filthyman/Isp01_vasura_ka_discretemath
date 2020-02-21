using System;
using System.Collections.Generic;
namespace List_calsswork
{
    class Program
    {
        static List<int> ConverterToPositiveNumber(List<int> array)
        {
            List<int> resArr = array.FindAll(i => i >= 0);
            return resArr;
            
        }

        static List<int> NumberInsertionAfterPositiveNumbers(List<int> array, int number)
        {
            List<int> resArr = new List<int>();

            resArr.AddRange(array);
            
            for (int index = 0; index < array.Count; index++)
            {
                int okNumIndex = array.FindIndex(i => i > 0);
                resArr.Insert(okNumIndex + 1, number);
                

            }

            return array;

        }

        static List<int> findElement(List<int> array, int number) 
        {
            List<int> resultArr = new List<int>();
            if (array == null || array.Count < 2)
                return array;

            for (int index = 0; index < array.Count; index++)
            {
                if (array[index] == array.Find(i => i == number))
                {
                    array.Remove(array[index]);
                }
            }
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
            List<int> set = new List<int>() { 1, -3, 0, -10, 4, -32 };
            foreach (var item in findElement(set, 1))
                Console.Write(item + " ");

            List<int> set2 = new List<int>() { 1, -3, 0, -10, 4, -32 };
            Console.WriteLine();
            foreach (var item in ConverterToPositiveNumber(set2))
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
