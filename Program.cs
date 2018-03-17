using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication

{

    class Program

    {

        public static int BinarySearch(int[] array, int value)
        {
            if (array == null) { return -1; }
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (value <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == value)
                return right;
            return -1;


            //код поиска значения value в массиве array

        }



        static void Main(string[] args)
        {
            Test5Numbers();

            TestNegativeNumbers();

            TestNonExistentElement();

            TestRepeatingNumber();

            TestEmptyArray();

            Test100001Numbers();

            Console.ReadKey();

        }
        private static void Test5Numbers()

        {

            //Тестирование поиска одного элемента в массиве из 5 элементов

            int[] array = new[] { 1, 2, 3, 4, 5 };

            if (BinarySearch(array, 4) != 3)

                Console.WriteLine("! Поиск не нашёл число 4 среди чисел { 1, 2, 3, 4, 5 }");

            else

                Console.WriteLine("Поиск одного элемента в массиве из 5 элементов работает корректно");

        }

        private static void TestNegativeNumbers()

        {

            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -3) != 2)

                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");

        }

        private static void TestNonExistentElement()

        {

            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");

        }
        private static void TestRepeatingNumber()

        {

            //Тестирование поиска  элемента, повторяющегося несколько раз

            int[] array = new[] { 1, 2, 3, 3, 4, 5, 6 };

            if (BinarySearch(array, 3) != 2)

                Console.WriteLine("! Поиск не нашёл повторяющееся число 3 среди чисел { 1, 2, 3, 3, 4, 5, 6 }");

            else

                Console.WriteLine("Поиск одного элемента, повторяющегося несколько раз, работает корректно"); ;

        }
        private static void TestEmptyArray()

        {

            //Тестирование поиска отсутствующего элемента

            int[] Array = null;

            if (BinarySearch(Array, 5) != -1)

                Console.WriteLine("! Поиск в пустом массиве работает некорректно");

            else

                Console.WriteLine("Поиск в пустом массиве работает  корректно");

        }
        private static void Test100001Numbers()

        {
            int[] array = new int[100001];
            int j = 1;
            for (int i = 0; i < 100001; i++)
            {
                array[i] = j;
                j++;
            }
            if (BinarySearch(array, 55555) != 55554)

                Console.WriteLine("! Поиск не нашел 55555 среди  100001 числа ");

            else

                Console.WriteLine("Поиск  массиве 100001 элемента работает  корректно");
        }


    }

}