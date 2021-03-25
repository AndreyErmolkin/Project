using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_1._0
{
    class Program
    {
        public class Students
        {
            public double ID { get; set; }
            public string FullName { get; set; }

            public List<int> Marks { get; set; } = new List<int>();

            public double AverageMark
            {
                get
                {
                    return Marks.Average();
                }
            }
            public void PrintMarks()
            {
                foreach (var mark in Marks)
                    Console.WriteLine(mark);
            }

            public class GroupsWithStudents
            {
                public string NameGroup { get; set; }
                public List<Students> Student = new List<Students>();
                public void PrintAverageMark()
                {
                    foreach (var student in Student)
                    {
                        Console.WriteLine($"{student.FullName}:{student.ID}:{student.AverageMark}");
                    }
                }
                public void PrintMarks()
                {
                    foreach (var student in Student)
                    {
                        var marksStudent = string.Join("  ", student.Marks);
                        Console.WriteLine($"{student.FullName}:{student.ID}:{marksStudent}");

                    }


                }
                static void Main(string[] args)
                {

                    Console.WriteLine("Добро пожаловать в программу по управлению студентами!" + "\n" +
                "Выберите действие, которое Вы хотите совершить:" + "\n" +
                "1)Вывести название групп студентов" + "\n" +
                "2)Выбрать группу студентов" + "\n" +
                "3)Вывести информацию о конкретном студенте;" + "\n" +
                "4)Произвести изменения ");

                }


            }
        }
    }
}
















