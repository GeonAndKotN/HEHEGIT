using CallOfDuty;
using CallOfDuty.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGagaga
{
    public class TestDeleteStudent
    {
        [Test]
        public void SelectDuty_DeleteStudent()
        {
            Student studentToDelete = new Student
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
                Name = "Валера",
                Info = "test3"
            };
            Student student5 = new Student
            {
                Name = "newВалера",
                Info = "test4"
            };
            List<Student> students = new List<Student>()
            {
                studentToDelete, student2, student3, student4, student5
            };
            foreach (var student in students)
            {
                
                new CommandAddStudent().AddStudent("test.txt", student);
                
            }
            StudentRepository studentRepository = new StudentRepository("test.txt");
            foreach (var student in students)
            {
                Assert.IsTrue(studentRepository.Students.Contains(student));

            }
            
        }
    }
}
