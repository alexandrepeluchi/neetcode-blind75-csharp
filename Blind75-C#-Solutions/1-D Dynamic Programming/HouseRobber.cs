public class Solution {
    public int Rob(int[] nums) {
        int aux = 0;
        int auxBefore = 0;

        foreach (var num in nums)
        {
            int temp = Math.Max(aux, auxBefore + num);
            auxBefore = aux;
            aux = temp;
        }

        return aux;
    }
}
