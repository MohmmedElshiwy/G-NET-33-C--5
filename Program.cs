using G_NET_33_C__5;

// #region Enum
//     System.Console.WriteLine("enter a day number (0–6).");

// int DayNumer = int.Parse(Console.ReadLine().Trim());
// MyDayOfWeek Day = (MyDayOfWeek)DayNumer;

// if (DayNumer >= 0 && DayNumer <= 6)
// {
//     if (DayNumer > 6)
//     {
//         System.Console.WriteLine($@"Day : {Day}
//         It's a Workday");
//     }
//     else
//     {
//         System.Console.WriteLine($@"Day  : {Day}
//         It's Weekend");

//     }

// }
// else
// {
//     System.Console.WriteLine("invalid input");
// }
// #endregion


// #region Array

// #region Array Statistics

// System.Console.WriteLine("Enter Size Of Array !");

// int arraySize = int.Parse(Console.ReadLine());
// int[] numbers = new int[arraySize];

// for (int i = 0; i < numbers.Length; i++)
// {
//     System.Console.WriteLine($"Enter Element {i + 1}");

//     int element = int.Parse(Console.ReadLine());
//     numbers[i] = element;
// }

// System.Console.WriteLine("Array is :");
// foreach (var i in numbers)
// {
//     System.Console.WriteLine($"{i}");
// }

// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     sum += numbers[i];
// }

// System.Console.WriteLine($" Total is : {sum}");
// System.Console.WriteLine($" Average is : {sum / numbers.Length}");
// int max = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
// }
// System.Console.WriteLine($" Max is : {max}");

// int min = int.MaxValue;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }
// System.Console.WriteLine($" Min is : {min}");

// int[] reverse = new int[numbers.Length];
// for (int i = 0; i < numbers.Length; i++)
// {
//     reverse[i] = numbers[numbers.Length - 1 - i];
// }

// System.Console.WriteLine("Reverse Array is :");
// foreach (var i in reverse)
// {
//     System.Console.WriteLine($"{i}");
// }
// #endregion

// #region Grades Matrix
// int[,] grades = new int[3, 4];
// float total = 0;
// for (int i = 0; i < grades.GetLength(0); i++)
// {
// int studentAvg = 0;
//     for (int j = 0; j < grades.GetLength(1); j++)
//     {
//         System.Console.WriteLine($"Enter Grade of Student {i + 1} in Subject {j + 1}");
//         grades[i, j] = int.Parse(Console.ReadLine());
//         total += grades[i, j];
//         studentAvg += grades[i, j];
//     }
//         System.Console.WriteLine($"Avg Of Student {i + 1} is : {studentAvg / grades.GetLength(1)}");
// }
//         System.Console.WriteLine($"Total Avg is : {total / (grades.GetLength(0) * grades.GetLength(1))}");

// #endregion

// #endregion


// #region Fnction

//     #region Basic Calculator Functions
//     static double Add(double a, double b)
//     {
//         return a + b;
//     }

//     static double Subtract(double a, double b)
//     {
//         return a - b;
//     }

//     static double Multiply(double a, double b)
//     {
//         return a * b;
//     }

//     static double Divide(double a, double b)
//     {
//         if (b == 0)
//         {
//             Console.WriteLine("Error: Cannot divide by zero!");
//             return double.NaN; // Not a Number
//         }

//         return a / b;
//     }



//       Console.Write("Enter first number: ");
//         double num1 = double.Parse(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         double num2 = double.Parse(Console.ReadLine());

//         Console.Write("Enter operation (+, -, *, /): ");
//         char op = Console.ReadLine()[0];

//         double result = 0;

//         switch (op)
//         {
//             case '+':
//                 result = Add(num1, num2);
//                 break;

//             case '-':
//                 result = Subtract(num1, num2);
//                 break;

//             case '*':
//                 result = Multiply(num1, num2);
//                 break;

//             case '/':
//                 result = Divide(num1, num2);
//                 break;

//             default:
//                 Console.WriteLine("Invalid operation!");
//                 return;
//         }

//         Console.WriteLine($"Result = {result}");
    
        
//     #endregion
 




//     #region Circle Calculator
//     static void CalculateCircle(double radius, out double area, out double circumference)
//     {
//         area = Math.PI * radius * radius;
//         circumference = 2 * Math.PI * radius;
//     }
//     Console.Write("Enter circle radius: ");
//         double radius = double.Parse(Console.ReadLine());

//         double area;
//         double circumference;

//         CalculateCircle(radius, out area, out circumference);

//         Console.WriteLine($"Area = {area}");
//         Console.WriteLine($"Circumference = {circumference}");
    
        
//     #endregion
// #endregion

