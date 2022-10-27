using static System.Console;

namespace ConsoleCalc {
 internal class Program {
  static void Main(string[] args) {
   WriteLine("Welcome to TermCalc!");

   string displayString = "";
   Printer printer = new Printer();

   while (true) {
     try {
      if (displayString != string.Empty) WriteLine(displayString + '\n');
      WriteLine("These are your options: ");
      WriteLine("1. Algebraic Operations");
      WriteLine("2. Trigonometric Functions");
      WriteLine("3. Other Functions");
      WriteLine("4. Exit Program\n");

      Write("Enter your choice: ");
      int choice = int.Parse(ReadLine());
      
      switch (choice) {
       case 1: displayString = printer.DisplayAlgFuncs(); Clear(); break;
       case 2: displayString = printer.DisplayTrigFuncs(); Clear(); break;
       case 3: displayString = printer.DisplayOtherFuncs(); Clear(); break;
       case 4: break;
       default: WriteLine("Please enter a valid choice.\n"); break;
      }
      
      if (choice == 4) {
       WriteLine("\nHave a nice day!");
      
       break;
      }
    } catch {
     WriteLine("Please enter a valid choice.\n");
    }
   }
  }
 }
}
