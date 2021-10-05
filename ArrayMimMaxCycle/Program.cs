using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMimMaxCycle
{
    class Program
    {
        static Random rng = new Random();
        static int iArrayCount;
        static int _iMin;
        static int _iMax;
        static void Main(string[] args)
        {
            Link:
            Console.Write("\nВведите длину массива ");
            iArrayCount = Convert.ToInt32(Console.ReadLine());
            int[] _nums = new int[iArrayCount];
            Checker();
            Console.Write("\nПеречисление элементов: ");
            NumsCallOut(_nums);
            Console.Write("\nОтсортированный по возрастанию массив: ");
            SortByMax(_nums);
            Console.Write("\nОтсортированный по убыванию массив: ");
            SortByMin(_nums);
            Console.Write("\nМинимальное число: ");
            MinValue(_nums);
            Console.Write("\nМаксимальное число: ");
            MaxValue(_nums);
            goto Link;
        }
        /// <summary>
        /// Проверяет введённую длину массива
        /// </summary>
        private static void Checker()
        {
            if (iArrayCount >= 15 || iArrayCount <= 0) 
                Console.WriteLine("Длина массива некорректна.");
        }
        /// <summary>
        /// Присваивание случайного значения элементам массива
        /// </summary>
        static int[] NumsCallOut(int[] _nums)
        {
            for (int i = 0; i < _nums.Length; i++)
            {
                _nums[i] = rng.Next(0, 100);
                Console.Write(" " + _nums[i]);
            }
            return _nums;
        }
        static void SortByMax(int[] _nums)
        {
            for(int i = 0; i < _nums.Length; i++)
            {
                for (int j = 0; j < _nums.Length - 1; j++)
                {
                    if(_nums[j]>_nums[j+1])
                    {
                        int temp = _nums[j];
                        _nums[j] = _nums[j + 1];
                        _nums[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < _nums.Length; i++)
                Console.Write(" " + _nums[i]);
        }
        static void SortByMin(int[] _nums)
        {
            for(int i = 0; i<_nums.Length;i++)
            {
                for(int j = 0; j<_nums.Length - 1; j++)
                {
                    if (_nums[j] < _nums[j+1])
                    {
                        int temp = _nums[j];
                        _nums[j] = _nums[j + 1];
                        _nums[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < _nums.Length; i++)
                Console.Write(" " + _nums[i]);
        }
        static void MinValue(int[] _nums)
        {
            _iMin = _nums[iArrayCount-1];
            for(int i = 0;i< _nums.Length; i++ )
            {
                if (_iMin > _nums[i])
                    _iMin = _nums[i];
            }
            Console.Write(" " + _iMin);
        }
        static void MaxValue(int[] _nums)
        {
            _iMax = _nums[iArrayCount - 1];
            for (int i = 0; i < _nums.Length; i++)
            {
                if (_iMax < _nums[i])
                    _iMax = _nums[i];
            }
            Console.Write(" " + _iMax);
        }

    }
}
