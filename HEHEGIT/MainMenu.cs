using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty
{
    public class MainMenu
    {

        public readonly StudentRepository studentRepository;
        public readonly StudentDuty studentDuty;
        public readonly SelectDuty todayDuty;
        public MainMenu(string file, string folder) 
        { 
             studentRepository = new StudentRepository(file);
             studentDuty = new StudentDuty(studentRepository, folder);
             todayDuty = new SelectDuty(studentDuty);
        }
        private string GetStudentInfo(Student student, ref int index)
        {
            return $"#{index++} {student.Name} {student.Info} {student.DutyString}";
        }
        public void Run()
        {
            while (todayDuty.CountApproved < 2)
            {
                int index = 1;
                foreach (var student in todayDuty.Students)
                    Console.WriteLine($"#{index++} {student.Name} {student.Info} {student.DutyString}");

                Console.WriteLine("Укажите индекс студента и через пробел знак + или - для подтверждения или отмены участия студента в святом дежурстве");

                var answer = Console.ReadLine();
                var cols = answer.Split();
                if (cols.Length != 2)
                    continue;
                if (!int.TryParse(cols[0], out index))
                {
                    Console.WriteLine("Неверно указан индекс студента. Укажите число первым в строке");
                    continue;
                }
                string action = cols[1];
                if (action != "+" && action != "-")
                {
                    Console.WriteLine("Действие должно обозначаться как + или -");
                    continue;
                }
                index--;
                if (cols.Length > index && index >= 0)
                {
                    if (action == "+")
                        todayDuty.Approve(todayDuty.Students[index]);
                    else
                        todayDuty.RejectAndGetAnotherStudent(todayDuty.Students[index]);
                }
            }
            todayDuty.Save();
            Console.WriteLine("Дежурные сегодня:");
            foreach (var student in todayDuty.Students)
            {
                student.DutyString = "ДЕЖ";
                Console.WriteLine($"{student.Name} {student.Info} {student.DutyString}");
            }
        }
    }
}
