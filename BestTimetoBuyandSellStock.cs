/*Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. 
You may complete as many transactions as you like 
(i.e., buy one and sell one share of the stock multiple times).

Note: You may not engage in multiple transactions at the same time 
(i.e., you must sell the stock before you buy again). */

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxprofit = 0,minprice = int.MaxValue;
        for(int i = 0;i<prices.Length;i++){
            if(prices[i]<minprice){
                minprice = prices[i];
            }
            else{
                maxprofit += prices[i]-minprice;
                minprice = prices[i];
            }
        }
        return maxprofit;
        }
    }
