using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

                // Input marks for 5 subjects
                Console.WriteLine("Enter marks for each subject (out of 100):");

                Console.Write("Subject 1: ");
                double subject1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Subject 2: ");
                double subject2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Subject 3: ");
                double subject3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Subject 4: ");
                double subject4 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Subject 5: ");
                double subject5 = Convert.ToDouble(Console.ReadLine());

                // Calculate total and percentage
                double totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
                double maximumMarks = 500;
                double percentage = (totalMarks / maximumMarks) * 100;

                // Determine grade based on percentage
                string grade = GetGrade(percentage);

                // Display results
                Console.WriteLine("\nResults:");
                Console.WriteLine("Total Marks: " + totalMarks);
                Console.WriteLine("Percentage: " + percentage.ToString("0.00") + "%");
                Console.WriteLine("Grade: " + grade);
            }

            // Function to determine grade based on percentage
            static string GetGrade(double percentage)
            {
                if (percentage >= 80)
                {
                    return "A";
                }
                else if (percentage >= 65)
                {
                    return "B";
                }
                else if (percentage >= 50)
                {
                    return "C";
                }
                else if (percentage >= 40)
                {
                    return "D";
                }
                else if (percentage >= 33.99)
                {
                    return "F";
                }
                else
                {
                    return "Invalid";
                }
            
        


    }
}
}
