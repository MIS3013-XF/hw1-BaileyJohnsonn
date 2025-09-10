// HW1b Grade

// Your Name: Bailey Johnson 
// Did you seek help ? If yes, specify the helper or web link here: Max Ngo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Promt for student name
            Console.WriteLine("What is your firstname?");
            string firstname= Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname= Console.ReadLine();

            Console.WriteLine("What is your student id");
            int id = int.Parse(Console.ReadLine());

            //Promot Overall Percentage Grades
            Console.WriteLine("What is your overall percentage grade for homework?");
            double homework = double.Parse(Console.ReadLine());

            homework = 0.20 * homework;

            Console.WriteLine("What is your overall percentage grade for participation?");
            double participation = double.Parse(Console.ReadLine());

            participation = 0.15 * participation;

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizzes = double.Parse(Console.ReadLine());

            quizzes = 0.15 * quizzes;

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midterm = double.Parse(Console.ReadLine());

            midterm = 0.15 * midterm;

            Console.WriteLine("What is your overall percentage grade for the final?");
            double final = double.Parse(Console.ReadLine());

            final = 0.25 * final;


            double finalgrade = (homework + participation + quizzes + midterm + final);

            finalgrade = Math.Round(finalgrade, 2);

            Console.WriteLine(firstname + " " + lastname +" (" + id + "), your final grade is " + finalgrade + "%");
        }
    }
}
