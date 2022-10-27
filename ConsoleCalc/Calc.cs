using System;
using System.Linq;

namespace ConsoleCalc { 
 public class Calc {
  public string isOddOrEven(int n) {
   return n % 2 == 0 ? "Even" : "Odd";
  }

  public double ApproxFact(uint n) {
   double prod = 1;

   for (int i = 2; i <= n; i++)  prod *= i;

   return prod;
  }

  public string ExactFact(uint N) {
   ulong[] digits = {1};

   if (N <= 1) return "1";

   for (int i = 0; i < N * Math.Log10(N); i++) digits = digits.Append(0U).ToArray();

   for (uint i = 2; i <= N; i++) {
    digits = digits.Select(d => d * i).ToArray();
    int digitsGreaterThan9 = digits.Where(d => d > 9).Count();

    while (digitsGreaterThan9 > 0) {
     int index = Array.FindIndex(digits, d => d > 9);

     digits[index + 1] += (uint)Math.Floor((double)(digits[index] / 10));
     digits[index] -= (uint)Math.Floor((double)(digits[index] / 10)) * 10;
     digitsGreaterThan9 = digits.Where(d => d > 9).Count();
    }
   }

   int lastNonzeroDigitPosition = Array.FindLastIndex(digits, d => d > 0) + 1;

   string numStr = string.Join("", digits.Take(lastNonzeroDigitPosition));

   for (int i = 1; i <= numStr.Length; i++) {
    if (i % 4 == 0) numStr = numStr.Insert(i - 1, ",");
   }

   return Reverse(numStr.Last() == ',' ? numStr.Remove(numStr.Length - 1) : numStr);
  }

  public bool isPrime(int n) {
   bool isPrime = true;

   for (int i = 2; i < n && isPrime; i++) isPrime = n % i != 0;

   return isPrime;
  }

  private string Reverse(string s) {
   char[] charArray = s.ToCharArray();
   Array.Reverse(charArray);

   return new string(charArray);
  }
 }
}