using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class Insertion_Sort
    {
        public void Insertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
        public void Display(int[] intArr)
        {
            for (int index = 0; index < intArr.Length; index++)
            {
                Console.WriteLine(intArr[index]);
            }
        }
    }
}
