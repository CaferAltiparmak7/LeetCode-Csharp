public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2) return n;

        int first = 1;  
        int second = 2;

        for (int i = 3; i <= n; i++) {
            //Fibonacci
            int current = first + second; 
            first = second; 
            second = current; 
        }
        return second;
    }
}