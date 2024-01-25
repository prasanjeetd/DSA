using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class TwoSumByIndex
    {
        public int[] twoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return [map[complement], i];
                }

                //map.set(nums[i], i);
                map[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
