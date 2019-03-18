using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        public string Name { get; }
        private List<Student> students = new List<Student>();
        public University(string name)
        {
            this.Name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            student.SetUniversity(this);
        }

        public int GetAverage()
        {
            int sum = 0;
            foreach (Student student in students)
            {
                sum += student.GetKnowledgeLevel();
            }
            return sum / students.Count;
        }
    }
}
