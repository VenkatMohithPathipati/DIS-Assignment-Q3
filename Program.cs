using System;
using System.Collections.Generic;

namespace AssignQues3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array");
            int len = int.Parse(Console.ReadLine());
            var bull_bucks = new int[len];
            for (int i = 0; i < len; i++)
            {
                bull_bucks[i] = int.Parse(Console.ReadLine()); // adding nnumbers to array
            }
            Console.WriteLine("Sum of unique numbers: {0}", SumOfUnique(bull_bucks, len));// calling function
        }
        static int SumOfUnique(int[] bull_bucks, int len)
        {
            var dummy_array = bull_bucks;
            Array.Sort(dummy_array);// sorting in ascending order
            var unique_list = new List<int>();// new list to add the unique elements
            var dum = 0;
            for (int i = 1; i < len-1; i++)
            {
                if((dummy_array[i] != dummy_array[i+1]) & (dummy_array[i] != dummy_array[i-1]))//checking all the elements except for first and last indices
                {
                    unique_list.Add(dummy_array[i]);//adds the number if the above condition is satisfied
                }
            }
            if(dummy_array[0] != dummy_array[1])// for first index
            {
                unique_list.Add(dummy_array[0]);
            }
            if(dummy_array[len-1] != dummy_array[len - 2])//for last index
            {
                unique_list.Add(dummy_array[len - 1]);
            }
            
            for (int i = 0; i < unique_list.Count; i++)
            {
                dum = dum + unique_list[i];
            }
            return dum;// returns the sum
        }
    }
}
