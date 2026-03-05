public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length) return -1;

        for (int i = 0; i <= haystack.Length - needle.Length; i++) {

            for (int j = 0; j < needle.Length; j++) {
                
                if (haystack[i + j] == needle[j]) {
                    
                    if (j == needle.Length - 1) return i;

                }
                else {
                    break; 
                }
            }
        }
        return -1; 
    }
}