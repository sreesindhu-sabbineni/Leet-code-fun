/*Find the kth largest element in an unsorted array. 
Note that it is the kth largest element in the sorted order, 
not the kth distinct element. */

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        if(nums.Length<k){
            return 0;
        }
        Array.Sort(nums);
        int counter = 1;
        int value = 0;
        for(int i = nums.Length-1;i>=0;i--){
            if(counter++ == k){
                value = nums[i];
            }
        }
        return value;
    }
}