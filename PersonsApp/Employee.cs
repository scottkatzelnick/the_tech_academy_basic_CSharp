using System.Collections.Generic;

namespace PersonsApp
{
    public class Employee<T> : Person
    {
        public List<T> Things { get; set; }

        public static bool operator ==(Employee<T> firstEmployee, Employee<T> secondEmployee)
        {
            return firstEmployee.Id.Equals(secondEmployee.Id);
        }

        public static bool operator !=(Employee<T> firstEmployee, Employee<T> secondEmployee)
        {
            return !firstEmployee.Id.Equals(secondEmployee.Id);
        }

        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var second = o as Employee<T>;

            return second != null && Id == second.Id;
        }

        public override int GetHashCode()
        {
            return (int)Id;
        }
    }
}
