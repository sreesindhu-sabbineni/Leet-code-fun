/*Given an array of size n, find the majority element. The majority element is the element that appears more than 
⌊ n/2 ⌋ times.

You may assume that the array is non-empty and the majority element always exist in 
the array.*/

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> countdict = new Dictionary<int,int>();
        foreach(var ele in nums){
            if(countdict.ContainsKey(ele)){
                var count = countdict[ele];
                countdict[ele] = count+1;
            }
            else{
                countdict.Add(ele,1);
            }
        }
        int maxval = int.MinValue;
        int maxkey= -1;
        foreach(var kvp in countdict){
            if(kvp.Value>maxval){
                maxval = kvp.Value;
                maxkey = kvp.Key;
            }
        }
        return maxkey;
    }
}