public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        foreach (string s in strs)
        {
            string sortedString = new string(s.OrderBy(c => c).ToArray());
            if(!dict.ContainsKey(sortedString))
            {
                dict[sortedString] = new List<string>();
            }     
            dict[sortedString].Add(s);
        }

        foreach (var pair in dict)
        {
            result.Add(pair.Value);
        }
        return result;
    }
}
