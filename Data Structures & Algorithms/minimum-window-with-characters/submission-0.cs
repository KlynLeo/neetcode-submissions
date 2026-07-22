public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length)
        {
            return String.Empty;
        }

        var need = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!need.ContainsKey(c)) need[c] = 0;
            need[c]++;
        }

        var window = new Dictionary<char, int>();
        int required = need.Count;   
        int formed = 0;              

        int left = 0;
        int bestLen = int.MaxValue;
        int bestStart = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            if (!window.ContainsKey(c)) window[c] = 0;
            window[c]++;

            if (need.ContainsKey(c) && window[c] == need[c])
            {
                formed++;
            }

            while (formed == required)
            {
                if (right - left + 1 < bestLen)
                {
                    bestLen = right - left + 1;
                    bestStart = left;
                }

                char leftChar = s[left];
                window[leftChar]--;
                if (need.ContainsKey(leftChar) && window[leftChar] < need[leftChar])
                {
                    formed--;
                }
                left++;
            }
        }

        return bestLen == int.MaxValue ? String.Empty : s.Substring(bestStart, bestLen);
    }
}