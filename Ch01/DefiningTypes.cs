namespace Ch01
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

}