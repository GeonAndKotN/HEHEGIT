using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.menu
{
    public  class CommandAddStudent
    {
        public  void AddStudent(string file)
        {
            Console.Write("Введите фамилию студента: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите имя студента: ");
            string lastName = Console.ReadLine();
            var student = new Student()
            {
                Name = firstName,
                Info = lastName,
                DutyString = "НЕД"
            };
            AddStudent(file, student);
            Console.ReadKey();
        }
        public  void AddStudent(string file, Student student)
        {
            if (!File.Exists(file))
            {
                File.Create(file);
            }
            File.AppendAllText(file, $"{student.Name};{student.Info};{student.DutyString}" + Environment.NewLine);
            Console.WriteLine("Студент добавлен.");
            file.Select(x => x + Environment.NewLine);
            
        }
    }
}
