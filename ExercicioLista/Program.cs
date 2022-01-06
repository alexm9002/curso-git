using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will bee registered? ");
            int nun = int.Parse(Console.ReadLine());

            // List<string> list = new List<string>();

            for (int i = 1; i < nun; i++)
            {
                Console.WriteLine("Employee #" + i + " :");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                //   List.add(new Func(id, name, salario));
            }

            Console.WriteLine("Updated list of Employees:");
            Console.WriteLine();



        }
    }
}