using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpsIniciates
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            decimal id;
            decimal nota1;
            decimal nota2;
            decimal nota3;
            decimal Faltas;
            decimal res;

            Console.WriteLine("Digite o nome seu nome ? ");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu id");
            id = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite A quantidade de faltas no semestre");
            Faltas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe sua nota do tea ? ");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a nota da sua n1 ? ");
            nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a nota da sua n3 ?");
            nota3 = Convert.ToDecimal(Console.ReadLine());
            
            res = (nota1 * 2 + nota2 * 2 + nota3 * 6) / 10;

            if (res == 6 && Faltas == 6)
            {
                Console.WriteLine("Parabens vc passou de semestre..." + res);
            }
            else 
            {
                
                Console.WriteLine("Ficou de dp.");
            }



            Console.ReadKey();
        }
        
    }
}
