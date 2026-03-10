public class Solution {
    public bool IsValid(string s) {

        if (s.Length % 2 != 0) 
            return false;

        Dictionary<char, char> map = new Dictionary<char, char> 
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        Stack<char> memoria = new Stack<char>();

        for (int i = 0; i < s.Length; i++) 
        {
            char atual = s[i];

            if (map.ContainsKey(atual)) 
            {
                if (memoria.Count == 0 || memoria.Peek() != map[atual]) 
                    return false;

                memoria.Pop();
            } 
            else 
            {
                memoria.Push(atual);
            }
        }

        return memoria.Count == 0;
    }
}
