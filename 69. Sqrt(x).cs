public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        double result = x; 
        
        for(int i = 0; i < 40; i++){
            result = (result + x / result) / 2;
        }

        int fullPart = (int)result; 
        return fullPart;
    }
}