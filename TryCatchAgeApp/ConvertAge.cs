using System;

namespace TryCatchAgeApp
{
    public class ConvertAge
    {
        public int FindYear(int age)
        {
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;
            if (birthYear >= DateTime.Now.Year)
            {
                throw new ZeroException();
            }
            else
            {
                return birthYear;
            }
        }
    }
}
