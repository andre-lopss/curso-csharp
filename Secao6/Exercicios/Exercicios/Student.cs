namespace Exercicios
{
    class Student
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        public Student(string nome, string email)
        {
            StudentName = nome;
            StudentEmail = email;
        }
        public override string ToString()
        {
            return StudentName + ", " + StudentEmail;
        }
    }
}
