using System;	
 	 
namespace ConsoleApplication	
	
{	
	
    class Program	
	
    {	
	
        public static int BinarySearch(int[] array, int value)	
	
        {	
            {	
                var left = 0;	
                var right = array.Length - 1;	
                while (left < right)	
                {	
                    var middle = (right + left) / 2;	
                    if (value <= array[middle])	
                        right = middle;	
                    else left = middle + 1;	
                }	
                if (right >= 0 && array[right] == value)	
                    return right;	
                return -1;	
            }	
       }	
	
        static void Main(string[] args)	
	
        {	
            TestOneElement();	
	
            TestNegativeNumbers();	
	
            TestNonExistentElement();	
	
            TestReElement();	
	
            TestEmptyMassive();	
	
            TestBigMassive();	
	
            Console.ReadKey();	
	
        }	
	
        private static void TestOneElement()	
        {	
            int[] negativeNumbers = new[] { 1, 2, 3, 4, 5 };	
	
            if (BinarySearch(negativeNumbers, 3) != 2)	
	
                Console.WriteLine("! Поиск не нашёл число 3 среди чисел { 1, 2, 3, 4, 5 }");	
	
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
	
        private static void TestReElement()	
        {	
            int[] negativeNumbers = new[] { 1, 2, 3, 4, 4, 5 };	
	
            if (BinarySearch(negativeNumbers, 4) != 3)	
	
                Console.WriteLine("! Поиск не нашёл число 4 среди чисел { 1, 2, 3, 4, 4, 5 }");	
	
            else	
	
                Console.WriteLine("Поиск элемента, повторяющегося несколько раз работает корректно");	
        }	
	
	
        private static void TestEmptyMassive()	
        {	
            int[] negativeNumbers = new int[0];	
	
            if (BinarySearch(negativeNumbers, 4) != -1)	
	
                Console.WriteLine("! Поиск не нашёл число 4 в пустом массиве");	
	
            else	
	
                Console.WriteLine("Поиск в пустом массиве работает корректно");	
        }	
	
        private static void TestBigMassive()	
        {	
            int[] numbers = new int[100001];	
            numbers[0] = 1;	
            for (var i = 1; i < numbers.Length; i++)	
                numbers[i] = 2;	
	
            if (BinarySearch(numbers, 1) != 0)	
	
                Console.WriteLine("! Поиск не нашёл число 1 в пустом массиве");	
	
            else	
	
                Console.WriteLine("Поиск в массиве из 100001 элементов работает корректно");	
        }	
    }	
} 