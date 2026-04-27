public class PrefixTree {

    private class Node {
        public Dictionary<char, Node> next = new ();
        public bool isWord;
    }

    private Node root;

    public PrefixTree() {
        root = new Node();
    }
    
    public void Insert(string word) {
        var node = root;

        foreach (var c in word)
        {
            if (!node.next.ContainsKey(c))
                node.next[c] = new Node();

            node = node.next[c];
        }

        node.isWord = true;
    }
    
    public bool Search(string word) {
        var node = root;

        foreach (var c in word)
        {
            if (!node.next.ContainsKey(c))
                return false;

            node = node.next[c];
        }

        return node.isWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = root;

        foreach (var c in prefix)
        {
            if (!node.next.ContainsKey(c))
                return false;

            node = node.next[c];
        }

        return true;
    }
}
