using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string Name { get; }

        private List<Student> students = new List<Student>();

        public Internship(string name)
        {
            this.Name = name;
        }

        public void ApplyStudent(Student student)
        {
            if (student.GetKnowledgeLevel() >= student.GetUniversity().GetAverage())
            {
                students.Add(student);
            }
        }

        public string GetStudents()
        {
            return string.Join("\n", students);
        }
    }
}
