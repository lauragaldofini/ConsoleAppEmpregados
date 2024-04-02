using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFuncWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double total = 0;
            string resp;
            Console.WriteLine("Deseja começar? (S/N)");
            resp = Console.ReadLine().ToUpper();
            while (resp == "S")
            {
                Console.WriteLine("Qual a forma de contratação do funcionário? [A-Assalariado,C-Comissado,H-Horista]");
                string resp2= Console.ReadLine().ToUpper();
                switch (resp2)
                {
                    case "A":
                        Console.WriteLine("Informe o valor do salário do funcionário: ");
                        double salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe qual é o valor do desconto: ");
                        double desconto = double.Parse(Console.ReadLine());
                        double salariob = salario - desconto;
                        Console.WriteLine("O salário bruto é de: " + salariob.ToString("C"));
                        cont++;
                        total += salariob;
                        break;

                    case "H":
                        Console.WriteLine("Digite o valor por hora: ");
                        double valh = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite qual a quantidade de horas trabalhadas: ");
                        int quantporh = int.Parse(Console.ReadLine());

                        salariob = quantporh * valh;
                        Console.WriteLine("O salário bruto é: " + salariob.ToString("C"));
                        cont++;
                        total += salariob;
                        break;

                    case "C":
                        Console.WriteLine("Insira o valor que o funcionário ganha por peça: ");
                        double valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantas peças o funcionário vendeu no total?: ");
                        int quant = int.Parse(Console.ReadLine());

                        salariob = quant * valor;
                        Console.WriteLine("O salário bruto é de: " + salariob.ToString("C"));
                        cont++;
                        total += salariob;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Deseja continuar?: ");
                resp = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("O número de funcionários cadastrados foi: " + cont);
            Console.WriteLine("A média dos salários é: " + (total / cont).ToString("C"));
            Console.WriteLine("O total da folha de pagamento é: " + total.ToString("C"));
            Console.ReadKey();

        }
    }
}