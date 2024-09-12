using CallOfDuty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGagaga
{
    public class TestForCreateNewStudent
    {
        [Test]
        public void SelectDuty_СheckCreateNewStudent()
        {
            Student student = new Student
            {
                Name = "Валера",
                Info = "test1",
                DutyString = "НЕД"
            };
            Student student2 = new Student
            {
                Name = "Серега",
                Info = "test2",
                DutyString = "НЕД"
            };
            Student student3 = new Student
            {
                Name = "Валера",
                Info = "test3",
                DutyString = "НЕД"
            };
            Student student4 = new Student
            {
                Name = "newВалера",
                Info = "test4",
                DutyString = "НЕД"
            };
            Student student5 = new Student
            {
                Name = "Валера",
                Info = "test3",
                DutyString = "НЕД"
            };
            List<Student> newS = new List<Student>();
            newS.Add(student);
            newS.Add(student2);
            newS.Add(student3);
            bool expected1 = true;
            bool expected2 = false;
            bool result1 = СheckCreateNewStudent(student4, newS);
            bool result2 = СheckCreateNewStudent(student5, newS);
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
        }
        public bool СheckCreateNewStudent(Student student, List<Student> students)
        {
            foreach (var s in students)
            {
                if (s.Name == student.Name && s.Info == student.Info)
                return false;
            }
            return true;
        }

    }
}
