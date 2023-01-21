namespace MyLibrary
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Surname: {LastName}, Name: {FirstName}, Date of Birth: {DateOfBirth.ToLongDateString()}";
        }
    }
}