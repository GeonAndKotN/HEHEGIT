using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.menu
{
    public class CommandListStudents
    {
        public void ShowStudents(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("Файл не найден.");
                Console.ReadKey();
                return;
            }

            string[] students = File.ReadAllLines(file);
            if (students.Length == 0)
            {
                Console.WriteLine("Список студентов пуст.");
            }
            else
            {
                Console.WriteLine("Список студентов:");
                foreach (var student in students)
                {
                    Console.WriteLine($"\n{student}");
                }
            }
            Console.ReadKey();
        }
    }
}
