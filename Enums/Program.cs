using System;

namespace Enums
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool valid = true;
            do
            {
                Console.Write("Please enter the current day of the week: ");
                string today = Console.ReadLine();

                try
                {
                    Day day = (Day)Enum.Parse(typeof(Day), today, true);
                    string dayOf = DateTime.Now.ToString("dddd");
                    string str = "";

                    switch (day)
                    {
                        case Day.Monday:
                            str = day.ToString();
                            valid = false;
                            break;

                        case Day.Tuesday:
                            str = day.ToString();
                            valid = false;
                            break;

                        case Day.Wednesday:
                            str = day.ToString();
                            valid = false;
                            break;

                        case Day.Thursday:
                            str = day.ToString();
                            valid = false;
                            break;

                        case Day.Friday:
                            str = day.ToString();
                            valid = false;
                            break;

                        case Day.Saturday:
                            str = day.ToString();
                            break;

                        case Day.Sunday:
                            str = day.ToString();
                            valid = false;
                            break;
                    }

                    if (dayOf.ToLower() == today.ToLower())
                    {
                        Console.WriteLine($"Today is indeed {str}!");
                    }
                    else
                    {
                        Console.WriteLine($"Today id {dayOf}, not {str}!");
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine($"\nError: {err.Message}\nPlease try again!\n");
                }
            } while (valid);

            Console.ReadLine();
        }
    }
}
