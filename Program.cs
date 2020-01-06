using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void getPrefix(string StudName)
        {
            Console.WriteLine("Enter the Gender");
            char gender = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (gender.ToString())
            {
                case "F":
                    Console.WriteLine($"Ms.{StudName}");
                    break;
                case "M":
                    Console.WriteLine($"Mr.{StudName}");
                    break;
                default:
                    Console.WriteLine("Please enter the gender");
                    break;

            }
        }
        static void Main(string[] args)
        {
            //string[] StudentName = new string[10] { "Ishwariya", "Soniya", "Yuvarani", "Pricilla","Hema","Meenu","Arul","Mukesh","Shanu","Rohini"};
            string[] StudentName = new string[10];
            int i;
            int j = 1;
            Console.WriteLine("Enter 10 Student Names one by one:");
            for (i = 0; i < 10; i++)
            {
                //Console.WriteLine("Enter 10 Student Names one by one:");
                Console.WriteLine($"Enter Detail of Student {j++}:");
                Console.WriteLine($"Enter name of Student:");
                StudentName[i] = Console.ReadLine();
                getPrefix(StudentName[i]);

            }
            Console.ReadLine();
        }
    }
}