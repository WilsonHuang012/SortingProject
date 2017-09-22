using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    /// <summary>
    /// 排序演算法
    /// https://zh.wikipedia.org/wiki/%E6%8E%92%E5%BA%8F%E7%AE%97%E6%B3%95
    /// </summary>
    public static class SortingAlgorithm
    {
        /// <summary>
        /// 氣泡排序
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> BubbleSort(List<int> list)
        {
            int temp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Swap(list, j, j + 1);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="list"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static List<int> QuickSort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(list, left, right);
                QuickSort(list, left, p - 1);
                QuickSort(list, p + 1, right);
            }
            return list;
        }

        public static List<int> SelectionSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        Swap(list, i, j);
                    }
                }
            }
            return list;
        }

        public static List<int> InsertionSort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int temp = list[i];
                int index = i;
                while (index > 0 && list[index - 1] > temp)
                {
                    list[i - 1] = list[i];
                    index -= 1;
                }
                list[index] = temp;
            }
            return list;
        }

        private static int Partition(List<int> list, int left, int pivotIndex)
        {
            int pivot = list[pivotIndex];
            int i = left - 1;
            for (int j = left; j < pivotIndex; j++)
            {
                if (list[j] < pivot)
                {
                    i += 1;
                    Swap(list, i, j);
                }
            }
            Swap(list, i + 1, pivotIndex);
            return i + 1;
        }

        private static void Swap(List<int> list, int i, int j)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
