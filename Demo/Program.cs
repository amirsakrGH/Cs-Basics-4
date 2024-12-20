namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int.TryParse(Console.ReadLine(), out int length);
            //Console.Write($"all numbers between 1 to {length}: ");
            //for (int i = 1; i <= length; i++)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int.TryParse(Console.ReadLine(), out int length);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i} * {length} : {i * length}");
            //}
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int.TryParse(Console.ReadLine(), out int printEvenNumber);
            //for (int i = 2; i < printEvenNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //int.TryParse(Console.ReadLine(), out int number);
            //int.TryParse(Console.ReadLine(), out int power);
            //int result = 1;
            //if (power == 0)
            //{
            //    result = 1;
            //}
            //else
            //{
            //    for (int i = 0; i < power; i++)
            //    {
            //        result *= number;
            //    }
            //}
            //Console.WriteLine(result);
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int totalMarks = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    totalMarks += int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"Total marks: {totalMarks}");
            //Console.WriteLine($"Average Marks: {totalMarks / 5}");
            //Console.WriteLine($"Percentage: {totalMarks / 5}%");

            #endregion

            #region 6- Write a program to input the month number and print the number of days in that month.
            //int.TryParse(Console.ReadLine(), out int monthNumber);
            //Console.WriteLine(DateTime.DaysInMonth(2024, monthNumber));
            #endregion

            #region 7- Write a program to create a Simple Calculator.
            //Console.Write("Enter first number: ");
            //int.TryParse(Console.ReadLine(), out int firstNumber);
            //Console.Write("Choose one mathematical operation * / - +: ");
            //char.TryParse(Console.ReadLine(), out char sign);
            //Console.Write("Enter second number: ");
            //int.TryParse(Console.ReadLine(), out int secondNumber);

            //switch(sign)
            //{
            //    case '*':
            //        Console.WriteLine(firstNumber * secondNumber);
            //        break;
            //    case '/':
            //        if (secondNumber == 0)
            //        {
            //            Console.WriteLine("Can't divide by zero");
            //            break;
            //        }
            //        Console.WriteLine(firstNumber / secondNumber);
            //        break;
            //    case '+':
            //        Console.WriteLine(firstNumber + secondNumber);
            //        break;
            //    case '-':
            //        Console.WriteLine(firstNumber - secondNumber);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation!!");
            //        break;

            //}

            #endregion

            #region 8- Write a program to allow the user to enter int and print the REVERSED of it.
            //string term = Console.ReadLine();
            //for (int i = term.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(term[i]);
            //}
            #endregion

            #region 9- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of range: ");
            //int.TryParse(Console.ReadLine(), out int startNumber);
            //Console.Write("Input ending number of range: ");
            //int.TryParse(Console.ReadLine(), out int endNumber);


            //for (int i = startNumber; i <= endNumber; i++)
            //{
            //    if (i > 1)
            //    {
            //        bool flag = true; // reset flag

            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0 )
            //            {
            //                flag = false;
            //                break;
            //            }
            //        }
            //        if (flag) // prints all numbers without flag
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region 10- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int.TryParse(Console.ReadLine(), out int number);
            //string result = "";
            //while (number > 0)
            //{
            //    if (number % 2 == 0)
            //    {
            //        result += "0";
            //    }

            //    else
            //    {
            //        result += "1";
            //    }
            //    number = number / 2;
            //}

            ////Console.WriteLine(result);
            //for (int i = result.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(result[i]);
            //}
            #endregion
        }
    }
}
