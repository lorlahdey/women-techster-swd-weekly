using System;

namespace CalculatorClassLibrary
{
    public class Calculator
    {
        public decimal Num1;
        public decimal Num2;
        public string Operand;
        public decimal total;

        //Addition  
        public void Addition()
        {

            try
            {
                Console.Write("--------------------------------------------------");
                Console.Write("\n\nIt's time to get to some Addition Function :\n");
                Console.WriteLine("Enter the first input :");
                Num1 = Convert.ToDecimal(Console.ReadLine());
                System.Console.WriteLine("Enter the second input :");
                Num2 = Convert.ToDecimal(Console.ReadLine());
                total = Num1 + Num2;
                System.Console.WriteLine($"The Addition of the two Numbers entered is : {total}");
                // return total;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Check the value inputted into the calculator \n");
                // return e.Message;
            }
        }
        //Substraction  
        public void Subtraction()
        {

            try
            {
                Console.Write("\n--------------------------------------------------\n");
                Console.WriteLine("It's time to get to some Subtraction Function :");
                System.Console.WriteLine("Enter the first number :");
                Num1 = Convert.ToDecimal(Console.ReadLine());
                System.Console.WriteLine("Enter the second number :");
                Num2 = Convert.ToDecimal(Console.ReadLine());
                total = (Num1) - (Num2);
                System.Console.WriteLine($"The Subtraction of the two Numbers entered is : {total} ");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Ensure you entered the appropriate value into the calculator \n");
            }
        }

        //Multiplication 
        public void Multiplication()
        {
            try
            {
                Console.Write("\n--------------------------------------------------\n");
                Console.Write("\n\nIt's time to get to some Multiplication Function :\n");
                System.Console.WriteLine("Enter the first number :");
                Num1 = Convert.ToDecimal(Console.ReadLine());
                System.Console.WriteLine("Enter the second number :");
                Num2 = Convert.ToDecimal(Console.ReadLine());
                total = Num1 * Num2;
                System.Console.WriteLine($"The Multiplication of the two Numbers entered is : {total}");
                // return total;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Ensure you entered the right digits into the calculator \n");
            }

        }

        // Division
        public void Division()
        {
            try
            {
                Console.Write("\n--------------------------------------------------\n");
                Console.Write("\n\nIt's time to get to some Division Function :\n");
                System.Console.WriteLine("Enter the first number :");
                Num1 = Convert.ToDecimal(Console.ReadLine());
                System.Console.WriteLine("Enter the second number :");
                Num2 = Convert.ToDecimal(Console.ReadLine());

                // this is a guard function that won't let you divide by zero
                // if (Num2 == 0)
                // {
                //     System.Console.WriteLine("Cannot Divide by 0");
                // }
                // else
                // {
                total = Num1 / Num2;
                System.Console.WriteLine($"The Division of the two Numbers entered is : {total}");
                // return total;
                // }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("You " + e.Message);
                System.Console.WriteLine("Ensure you entered the appropriate value into the calculator \n");
            }
        }

        // Square Numbers
        public void SquareNum()
        {
            try
            {
                double Num3;

                Console.Write("\n--------------------------------------------------\n");
                Console.Write("\n\nIt's time to get to some Power Function :\n");
                System.Console.WriteLine("Enter the number you want to square:");
                Num3 = Convert.ToDouble(Console.ReadLine());
                total = (decimal)Math.Pow(Num3, 2);
                System.Console.WriteLine($"The Square valve of the input is : {total}");
                // return total;
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Ensure you entered the appropriate value into the calculator \n");
            }
        }

    }
}