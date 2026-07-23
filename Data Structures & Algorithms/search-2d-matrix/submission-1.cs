public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int columns = matrix[0].Length;

        int left = 0;
        int right = rows*columns-1;

        while (left <= right)
        {
            int mid = (left+right)/2;
            int row = mid/columns;
            int col = mid%columns;
            
            if(matrix[row][col] == target)
            {
                return true;
            }
            else
            {
                if(matrix[row][col] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid+1;
                }
            }
        }
    return false;
        
    }
}