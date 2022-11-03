using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.SA03
{
    internal class Program
    {
        static void Main(string[] args)
        { //1. Fonte de dados (Vetor, Matriz, Collections, .xls, Xml, .txt, .csv, .dat, .sql)
          // A fonte escolhida será um vetor

            int[] votos = new int[10] {1, 2, 3, 4, 5, 6, 7, 5, 3, 7};

            //2. Consulta: Query sintax.Linq
            var consulta = from voto in votos
                           select voto;



         //3. Executando Consulta

         // Usando for ao invés de foreach: for (int i =0; i < votos.Lenght; i++) console.Writeline (votos[i]);
         // Listando com foreach
         foreach (var voto in consulta)
            {
                Console.WriteLine(voto);
                  
            }
         Console.ReadKey(); 
         // Listando com Tolist()
         /*var votosFiltrados = consulta.ToList();
            Console.WriteLine($"Votos filtrados:{votosFiltrados}");
            Console.ReadKey(); */
        }
    }
}
