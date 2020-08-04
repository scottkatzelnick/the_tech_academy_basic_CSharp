namespace Abstracts
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        abstract public void SayName();
    }
}
