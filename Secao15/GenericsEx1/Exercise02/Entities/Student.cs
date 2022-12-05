using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Entities
{
    class Student
    {
        public int Codigo { get; set; }

        public Student(int codigo)
        {
            Codigo = codigo;
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return Codigo.Equals(other.Codigo);
        }
    }
}
