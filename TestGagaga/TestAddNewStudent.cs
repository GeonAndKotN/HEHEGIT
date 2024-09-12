using CallOfDuty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestGagaga
{
    public class TestAddNewStudent
    {
        public bool СheckCreateNewStudent(Student student, List<Student> students)
        {
            foreach (var s in students)
            {
                if (s.Name == student.Name && s.Info == student.Info)
                    return false;
            }
            return true;
        }
        [Test]
        public void SelectDuty_CreateNewStudent()
        {
            Student student = new Student
            {
                Name = "Валера",
                Info = "test1"
            };
            Student student2 = new Student
         {
                Name = "Серега",
                 Info = "test2"
                 };
            Student student3 = new Student
            {
                Name = "Валера",
                Info = "test3"
            };
            Student student4 = new Student
            {
                Name = "newВалера",
                Info = "test4"
            };
            List<Student> newS = new List<Student>();
            newS.Add(student);
            newS.Add(student2);
            newS.Add(student3);
            int expected = 4;
            bool result1 = СheckCreateNewStudent(student4, newS);
            if (result1 == true)
                newS.Add(student4);
            int result = 0;
            foreach (var s in newS)
            {
                result++;
            }
            Assert.AreEqual(expected, result);
        }

    }
}
