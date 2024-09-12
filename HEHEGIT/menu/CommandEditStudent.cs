using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.menu
{
    public class CommandEditStudent
    {
        public void EditStudent(string file) 
        {
            CommandListStudents showstudent = new CommandListStudents();
            showstudent.ShowStudents(file);
            Console.Write("Введите фамилию студента для редактирования: ");
            string oldFirstName = Console.ReadLine();
            Console.Write("Введите имя студента для редактирования: ");
            string oldLastName = Console.ReadLine();

            List<string> students = new List<string>(File.ReadAllLines(file));
            string oldStudent = $"{oldFirstName};{oldLastName};НЕД";

            if (students.Contains(oldStudent))
            {
                Console.Write("Введите новую фамилию студента: ");
                string newFirstName = Console.ReadLine();
                Console.Write("Введите новое имя студента: ");
                string newLastName = Console.ReadLine();
                students[students.IndexOf(oldStudent)] = $"{newFirstName};{newLastName};НЕД";
                File.WriteAllLines(file, students);
                Console.WriteLine("Студент отредактирован.");
            }
            else
            {
                Console.WriteLine("Студент не найден. Нажмите любую клавишу для продолжения.");
            }
        }
    }
}
