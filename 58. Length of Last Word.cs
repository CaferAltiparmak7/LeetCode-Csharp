public class Solution {
    public int LengthOfLastWord(string s) {
        int letterCount = 0;

        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] != ' '){
                letterCount++;
            }
            else if(letterCount > 0){
                return letterCount;
            }
        }
        return letterCount;
    }
}