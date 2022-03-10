using System;
using System.Collections.Generic;

namespace Ficha4_HeritageC_Sharp
{
    class Program
    {
        static List<Funcionario> funcionarios;
        static void Main(string[] args)
        {
            funcionarios = new List<Funcionario>();
            #region Funcs
            funcionarios.Add(new Gerente(1, "Paulo", new DateTime(1995 , 01 , 16), "paulo@paulo.pt", 32.5, "Caçador", 221597856));
            funcionarios.Add(new Gerente(2, "Manel", new DateTime(1981 , 05 , 21), "Manel@Manel.pt", 32.5, "Malandro", 22567521));
            funcionarios.Add(new Gerente(3, "Carla", new DateTime(1975 , 04 , 07), "Carla@Carla.pt", 25.5, "Agricultura", 226597523));
            funcionarios.Add(new Gerente(4, "Alberto", new DateTime(1997, 09, 26), "Alberto@Alberto.pt", 92.5, "Pesca", 223641579));
            funcionarios.Add(new Gerente(5, "Joana", new DateTime(1987 , 06 , 18), "Joana@Joana.pt", 32, "Politica", 220357802));
            funcionarios.Add(new Operario(6, "Joca", new DateTime(1967 , 04 , 16), "Joca@Joca.pt", 50.5, "IT"));
            funcionarios.Add(new Operario(7, "Ana", new DateTime(1992 , 11 , 10), "Ana@Ana.pt", 26, "Pecuaria"));
            funcionarios.Add(new Operario(8, "Marta", new DateTime(1989 , 01 , 05), "Marta@Marta.pt", 89.8, "Loja"));
            funcionarios.Add(new Operario(9, "Vitor", new DateTime(1988 , 12 ,21), "Vitor@Vitor.pt", 10.32, "Comunicações"));
            #endregion
            int op = 1;
            while (op != 0)
            {
                

                Console.Clear();
                Console.WriteLine("1-Inserir Gerente");
                Console.WriteLine("2-Inserir Operário");
                Console.WriteLine("3-Visualizar Gerentes");
                Console.WriteLine("4-Visualizar Operários");
                Console.WriteLine("5-Visualizar Funcionários");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        inserirGerente();
                        break;
                    case 2:
                        inserirOperario();
                        break;
                    case 3:
                        visualizarGerente();
                        break;
                    case 4:
                        visualizarOperario();
                        break;
                    case 5:
                        VisualizarFuncionarios();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void inserirGerente()
        {
            Console.Clear();

            Console.WriteLine("Insira o ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a data de nascimento: AAAA/MM/DD");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira o E-mail");
            string eMail = Console.ReadLine();
            Console.WriteLine("Insira o valor hora");
            double valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a Especialidade");
            string especialidade = Console.ReadLine();
            Console.WriteLine("Insira a Extensão");
            int extensao = int.Parse(Console.ReadLine());

            funcionarios.Add(new Gerente(id, nome, dataNasc, eMail, valorHora, especialidade, extensao));

            Console.WriteLine("Gerente inserido com sucesso!");
            Console.ReadKey();
        }

        private static void inserirOperario()
        {
            Console.Clear();

            Console.WriteLine("Insira o ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a data de nascimento: AAAA/MM/DD");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira o E-mail");
            string eMail = Console.ReadLine();
            Console.WriteLine("Insira o valor hora");
            double valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o departamento");
            string departamento = Console.ReadLine();


            funcionarios.Add(new Operario(id, nome, dataNasc, eMail, valorHora, departamento));

            Console.WriteLine("Operário inserido com sucesso!");
            Console.ReadKey();
        }

        private static void visualizarGerente()
        {

            Console.Clear();
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (typeof(Gerente) == funcionarios[i].GetType())
                {
                    Console.WriteLine(funcionarios[i].ToString());
                }
            }

            Console.WriteLine("Qual o ID do Gerente a alterar?");
            int op = int.Parse(Console.ReadLine());

            Console.Clear();

            int op2 = 1;
            while (op2 != 0)
            {
                Console.Clear();
                Console.WriteLine("1-Alterar Valor Hora");
                Console.WriteLine("2-Calcular Idade");
                Console.WriteLine("3-Calcular Salário");
                Console.WriteLine("0-Sair");
                op2 = int.Parse(Console.ReadLine());

                switch (op2)
                {
                    case 0:
                        break;
                    case 1:
                        Gerente.alterarValorHora(funcionarios, op);
                        break;
                    case 2:
                        Gerente.calcularIdade(funcionarios, op);
                        int valor= Gerente.calcularIdade(funcionarios, op);
                        Console.WriteLine("A idade do gerente é "+ valor);
                        Console.ReadKey();
                        break;
                    case 3:
                        Gerente.calcularSalario(funcionarios, op);
                        double salario = Gerente.calcularIdade(funcionarios, op);
                        Console.WriteLine("O salário do gerente é " + salario);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();
        }

        private static void visualizarOperario()
        {
            Console.Clear();
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (typeof(Operario) == funcionarios[i].GetType())
                {
                    Console.WriteLine(funcionarios[i].ToString());
                }
            }
            Console.ReadKey();
        }

        private static void VisualizarFuncionarios()
        {
            Console.Clear();
            for (int i = 0; i < funcionarios.Count; i++)
            {
                {
                    Console.WriteLine(funcionarios[i].ToString());
                }
            }
            Console.ReadKey();
        }
    }
}