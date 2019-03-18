using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alex Kostenko");
            Student s2 = new Student("Maria Veselkina");
            Student s3 = new Student("Julia Prechrest");
            Student s4 = new Student("Andriy Vorochinsky");
            Student s5 = new Student("Vladyslav Machete");
            s1.SetKnowledge(new Knowledge(20));
            s2.SetKnowledge(new Knowledge(38));
            s3.SetKnowledge(new Knowledge(54));
            s4.SetKnowledge(new Knowledge(84));
            s5.SetKnowledge(new Knowledge(46));


            University university1 = new University("CH.U.I.");
            university1.AddStudent(s1);
            university1.AddStudent(s2);
            university1.AddStudent(s3);

            University university2 = new University("L.N.U");
            university2.AddStudent(s4);
            university2.AddStudent(s5);

            Internship internship = new Internship("Interlink");
            internship.ApplyStudent(s1);
            internship.ApplyStudent(s2);
            internship.ApplyStudent(s3);
            internship.ApplyStudent(s4);
            internship.ApplyStudent(s5);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
