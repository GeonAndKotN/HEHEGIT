using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.menu
{
    public  class CommandRemoveStudent
    {
        public  void removeStudent(string file, Student student)
        {
            CommandListStudents showstudent = new CommandListStudents();
            showstudent.ShowStudents(file);

            List<string> students = new List<string>(File.ReadAllLines(file));
            string studentToRemove = $"{student.Name};{student.Info};{student.DutyString}";

            if (students.Remove(studentToRemove))
            {
                File.WriteAllLines(file, students);
                Console.WriteLine("Студент успешно удалён!");
            }
            else Console.WriteLine("Йоу бро, нихрена не удалилось, что ты наделал?");
        }
        public  void removeStudent(string file)
        {
            Console.Write("Введите фамилию студента!");
            var lastname = Console.ReadLine();
            Console.Write("Введите имя студента!");
            var name = Console.ReadLine();
            var student = new Student()
            {
                Name = name, Info = lastname, DutyString = "НЕД"
            };
            removeStudent(file, student);
        }
    }
}
