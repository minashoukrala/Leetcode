public class Solution {
    public int MyAtoi(string s) {
        int i = 0, n = s.Length;
        while (i < n && s[i] == ' ') i++; // skip leading spaces

        if (i == n) return 0;

        bool negative = false;

        if (s[i] == '-' || s[i] == '+') {
            negative = s[i] == '-';
            i++;
        }

        long result = 0;

        while (i < n && char.IsDigit(s[i])) {
            result = result * 10 + (s[i] - '0');

            // Clamp early to avoid overflow
            if (!negative && result > int.MaxValue) return int.MaxValue;
            if (negative && -result < int.MinValue) return int.MinValue;

            i++;
        }

        return negative ? (int)-result : (int)result;
        
    }
}