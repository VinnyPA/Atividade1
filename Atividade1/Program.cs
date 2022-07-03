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
            int ntrabalho, n1, n2, media;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a nota de trabalho: ");
            ntrabalho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota da primeira prova: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            media = (ntrabalho + n1 + n2) / 3;

            
            

            Console.ReadKey();
        }
    }
}
