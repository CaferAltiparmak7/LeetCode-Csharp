public class Solution {
    public string AddBinary(string a, string b) {
        string total = "";
        string carry = "0";
        
        for(int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--){
            string digitA = i >= 0 ? a[i].ToString() : "0"; 
            string digitB = j >= 0 ? b[j].ToString() : "0"; 

            if(digitA + digitB == "11"){
                if(carry == "1") {
                    total = "1" + total; 
                } 
                else {
                    total = "0" + total; 
                }
                carry = "1";
            }
            else if(digitA + digitB == "10" || digitA + digitB == "01"){
                if(carry == "1"){
                    total = "0" + total;
                    carry = "1";
                }
                else{
                    total = "1" + total; 
                    carry = "0";
                }
            }
            else if(digitA + digitB == "00"){
                if(carry == "1"){
                    total = "1" + total; 
                    carry = "0";
                }
                else{
                    total = "0" + total; 
                    carry = "0";
                }
            }
        }
        if(carry == "1"){
            total = "1" + total;
        }
        return total;
    }
}