using System;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 9);
                Console.WriteLine(array[i]);
            }
        }

        // 1. Find the minimum element of an array
        private static void MinimumElement(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
        }

        //2. Find the maximum element of an array
        private static void MaximumElement(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
        }

        //3. Find the index of the minimum element of the array
        private static void MinimalIndex(int[] array)
        {
            int minIndex = 0;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
        }

        //4. Find the index of the maximum element of the array
        private static void MaximalIndex(int[] array)
        {
            int maxIndex = 0;
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
        }
        //5. Calculate the sum of array elements with odd indices
        private static void SumOfArray(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }

        //6. Make an array reverse (an array in the opposite direction)
        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {                
            }
        }

        //7. Count the number of odd array elements
        private static void CountTheNumber(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum++;
                }
            }
        }

        //8. Swap the first and second half of the array, for example, for an array of 1 2 3 4, the result is 3 4 1 2, or for 1 2 3 4 5 -> 4 5 3 1 2.
        private static void firstAndSecond(int[] array)
        {
            int count1 = 0;
            int count2 = array.Length / 3;

            while (count1 < array.Length / 3)
            {
                int temp = array[count1];
                array[count1] = array[count2];
                array[count2] = temp;

                count1++; count2++;
            }
        }

        //9. Sort the array in ascending order in one of the ways: bubble (Bubble), selection (Select) or inserts (Insert))
        private static void SelectionArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        //10. Sort the array in descending order in one of the ways (different from the method in the 9th task): bubble (Bubble), selection (Select) or inserts (Insert))
        private static void DescendingSort(int[] array)
        {
            Array.Sort(array, (x, y) => y.CompareTo(x));
        }
    }
}
               


            
        
