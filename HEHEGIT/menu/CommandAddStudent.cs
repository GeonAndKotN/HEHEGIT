using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.menu
{
    public class CommandAddStudent
    {
        public void AddStudent(string file)
        {
            Console.Write("Введите фамилию студента: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите имя студента: ");
            string lastName = Console.ReadLine();
            File.AppendAllText(file, $"{firstName};{lastName};НЕД" + Environment.NewLine);
            Console.WriteLine("Студент добавлен.");
            file.Select(x => x + Environment.NewLine);
            Console.ReadKey();
            //баг, надо фиксить
        }
    }
}
