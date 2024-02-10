using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class MergeSortedArray
    {
        public void Test()
        {

            /*
             * 
             * You are given two integer arrays nums1 and nums2, 
             * sorted in non-decreasing order, and two integers m and n,
             * representing the number of elements in nums1 and nums2 respectively.
             * 
             */


            //var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int m = 3;
            //var nums2 = new int[] { 2, 5, 6 };
            //int n = 3;

            //var nums1 = new int[] { 0 };
            //int m = 0;
            //var nums2 = new int[] { 1 };
            //int n = 1;

            var nums1 = new int[] { 2, 0 };
            int m = 1;
            var nums2 = new int[] { 1 };
            int n = 1;

            Merge(nums1, m, nums2, n);
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    k--;
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    k--;
                    j--;
                }
            }
        }
    }
}
