public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var first = new int[26];
        var second = new int[26];

        foreach (char c in s)
            first[c - 'a']++;

        foreach (char c in t)
            second[c - 'a']++;

        for (int i = 0; i < 26; i++)
        {
            if (first[i] != second[i])
                return false;
        }

        return true;
    }
}