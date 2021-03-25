using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_6
{
    public class Students
    {
        public List<string> ID { get; set; } = new List<string>();
        public string FullName { get; set; }
        public List<int> Marks { get; set; } = new List<int>();
        public List<Groups> Group = new List<Groups>();
        public double AverageMark
        {
            get
            {
                return Marks.Average();
            }
        }

    }

    public class Groups
    {
        public string NameGroup { get; set; } 
        public double IndexGroup { get; set; }
        public List<Students> Student = new List<Students>();

        class Program
        {
            static void Main(string[] args)
            {
                List<Groups> groups = new List<Groups>()
                {
                    new Groups
                    {
                        NameGroup="1GG",
                        IndexGroup=1112
                    }
                };
                List<Students> students = new List<Students>()
                {
                    new Students
                    {
                            Group=groups.Add,
                            ID = new List<string> {"0101" },
                            FullName = "Oleg Koshkin",
                            Marks = new List<int> { 9, 5, 6, 9, 8 }
                    },
                    new Students
                    {
                            Group="1GG",
                            ID = new List<string> {"0102" },
                            FullName = "Alesa Slivkina",
                            Marks = new List<int> { 7, 8, 10, 5, 6 }
                    },
                    new Students
                    {
                            Group="2GG",
                            ID = new List<string> {"0203"},
                            FullName = "Egor Pulkin",
                            Marks = new List<int> { 4, 5, 3, 6, 2 }
                    },
                    new Students
                    {
                            Group="2GG",
                            ID = new List<string> {"0204"},
                            FullName = "Alesa Slivkina",
                            Marks = new List<int> { 7, 8, 10, 5, 6 }
                    }
                };

            }


        }
    }
}
