public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 0;

            freq[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in freq)
        {
            if (buckets[pair.Value] == null)
                buckets[pair.Value] = new List<int>();

            buckets[pair.Value].Add(pair.Key);
        }

        List<int> result = new();

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] == null)
                continue;

            foreach (int num in buckets[i])
            {
                result.Add(num);

                if (result.Count == k)
                    break;
            }
        }

        return result.ToArray();
    }
}