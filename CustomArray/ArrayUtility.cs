using System;
using System.Collections.Generic;
using System.Text;

namespace CustomArray
{
    public class ArrayUtility
    {
        public static void Resize(ref int[] array, int newSize)
        {
            int[] numbers = new int[newSize];
            for(int i = 0; i < array.Length; i++)
            {
                numbers[i] = array[i];
            }
            array = numbers;

        }
    }
}
