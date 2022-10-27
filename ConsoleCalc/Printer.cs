using System;
using static System.Console;
using static System.Math;

namespace ConsoleCalc {
 public class Printer {
  public string DisplayAlgFuncs() {
   Clear();

   string result = "";
   
   WriteLine("These are your options: ");
   WriteLine("1. Add");
   WriteLine("2. Subtract");
   WriteLine("3. Multiply");
   WriteLine("4. Divide");
   WriteLine("5. Square Root");
   WriteLine("6. Exponentiation (take something to the power of something)");
   WriteLine("7. Go Back\n");

   while (true) {
    try {
     Write("Enter your choice: ");
     int choice = int.Parse(ReadLine());
     double n1, n2;
    
     switch (choice) {
      case 1:
       Write("Enter the first number: ");
       n1 = double.Parse(ReadLine());

       Write("Enter the second number: ");
       n2 = double.Parse(ReadLine());

       result = $"{n1} + {n2} = {n1 + n2}";
      break;
      case 2:
       Write("Enter the first number: ");
       n1 = double.Parse(ReadLine());

       Write("Enter the second number: ");
       n2 = double.Parse(ReadLine());

       result = $"{n1} - {n2} = {n1 - n2}";
      break;
      case 3:
       Write("Enter the first number: ");
       n1 = double.Parse(ReadLine());

       Write("Enter the second number: ");
       n2 = double.Parse(ReadLine());

       result = $"{n1} * {n2} = {n1 * n2}";
      break;
      case 4:
       Write("Enter the numerator: ");
       n1 = double.Parse(ReadLine());

       Write("Enter the denominator: ");
       n2 = double.Parse(ReadLine());

       result = $"{n1} / {n2} = {n1 / n2}";
      break;
      case 5:
       Write("Enter the number: ");
       n1 = double.Parse(ReadLine());

       result = $"Sqrt({n1}) = {Sqrt(n1)}";
      break;
      case 6:
       Write("Enter the base: ");
       n1 = double.Parse(ReadLine());

       Write("Enter the exponent: ");
       n2 = double.Parse(ReadLine());

       result = $"{n1} ^ {n2} = {Pow(n1, n2)}";
      break;
      case 7: break;
      default: WriteLine("Please enter a valid choice.\n"); continue;
     }

     if (choice <= 7) break;
    } catch {
     WriteLine("Please enter a valid choice.\n");
    }
   }

   return result;
  }

  public string DisplayTrigFuncs() {
   Clear();

   string result = "";
   
   WriteLine("These are your options: ");
   WriteLine("1. Sine");
   WriteLine("2. Cosine");
   WriteLine("3. Tangent");
   WriteLine("4. Hyperbolic Sine (sinh)");
   WriteLine("5. Hyperbolic Cosine (cosh)");
   WriteLine("6. Hyperbolic Tangent (tanh)");
   WriteLine("7. Go Back\n");

   while (true) {
    try {
     Write("Enter your choice: ");
     int choice = int.Parse(ReadLine());
     double deg;
    
     switch (choice) {
      case 1:
       Write("Enter the angle in degrees: ");
       deg = double.Parse(ReadLine());

       result = $"sin({deg}) = {Sin(deg * (PI / 180))}";
      break;
      case 2:
       Write("Enter the angle in degrees: ");
       deg = double.Parse(ReadLine());

       result = $"cos({deg}) = {Cos(deg * (PI / 180))}";
      break;
      case 3:
       Write("Enter the angle in degrees: ");
       deg = double.Parse(ReadLine());

       result = $"tan({deg}) = {Tan(deg * (PI / 180))}";
      break;
      case 4:
       Write("Enter the angle in degrees: ");
       deg = double.Parse(ReadLine());

       result = $"sinh({deg}) = {Sinh(deg * (PI / 180))}";
      break;
      case 5:
       Write("Enter the angle in degrees: ");
       deg = double.Parse(ReadLine());

       result = $"cosh({deg}) = {Cosh(deg * (PI / 180))}";
      break;
      case 6:
       Write("Enter the angle in degrees: ");
       deg = double.Parse(ReadLine());

       result = $"tanh({deg}) = {Tanh(deg * (PI / 180))}";
      break;
      case 7: break;
      default: WriteLine("Please enter a valid choice.\n"); continue;
     }

     if (choice <= 7) break;
    } catch {
     WriteLine("Please enter a valid choice.\n");
    }
   }

   return result;
  }

  public string DisplayOtherFuncs() {
   Clear();

   string result = "";
   Calc calc = new Calc();
   
   WriteLine("These are your options: ");
   WriteLine("1. Check Parity (is it even or odd?)");
   WriteLine("2. Test Primality (is it a prime number?)");
   WriteLine("3. Factorial (Approximate)");
   WriteLine("4. Factorial (Exact)");
   WriteLine("5. Get Binary Representation");
   WriteLine("6. Truncate Decimals");
   WriteLine("7. Round Down");
   WriteLine("8. Natural Logarithm");
   WriteLine("9. Absolute Value");
   WriteLine("10. Get the sign of a number");
   WriteLine("11. Go Back\n");

   while (true) {
    try {
     Write("Enter your choice: ");
     int choice = int.Parse(ReadLine());
     double n;
    
     switch (choice) {
      case 1:
       Write("Enter your number: ");
       n = int.Parse(ReadLine());

       result = $"{n} is {calc.isOddOrEven((int)n)}";
      break;
      case 2:
       Write("Enter your number: ");
       n = int.Parse(ReadLine());

       result = $"{n} is {(calc.isPrime((int)n) ? "" : "not")} a prime number";
      break;
      case 3:
       Write("Enter your number: ");
       n = uint.Parse(ReadLine());

       result = $"{n}! {(n > 21 ? "~" : "")}= {calc.ApproxFact((uint)n)}";
      break;
      case 4:
       Write("Enter your number: ");
       n = uint.Parse(ReadLine());

       result = $"{n}! = {calc.ExactFact((uint)n)}";
      break;
      case 5:
       Write("Enter your number: ");
       n = int.Parse(ReadLine());

       result = $"{n} in binary is {Convert.ToString((int)n, 2)}";
      break;
      case 6:
       Write("Enter your number: ");
       n = double.Parse(ReadLine());

       result = $"{n} truncated is {Floor(n)}";
      break;
      case 7:
       Write("Enter your number: ");
       n = double.Parse(ReadLine());

       result = $"{n} truncated is {Floor(n)}";
      break;
      case 8:
       Write("Enter your number: ");
       n = double.Parse(ReadLine());

       result = $"ln({n}) = {Log(n)}";
      break;
      case 9: 
       Write("Enter your number: ");
       n = short.Parse(ReadLine());

       result = $"|{n}| rounded down is {Abs((short)n)}";
      break;
      case 10: 
       Write("Enter your number: ");
       n = short.Parse(ReadLine());

       result = $"sign({n}) = {Sign((short)n)}";
      break;
      case 11: break;
      default: WriteLine("Please enter a valid choice.\n"); continue;
     }

     if (choice <= 11) break;
    } catch {
     WriteLine("Please enter a valid choice.\n");
    }
   }

   return result;
  }
 }
}
