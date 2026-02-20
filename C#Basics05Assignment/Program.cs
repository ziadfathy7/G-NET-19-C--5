using C_Basics05Assignment.Enums;
using System.Security.Cryptography.X509Certificates;

namespace C_Basics05Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1

            //Part 1 Enums
            /* Q1: Day of The Week Create an enum called DayOfWeek with values: Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday.
                    Then write a program that:
                    Asks the user to enter a day number (0–6).
                    Converts it to the enum and prints the day name.
                    Uses a switch statement to print whether it's a "Workday" or a "Weekend". */
            //Days day;
            //bool isParsed;
            //do
            //{
            //    Console.WriteLine("Please Enter a Day Number from 0-6");
            //    isParsed = Enum.TryParse(Console.ReadLine(), out day);
            //} while(!isParsed || !Enum.IsDefined(day));
            //Console.WriteLine(day);

            //switch (day)
            //{
            //    case Days.Saturday:
            //        Console.WriteLine("This day is Weekend");
            //        break;
            //    case Days.Sunday:
            //        Console.WriteLine("This day is Workday");
            //        break;
            //    case Days.Monday:
            //        Console.WriteLine("This day is Workday");
            //        break;
            //    case Days.Tuesday:
            //        Console.WriteLine("This day is Workday");
            //        break;
            //    case Days.Wednesday:
            //        Console.WriteLine("This day is Workday");
            //        break;
            //    case Days.Thursday:
            //        Console.WriteLine("This day is Workday");
            //        break;
            //    case Days.Friday:
            //        Console.WriteLine("This day is Weekend");
            //        break;
            //}
            #endregion


            #region Question2 Part 01
            //Console.WriteLine("Enter Array Size");

            //int ArraySize = Int32.Parse(Console.ReadLine());
            //int[] Array = new int[ArraySize];
            //for (int i = 0; i < Array.Length; i ++) {
            //    Console.WriteLine("Enter Element");
            //    int arrayElements = Int32.Parse(Console.ReadLine());
            //    Array[i] = arrayElements;
            //}

            //double sum=0;
            //double avg=0;
            //int max = Array[0];
            //int min = Array[0];

            //for (int i = 0; i < Array.Length; i++)
            //{
            //    sum += Array[i];
            //    if (Array[i] > max)
            //    {
            //        max = Array[i];
            //    }
            //    if (min > Array[i])
            //    {
            //        min = Array[i];
            //    }
            //}

            //avg = sum / Array.Length;

            //Console.WriteLine($"Sum = {sum}");
            //Console.WriteLine($"Average = {avg}");
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Min = {min}");

            //Console.WriteLine("=================================");
            //for (int i = Array.Length -1 ; i >= 0; i--)
            //{
            //    Console.WriteLine(Array[i]);
            //}
            #endregion


            #region Question 2 Part 02

            //double[,] Grades = new double[3,4];
            //double totalSum = 0;

            //for (int student = 0; student < 3; student++)
            //{
            //    Console.WriteLine($"Student Number{student}");

            //    for (int subject = 0; subject < 4; subject++)
            //    {
            //        Console.Write($"Enter grade for Subject {subject}:");
            //        double grade = double.Parse(Console.ReadLine());
            //        Grades[student, subject] = grade;
            //        totalSum += grade;
            //    }
            //}

            //for (int student = 0; student < 3; student++)
            //{
            //    double studentSum = 0;

            //    for (int subject = 0; subject < 4; subject++)
            //    {
            //        studentSum += Grades[student, subject];
            //    }

            //    double studentAverage = studentSum / 4;
            //    Console.WriteLine($"Student {student + 1} Average: {studentAverage}");
            //}

            //double classAverage = totalSum / 12;
            //Console.WriteLine($"The whole class average is:{classAverage}");

            #endregion


            #region Part 3 Question 01

            //static double sum(double x, double y)
            //{
            //    double result = x + y;
            //    return result;
            //}

            ////double resultsum = sum(5, 2);
            ////Console.WriteLine(resultsum);

            //static double subtract(double x, double y)
            //{ 
            //    double result = x - y;
            //    return result;
            //}

            ////double resultsub = subtract(5, 2);
            ////Console.WriteLine(resultsub);

            //static double multiply(double x, double y)
            //{ 
            //    double result = x * y;
            //    return result;
            //}

            ////double multiplyres = multiply(5, 2);
            ////Console.WriteLine(multiplyres);

            //static double divide(double x, double y)
            //{ 
            //    if(y == 0)
            //    {
            //        Console.WriteLine("cannot divide by 0");
            //    }
            //     return  x / y;
            //}


            //Console.WriteLine("Please enter the first number");
            //double firstNumber = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number");
            //double secondNumber = double.Parse(Console.ReadLine());

            //Console.WriteLine("Pick an operation ( (+) _ (-) _ (*) _ (/) )");
            //string Operation = Console.ReadLine();
            //double finalResult = 0;

            //switch (Operation)
            //{
            //    case "+":
            //        finalResult = sum(firstNumber,secondNumber);
            //        break;
            //    case "-":
            //        finalResult = subtract(firstNumber,secondNumber);
            //        break;
            //    case "*":
            //        finalResult = multiply(firstNumber,secondNumber);
            //        break;
            //    case "/":
            //        finalResult = divide(firstNumber,secondNumber);
            //        break;
            //    default:
            //        Console.WriteLine("Wrong Enter again");
            //        return;
            //}
            //Console.WriteLine($"Result: {firstNumber} {Operation} {secondNumber} = {finalResult}");

            #endregion
        }
    }
}
