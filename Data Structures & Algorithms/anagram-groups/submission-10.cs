public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        foreach (string s in strs)
        {
            int[] freq = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }
            string key = string.Join(",", freq);
            if(!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }     
            dict[key].Add(s);
        }

        foreach (var pair in dict)
        {
            result.Add(pair.Value);
        }
        return result;
    }
}
