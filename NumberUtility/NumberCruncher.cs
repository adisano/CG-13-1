using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberUtility
{
    public class NumberCruncher
    {
        //make a list of 10 integers
        public List<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //since the method to find the sum of the even numbers needed to be static,
        //i just accessed it through this public method
        public void Run()
        {
            int temp = FindSumOfEvenNums(numList);
            Console.WriteLine(temp);
        }

        //this static method takes our list of 10 integers and processes them into even integers only
        static int FindSumOfEvenNums(List<int> nums)
        {
            //we make a new list of integers, which will be just the even ones
            List<int> evenNums = new List<int>();

            int temp2;
            //loop through each integer in the list
            for (int i = 0; i < nums.Count; i++)
            {
                //find out if each integer is divisible by 2
                temp2 = nums[i] % 2;
                if (temp2 == 0)
                {
                    //and if it is, add it to our new list
                    evenNums.Add(nums[i]);
                }
                //otherwise just move on
                else
                {

                }
            }

            //add together all the even numbers 
            int sum = evenNums.Sum();

            //and return that as the result of this method
            return sum;
        }
    }
}
