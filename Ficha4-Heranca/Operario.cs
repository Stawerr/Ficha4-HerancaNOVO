using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha4_HeritageC_Sharp
{
    class Operario : Funcionario
    {
        public string Departamento { get; set; }

        public Operario() : base()
        {

        }

        public Operario(int id, string nome, DateTime dataNasc, string eMail, double valorHora, string departamento) : base(id, nome, dataNasc, eMail, valorHora)
        {
            Departamento = departamento;
        }
        public Operario(Operario o) : base(o.Id, o.Nome, o.DataNasc, o.EMail, o.ValorHora)
        {
            Departamento = o.Departamento;
        }
        public override string ToString()
        {
            return base.ToString() + "\t Departamento: " + Departamento;
        }
    }
}
