using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    internal class Employees
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; private set; }

        public Employees()
        {
        }
        public Employees(int id, string name, double salario)
        {

            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentarSalario(double percentual)
        {

            Salario += Salario * percentual / 100.0;

        }

        public override string ToString()
        {

            return Id
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
