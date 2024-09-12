using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.Tests
{
    public class StudentRepositoryTests
    {
        List<Student> GetTestStudents()
        {
            return new List<Student> {
                new Student{ Name = "Валера", Info = "test1", DutyString = "ДЕЖ" },
                new Student{ Name = "Серега", Info = "test2", DutyString = "ДЕЖ" },
                new Student{ Name = "Валера", Info = "test3", DutyString = "ДЕЖ" }
            };
        }

        [Test]
        public void StudentRepository_StudentListNotNullAfterInit()
        {
            StudentRepository db = new StudentRepository();

            Assert.IsNotNull(db.Students);
            Assert.That(db.Students, Is.TypeOf<List<Student>>());
        }

        [Test]
        public void StudentRepository_LoadStudentsFromFileAfterInit()
        {
            string file = "testStudents.txt";
            StudentRepository db = new StudentRepository(file);
            var students = GetTestStudents();

            Assert.That(db.Students.Count, Is.EqualTo(students.Count));
            for (int i = 0; i < students.Count; i++)
            {
                Assert.That(db.Students[i].Name, Is.EqualTo(students[i].Name));
                Assert.That(db.Students[i].Info, Is.EqualTo(students[i].Info));
                Assert.That(db.Students[i].DutyString, Is.EqualTo(students[i].DutyString));
            }
        }
    }
}
