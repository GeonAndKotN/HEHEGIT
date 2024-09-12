using CallOfDuty;
using CallOfDuty.menu;
using System;

try
{
    var mainMenu = new MainMenu("Students.txt", "dutys");
    var showStudents = new CommandListStudents();
    var addStudent = new CommandAddStudent();
    var delStudent = new CommandRemoveStudent();
    var editStudent = new CommandEditStudent();
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Начать поиск жертвы");
    Console.WriteLine("2. Добавить студента");
    Console.WriteLine("3. Удалить студента");
    Console.WriteLine("4. Редактировать студента");
    Console.WriteLine("5. Показать всех студентов");
    Console.Write("Выберите действие: ");
    string vibor = Console.ReadLine();
    switch (vibor)
    {
        default:
            Console.WriteLine("Выберите действие!!!");
            return;
    case "1":
        mainMenu.Run();
        return;
    case "2":
            addStudent.AddStudent("Students.txt");
        return; 
    case "3":
            delStudent.removeStudent("Students.txt");
        return;
    case "4":
            editStudent.EditStudent("Students.txt");
        return; 

    case "5":
            showStudents.ShowStudents("Students.txt");
        return; 
    
    }
}
catch (SelectDutyException ex)
{
    Console.WriteLine(ex.Message);
}
catch (StudentDutyException ex)
{
    Console.WriteLine(ex.Message);
}