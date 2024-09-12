using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.menu
{
    public class RemoveStudent
    {
        public void removeStudent(string file)
        {
            CommandListStudents showstudent = new CommandListStudents();
            showstudent.ShowStudents(file);

            Console.Write("Введите фамилию студента для удаления: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите имя студента для удаления: ");
            string lastName = Console.ReadLine();

            List<string> students = new List<string>(File.ReadAllLines(file));
            string studentToRemove = $"{firstName};{lastName};НЕД";

            if (students.Remove(studentToRemove))
            {
                File.WriteAllLines(file, students);
                Console.WriteLine("Студент успешно удалён!");
            }
            else Console.WriteLine("Йоу бро, нихрена не удалилось, что ты наделал?");
        }
    }
}
