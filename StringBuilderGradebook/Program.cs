using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int studentID = 0;

            Console.WriteLine("Enter your students ID (or 0 to finish):");
            do
            {
                Console.Write("ID: ");
                studentID = int.Parse(Console.ReadLine());
                if (studentID != 0)
                {
                    // Get the student's grade
                    Console.Write("name: ");
                    string studentName = Console.ReadLine();

                    students.Add(studentID, studentName);
                }
            }
            while (studentID != 0);

            // Print class roster
            StringBuilder TheRoster = new StringBuilder();


            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                TheRoster.Append(student.Key + " (" + student.Value + ")\n");
                //Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
            Console.WriteLine(TheRoster);
            Console.ReadLine();
        }
    }
}