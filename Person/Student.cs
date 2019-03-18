using System;
using InternshipTest.Institution;

namespace InternshipTest.Person
{
    public class Student
    {
        public readonly string name;

        private University university; 

        private Knowledge knowledgeLevel;

        public Student(string name)
        {
            this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            if (knowledge.level >= 0 && knowledge.level <= 100)
            {
                this.knowledgeLevel = knowledge;
            } else
            {
                this.knowledgeLevel = new Knowledge(0);
            }
        }

        public int GetKnowledgeLevel()
        {
            return this.knowledgeLevel.level;
        }

        public void SetUniversity(University university)
        {
            this.university = university;
        }

        public University GetUniversity()
        {
            return this.university;
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}