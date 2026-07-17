public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var pq = new PriorityQueue<int,int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        int[] freq = new int[2001];
        int[] res = new int[k];

        foreach (var number in nums)
        {
            freq[number + 1000]++;
        }

        for (int i = 0; i < 2001; i++)
        {
            pq.Enqueue(i-1000, freq[i]);
        }

        for (int i = 0; i < k; i++)
        {
            int num = pq.Dequeue();
            res[i] = num;
        }
        return res;
    }
}
