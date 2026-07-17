public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int k = 0; k < 9; k++) {
            rows[k] = new HashSet<char>();
            cols[k] = new HashSet<char>();
            boxes[k] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char c = board[i][j];
                if (c == '.') continue;

                int boxIndex = (i / 3) * 3 + (j / 3);

                if (rows[i].Contains(c) || cols[j].Contains(c) || boxes[boxIndex].Contains(c)) {
                    return false;
                }

                rows[i].Add(c);
                cols[j].Add(c);
                boxes[boxIndex].Add(c);
            }
        }

        return true;
    }
}