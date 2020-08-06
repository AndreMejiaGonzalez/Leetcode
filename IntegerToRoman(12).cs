public class Solution {
    public string IntToRoman(int num) {
        StringBuilder result = new StringBuilder();
        int i = 0;
        
        i = num / 1000;
        for (; i > 0; i--)
            result.Append("M");
        
        num %= 1000;
        
        if (num / 900 == 1)
        {
            result.Append("CM");        
            num %= 900;
        }
        
        if (num / 500 == 1)
        {
            result.Append("D");
            num %= 500;
        }
        
        if (num / 400 == 1)
        {
            result.Append("CD");
            num %= 400;
        }
        
        i = num / 100;        
        for (; i > 0; i--)
            result.Append("C");
        
        num %= 100;
        
        if (num / 90 == 1)
        {
            result.Append("XC");
            num %= 90;
        }
        
        if (num / 50 == 1)
        {
            result.Append("L");
            num %= 50;
        }
        
        if (num / 40 == 1)
        {
            result.Append("XL");
            num %= 40;
        }
        
        i = num / 10;        
        for (; i > 0; i--)
            result.Append("X");
        
        num %= 10;
        
        if (num / 9 == 1)
        {
            result.Append("IX");
            num %= 9;
        }
        
        if (num / 5 == 1)
        {
            result.Append("V");
            num %= 5;
        }
        
        if (num / 4 == 1)
        {
            result.Append("IV");
            num %= 4;
        }
        
        for (; num > 0; num--)
            result.Append("I");
        
        return result.ToString();
    }
}