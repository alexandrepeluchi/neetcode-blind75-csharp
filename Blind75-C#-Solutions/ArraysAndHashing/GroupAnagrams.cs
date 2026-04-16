public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var map = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string key = new string(arr);

            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(str);
        }

        return map.Values.ToList();
    }
}
