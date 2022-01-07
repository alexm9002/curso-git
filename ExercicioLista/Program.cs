using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos funcionários você deseja registrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Funcionarios> lista = new List<Funcionarios>();

            for (int i = 1; i <= quantidade; i++) {
                Console.WriteLine("Employee #" + i + " :");
                Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionarios(codigo, nome, salario));
            }

            Console.Write("Entre com o funcionário que irá receber aumento: ");
            int procuraCodigo = int.Parse(Console.ReadLine());

            Funcionarios empregado lista.Find(x => x.Codigo == procuraCodigo);

            if (empregado != null) {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregado.AumentarSalario(porcentagem);
            }
            else {
                Console.WriteLine("Código Inexistente");
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Lista atualizada de funcionários: ");

            foreach (Funcionarios obj in lista) {
                Console.WriteLine(obj);
            }



            Console.WriteLine();



        }
    }
}