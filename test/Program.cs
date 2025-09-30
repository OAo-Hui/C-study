using System;
using System.Collections.Generic;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("Please enter student ID (if you want to break please enter '0')");
                string id = Console.ReadLine();

                if (id == "0")
                    break;

                Console.WriteLine("Please enter Chinese score");
                int chinese = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Math score");
                int math = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter English score");
                int english = int.Parse(Console.ReadLine());

                Student stu = new Student(id, chinese, math, english);
                students.Add(stu);

                Console.WriteLine("Student added successfully!");

              
            }
            if (students.Count > 0)
            {
                for(int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"Student ID: {students[i].Id}, Average Score: {students[i].GetAverage()}");
                }

                double total = 0;
                for (int i = 0; i < students.Count; i++)
                {
                    total += students[i].GetAverage();
                }
                double clasAverage = total / students.Count;
                Console.WriteLine($"The class average score is: {clasAverage}");
            }
        }

        class Student
        {                                                    
            public string Id { get; set; }
            public int Chinese { get; set; }
            public int Math { get; set; }
            public int English { get; set; }

            public Student(string id, int chinese, int math, int english)
            {
                Id = id;
                Chinese = chinese;
                Math = math;
                English = english;
            }

            public double GetAverage()
            {
                return (Chinese + Math + English) / 3.0;
            }
        }
    }
}
