public class Solution {
    public int MaxArea(int[] heights) {
        int rectangleLength = heights.Length-1; 
        int left = 0;
        int right = rectangleLength;
        int maxArea = 0;
        int currentArea = 0;

        while (left < right)
        {
            currentArea = rectangleLength * Math.Min(heights[left],heights[right]);
            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }
            if (heights[left] > heights[right])
            {
                right--;
            }
            else
            {
                left++;
            }
            rectangleLength--;
        }
        return maxArea;
    }
}
