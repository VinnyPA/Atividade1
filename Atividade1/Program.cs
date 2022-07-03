using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome; 
            double ntrabalho, n1, n2, media;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a nota de trabalho: ");
            ntrabalho = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da primeira prova: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            n2 = double.Parse(Console.ReadLine());

            media = (ntrabalho + n1 + n2) / 3;

            if (media >= 8.50 && media <= 10)
            {
                Console.WriteLine("Nota :" + media.ToString("n1"));
                Console.WriteLine("Parabéns " + nome + ", você teve um rendimento final EXCELENTE!");
            }
            else if (media >= 7.0 && media >= 6.4)
            {

                Console.WriteLine("Nota :" + media.ToString("n1"));
                Console.WriteLine("Parabens " + nome + ", você teve um BOM. Estude para ter um rendimento melhor!");
            }
            else if (media >= 6.0 && media <= 6.9)
            {
                Console.WriteLine("Nota :" + media.ToString("n1"));
                Console.WriteLine(nome + ", você está aprovado, porém com uma nota razoavel, você pode melhorar!");
            }
            else if (media >= 0.1 && media <= 5.9)
            {
                Console.WriteLine("Nota :" + media.ToString("n1"));
                Console.WriteLine(nome + ", Você está reprovado, estude mais para a proxima avalização!" );
            }
            else if (media == 0.00)
            {
                Console.WriteLine("Nota :" + media.ToString("n1"));
                Console.WriteLine(nome + ", você foi reprovado, estude mais para a proxima avalização!");
            }

            Console.ReadKey();
        }
    }
}
