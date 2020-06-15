/*
 * https://www.hackerrank.com/challenges/piling-up/problem
 
 * single pass iteration : O(n) ------> time complexity , O(n) ------> space complexity for maintaining the maxstack.
 
 */

using System;
using System.Collections.Generic;

namespace code_snippets_object_array_cs
{
    class Program
    {


        public static bool Maintainmaxstack(Stack<int> maxstack , int value )
        {
            // function to check if the insertion of the element will destroy the max stack order.
            // to maintain the stack order check if the incoming element is  <= current top element.

            bool is_possible = false;
            // default value of the possibility = false.



            if ( maxstack.Count == 0)
            {
                 // first entry to the max_stack.
                // set the possibility value to true , only if it satisfies the condition.

                is_possible = true;
                return is_possible;
            }
            else if (value <= maxstack.Peek())
            {
                // first entry to the max_stack.
                // set the possibility value to true , only if it satisfies the condition.

                is_possible = true;
                return is_possible;
            }
            return is_possible;
        }
        public static bool PilingUP(int[] box_length)
        {
            // fun.ction to check if the given arrangement of boxes can be pilled up in a stack 
            /* algorithm : 
                            1. iterate through the maximum box length either from the left or right , 
                            2. while filling up the stack order , check that the maximum stack order  is maintained 
                            3. if the stack order fails at any point , break the iteration , check the length of the box_pillingup 
                            4. also end the iteration if the elements get exhausted.
             */


            Stack<int> max_stack = new Stack<int>(box_length.Length);
            // will store up the maximum stack arrangement.

            int left = box_length.GetLowerBound(0);
            int right = box_length.GetUpperBound(0);

            while (left <= right)
            {
                // iterate through all the elements  from both_ends.

                if ( box_length[left] > box_length[right])
                {
                    // select the left element for the push operation.
                    bool is_possible = Maintainmaxstack(max_stack, box_length[left]);

                    if (is_possible)
                    {
                        // build the max-stack with the element value only if the value after insertion maintain the  max-stack property.
                        // insert the value only if the check function  allows the insertion.

                        max_stack.Push(box_length[left]);

                    }
                    else
                    {
                        return false;
                    }

                    left += 1;

                }
                else
                {
                    // box_length[right] is the maximum element.
                    // select the left element for the push operation.
                    bool is_possible = Maintainmaxstack(max_stack, box_length[right]);

                    if (is_possible)
                    {
                        // build the max-stack with the element value only if the value after insertion maintain the  max-stack property.
                        // insert the value only if the check function  allows the insertion.

                        max_stack.Push(box_length[right]);

                    }
                    else
                    {
                        return false;
                    }

                    right -= 1;
                }

            }

            if (max_stack.Count == box_length.Length)
            {
                // check if it is possible to pile up all the boxes in the maximum stack order.
                return true;
            }
            return false; 
            // return false if all boxes not possible to pile up in max stack order.
        }

        static void Main(string[] args)
        {
            
            
            int[] box_length = { 4, 3, 2, 1, 3, 4 };
            // box length's given in an array||collection.

            bool is_possible = PilingUP(box_length);
            // call the PilingUP to check the possibility.

            if (is_possible)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }
    }

}
