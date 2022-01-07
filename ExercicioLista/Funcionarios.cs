using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    internal class Funcionarios
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int codigo, string nome, double salario)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Salario = salario;
        }
        public void AumentarSalario(double percentual)
        {
            this.Salario += (this.Salario * percentual) / 100;
        }
        public override string ToString()
        {
            return this.Codigo
                + ", "
                + this.Nome
                + ", "
                + this.Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
