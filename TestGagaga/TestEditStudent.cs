using CallOfDuty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGagaga
{
    public class TestEditStudent
    {
        [Test]
        public void SelectDuty_RedactStudent()
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
            Student student4 = new Student
            {
                Name = "Валера",
                Info = "test1"
            };
            Student student5 = new Student
            {
                Name = "newВалера",
                Info = "test4"
            };
            List<Student> updeted = new List<Student>();
            updeted.Add(student); updeted.Add(student2);
            bool expected1 = true; bool expected2 = false;
            string newname1 = "newВалера"; string
            newname2 = null; string newinfo1 = null;
            string newinfo2 = "test4"; Student
            updetedStudent = new(); bool result1 = false;
            bool result2 = false; foreach (var s in updeted)
            {
                if (s.Name == student5.Name && s.Info == student5.Info)
                    result2 = Update(s, newname1, newinfo1); ;
                if (s.Name == student4.Name && s.Info == student4.Info)
                {
                    result1 = Update(s, newname1, newinfo1);
                }
            }
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(student.Name, newname1);
            Assert.AreEqual(student.Info, "test1");
            result1 = Update(student, newname2, newinfo2);
            Assert.AreEqual(student.Info, newinfo2);
            Assert.AreEqual(student.Name, newname1);
            Assert.AreEqual(student.Info, "test1");
        }
public bool Update(Student student, string name1, string name2)
        {
            if (student == null)
                return false; if (name1 ==
                null) student.Info =
                name2;
            else if (name2 ==
                null) student.Name =
                name1;
            return true;
        }

    }
}
