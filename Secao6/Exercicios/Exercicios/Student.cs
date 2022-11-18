namespace Exercicios
{
    class Student
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        public Student(string name, string email)
        {
            StudentName = name;
            StudentEmail = email;
        }
        public override string ToString()
        {
            return "Student: " + StudentName + ", email: " + StudentEmail;
        }
    }
}