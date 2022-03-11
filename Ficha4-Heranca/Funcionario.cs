using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha4_HeritageC_Sharp
{
    class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string EMail { get; set; }
        public double ValorHora { get; set; }

        public Funcionario()
        {
            
        }

        public Funcionario(int id, string nome, DateTime dataNasc, string eMail, double valorHora)
        {
            Id = id;
            Nome = nome;
            DataNasc = dataNasc;
            EMail = eMail;
            ValorHora = valorHora;
        }
        public Funcionario(Funcionario f)
        {
            Id = f.Id;
            Nome = f.Nome;
            DataNasc = f.DataNasc;
            EMail = f.EMail;
            ValorHora = f.ValorHora;
        }
        public static void calcularIdade()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "ID: " + Id + "\t Nome: " + Nome + "\t Data Nascimento: " + DataNasc.ToShortDateString() + "\t E-Mail: " + EMail + "\t Valor Hora :" + ValorHora;
        }
    }

}
