using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public class Students
        {
            public List<string> ID { get; set; } = new List<string>();
            public string FullName { get; set; }
            public List<int> Marks { get; set; } = new List<int>();
            public double AverageMark
            {
                get
                {
                    return Marks.Average();
                }
            }
            public void PrintInformationOfStudents()
            {
                foreach (var student in FullName)
                {

                    var marksStudent = string.Join(", ", Marks);
                    var averageSstudentsMark = string.Join("  ", AverageMark);
                    var idStudent = string.Join("  ", ID);
                    Console.WriteLine($"{FullName}  " + "\n" +
                    $"ID: {idStudent} " + "\n" +
                    $"Оценки:{marksStudent} " + "\n" +
                    $"Средняя оценка:{averageSstudentsMark}");
                }
            }
            public class Groups
            {
                public List<string> NameGroup { get; set; } = new List<string>();
                public List<string> IndexGroup { get; set; } = new List<string>();
                public List<Students> Student = new List<Students>();
                public void PrintInformationOfStudents()
                {
                    foreach (var student in Student)
                    {
                        var marksStudent = string.Join(", ", student.Marks);
                        var averageSstudentsMark = string.Join("  ", student.AverageMark);
                        var idStudent = string.Join("  ", student.ID);
                        Console.WriteLine($"{student.FullName}  " + "\n" +
                        $"ID: {idStudent} " + "\n" +
                        $"Оценки:{marksStudent} " + "\n" +
                        $"Средняя оценка:{averageSstudentsMark}");
                    }
                }

                public void PrintInformationOfGroup()
                {
                    foreach (var information in Student)
                    {
                        var nameGR = string.Join("  ", NameGroup);
                        var indexGR = string.Join("  ", IndexGroup);
                        var students = string.Join("  ", information.FullName);
                        Console.WriteLine($"{nameGR}  " + "\n" +
                        $"Index : {indexGR} " + "\n" +
                        $"Студенты:{students} ");

                    }
                }

                static void Main(string[] args)
                {
                    var groupWithStudents = new List<Groups>()
                    {
                          new Groups()
                          {
                                NameGroup = new List<string> { "Group Good" },
                                IndexGroup = new List<string> { "1GG" },
                                Student = new List<Students>()
                                {
                                    new Students
                                    {
                                            ID = new List<string> {"0101" },
                                            FullName = "Oleg Koshkin",
                                            Marks = new List<int> { 9, 5, 6, 9, 8 }
                                    },
                                    new Students
                                    {
                                            ID = new List<string> {"0102" },
                                            FullName = "Alesa Slivkina",
                                            Marks = new List<int> { 7, 8, 10, 5, 6 }
                                    }
                                }
                          },
                          new Groups()
                          {
                                NameGroup = new List<string> { "Group Evil" },
                                IndexGroup = new List<string> { "2GE" },
                                Student = new List<Students>()
                                {
                                    new Students
                                    {
                                            ID = new List<string> {"0203"},
                                            FullName = "Egor Pulkin",
                                            Marks = new List<int> { 4, 5, 3, 6, 2 }
                                    },
                                    new Students
                                    {
                                            ID = new List<string> {"0204"},
                                            FullName = "Alesa Slivkina",
                                            Marks = new List<int> { 7, 8, 10, 5, 6 }
                                    }
                                }
                          }
                    };
                    Console.WriteLine(groupWithStudents);
                    Console.WriteLine("Добро пожаловать в приложение управления студентами и группами!");
                    Console.WriteLine(
                        "Вам представлен выбор позможных операций, которые Вы можете совершить в данном приложении." + "\n" +
                        "Список возмжных операций:" + "\n" +
                        "1. Вывести на консоль информацию о студентах." + "\n" +
                        "2. Вывести наименований информацию о группах студентов." + "\n" +
                        "3. Вывести имен студентов и их оценок со средним баллом в выбранной группе." + "\n" +
                        "4. Провести манипуляции со студентами." + "\n" +
                        " ");
                    groupWithStudents.ToList();
                    foreach (var groups in groupWithStudents)
                    {
                       // var result = string.Join(", ", groups);
                       //Console.WriteLine($"{result}");
                       // Console.WriteLine("Выберите операцию:");
                        var selection1 = Console.ReadLine();
                        switch (selection1)
                        {
                            case "1":
                                groups.PrintInformationOfStudents();

                                break;
                            case "2":
                                groups.PrintInformationOfGroup();
                                break;

                            default:
                                goto case "1";
                        }
                    }

                   
                    Console.WriteLine("Вывести имен студентов и их оценок со средним баллом в выбранной группе." + "\n" +
                            "Выберите группу:" + "\n" +
                            "3. Вывести информацию о группе Good Group" + "\n" +
                            "4. Вывести информацию о группе Group Evil");

                    Console.WriteLine("Выберите операцию:");
                    var selection2 = Console.ReadLine();
                    switch (selection2)
                    {
                        case "3":

                            break;
                        case "4":

                            break;
                    }
                }
            }

        }
    }
}




























