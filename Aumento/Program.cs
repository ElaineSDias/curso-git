using System;
using System.Globalization;
namespace Aumento {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double Salario, Porcentagem, Aumento, Novosalario; 

            Console.WriteLine("Digite o salario da pessoa:");
            Salario = double.Parse(Console.ReadLine(), CI);

            if (Salario < 1000.0) {
                Porcentagem = 20;
            }
            else if (Salario > 1000.0 && Salario < 3000.0) {
                Porcentagem = 15;
            }
            else if (Salario > 3000.0 && Salario < 8000.0) {
                Porcentagem = 10;
            }
            else{
                Porcentagem = 5;

            }

            Aumento = Salario * Porcentagem/100;
            Novosalario = Salario + Aumento;

            Console.WriteLine("Novo salario : R$ "+Novosalario.ToString("F2", CI));
            Console.WriteLine("Aumento : R$ " + Aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem " + Porcentagem + "%");
        }

    }
}
