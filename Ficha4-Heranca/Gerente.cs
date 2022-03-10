using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha4_HeritageC_Sharp
{
    class Gerente : Funcionario
    {

        public string Especialidade { get; set; }
        public int Extensao { get; set; }

        public Gerente() : base()
        {

        }

        public Gerente(int id, string nome, DateTime dataNasc, string eMail, double valorHora, string especialidade, int extensao) : base(id, nome, dataNasc, eMail, valorHora)
        {
            Especialidade = especialidade;
            Extensao = extensao;
        }
        public Gerente(Gerente g) : base(g.Id, g.Nome, g.DataNasc, g.EMail, g.ValorHora)
        {
            Especialidade = g.Especialidade;
            Extensao = g.Extensao;
        }
        public override string ToString()
        {
            return base.ToString() + "\t Especialidade: " + Especialidade + "\t Extensão: " + Extensao;
        }
        public static void alterarValorHora(List<Funcionario> funcionarios, int op)
        {
            int bandeira = 0;
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (typeof(Gerente) == funcionarios[i].GetType() && funcionarios[i].Id == op)
                {
                    Console.WriteLine("Insira o novo salário");
                    double sal = double.Parse(Console.ReadLine());
                    funcionarios[i].ValorHora = sal;
                    bandeira = 1;
                }
            }
            if (bandeira == 0)
            {
                Console.WriteLine("Gerente não encontrado");
            }
            Console.ReadKey();
        }
        public static int calcularIdade(List<Funcionario> funcionarios, int op)
        {
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (typeof(Gerente) == funcionarios[i].GetType() && funcionarios[i].Id == op)
                {
                    if (funcionarios[i].DataNasc.DayOfYear > DateTime.Now.DayOfYear)
                    {
                        return DateTime.Now.Year - funcionarios[i].DataNasc.Year - 1;
                    }
                    return DateTime.Now.Year - funcionarios[i].DataNasc.Year;
                }
            }
            return 0;
        }

        public static double calcularSalario(List<Funcionario> funcionarios, int op)
        {
            Console.WriteLine("Quantas horas trabalha por dia?");
            double horas= int.Parse(Console.ReadLine());

            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (typeof(Gerente) == funcionarios[i].GetType() && funcionarios[i].Id == op)
                {
                    horas = horas * funcionarios[i].ValorHora;
                    double salario= horas * DateTime.DaysInMonth(DateTime.Today.Day,DateTime.Today.Month);
                    return salario;
                }
            }
            return 0;
        }
    }
}