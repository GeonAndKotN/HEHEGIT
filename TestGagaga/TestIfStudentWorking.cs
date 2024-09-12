using CallOfDuty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGagaga
{
    public class TestIfStudentWorking
    {
        [Test]
        public void ChangeDuty()
        {
            Student student = new Student
            {
                Name = "ВАСЯ",
                Info = "ПУПКИН",
                DutyString = "НЕД"
            };
            Student student2 = new Student
            {
                Name = "ГЕНА",
                Info = "INFO",
                DutyString = "НЕД"
            };
            Student student3 = new Student
            {
                Name = "GORDAN",
                Info = "INFO2",
                DutyString = "НЕД"
            };
            Student student4 = new Student
            {
                Name = "LOLKEK",
                Info = "INFO3",
                DutyString = "НЕД"
            };
            List<Student> students = new()
            {
                student, student2, student3, student4
            };
            for (int i = 0; i < 2; i++)
            {
                foreach (var dutyOrNo in students)
                {
                    if (student.DutyString == "НЕД")
                    {
                        student.DutyString = "ДЕЖ";
                    }
                    else
                        break;
                }
            }
        }
    }
}
