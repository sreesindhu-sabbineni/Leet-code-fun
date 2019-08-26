/*Say you have an array for which the ith element is the price of a given stock on day i.

If you were only permitted to complete at most one transaction 
(i.e., buy one and sell one share of the stock), 
design an algorithm to find the maximum profit.

Note that you cannot sell a stock before you buy one.*/


public class Solution {
    public int MaxProfit(int[] prices) {
        int profit =0;
        var copyprices = prices.Reverse().ToArray();
        if(prices == copyprices){
            return 0;
        }
        else{
            for(int i = 0; i<prices.Length-1;i++){
                for(int j = i+1; j<prices.Length;j++){
                    if(profit<prices[j]-prices[i]){
                        profit = prices[j]-prices[i];
                    }
                }
            }
            return profit;
        }
    }
}