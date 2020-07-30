using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Pick a number\n>>>: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick a second number\n>>>: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Divide the two . . .");
            int quotient = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + quotient);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.Write(ex.Message);  // or Console.Write("tpye-your-own-message-here");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.Write(ex.Message);  // or Console.Write("tpye-your-own-message-here");
            return;
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);  // Allow this generic error to display, whatever it may be.
            return;
        }
        finally  // Runs no matter what
        {
            Console.ReadLine();
        }
    }
}
