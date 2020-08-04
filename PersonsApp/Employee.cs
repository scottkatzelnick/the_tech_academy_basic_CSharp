namespace PersonsApp
{
    public class Employee : Person
    {
        public static bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Id.Equals(secondEmployee.Id);
        }

        public static bool operator !=(Employee firstEmployee, Employee secondEmployee)
        {
            return !firstEmployee.Id.Equals(secondEmployee.Id);
        }

        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var second = o as Employee;

            return second != null && Id == second.Id;
        }

        public override int GetHashCode()
        {
            return (int)Id;
        }
    }
}
