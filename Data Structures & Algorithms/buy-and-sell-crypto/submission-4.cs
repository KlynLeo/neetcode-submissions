public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 1)
        {
            return 0;
        }
        int left = 0;
        int right = 1;
        int profit = 0;
        int maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[left] > prices[right])
            {
                left++;
                right = left+1;
            }
            else
            {
                maxProfit = Math.Max(prices[right] - prices[left], maxProfit);
                right++; 
            }
        }
        return maxProfit;
    }
}
