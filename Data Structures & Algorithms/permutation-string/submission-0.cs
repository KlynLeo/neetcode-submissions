public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        int[] freqString1 = new int[26];
        int[] freqString2 = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            freqString1[s1[i] - 'a']++;
            freqString2[s2[i] - 'a']++; 
        }

        int left = 0;
        int windowLen = s1.Length;

        while (true)
        {
            bool match = true;
            for (int i = 0; i < 26; i++)
            {
                if (freqString1[i] != freqString2[i])
                {
                    match = false;
                    break;
                }
            }
            if (match) return true;

            int right = left + windowLen; 
            if (right >= s2.Length) break; 

            freqString2[s2[right] - 'a']++;      
            freqString2[s2[left] - 'a']--;       
            left++;
        }

        return false;
    }
}