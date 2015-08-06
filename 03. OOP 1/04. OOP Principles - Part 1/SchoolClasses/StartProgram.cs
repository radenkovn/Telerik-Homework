using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class StartProgram
    {
        static void Main()
        {
            Console.WriteLine("Small Test:");
            Student mara = new Student("Mara", 55);
            Student pesho = new Student("Pesho", 44);
            Teacher joro = new Teacher("Joro");
            Discipline math = new Discipline("Mathematics", 15, 4);
            joro.AddDiscipline(math);
            SchoolClass myClass = new SchoolClass("1a");
            myClass.AddStudent(mara);
            myClass.AddStudent(pesho);
            myClass.AddTeacher(joro);
            Console.WriteLine(myClass);
            try
            {
                SchoolClass myClass2 = new SchoolClass("1a");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Student gosho = new Student("Gosho", 44);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
