using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA005
{
    internal class Program
    {

        public static List<Disciplina> Disciplinas = new List<Disciplina>
        {
            new Disciplina{NomeDisciplina="Neurociência e Aprendizagem",DataInicial=new DateTime(2022,08,08), DataFinal=new DateTime(2022,09,12)},
            new Disciplina{NomeDisciplina="Habilidade Socioemocionais",DataInicial=new DateTime(2022,08,10), DataFinal=new DateTime(2022,08,24)},
            new Disciplina{NomeDisciplina="Felicidade",DataInicial=new DateTime(2022,08,31), DataFinal=new DateTime(2022,09,14)},
            new Disciplina{NomeDisciplina="Teoria do Desenvolvimento Humano e da Aprendizagem",DataInicial=new DateTime(2022,09,19), DataFinal=new DateTime(2022,10,24)},
            new Disciplina{NomeDisciplina="Planejamento Pedagógico",DataInicial=new DateTime(2022,08,27), DataFinal=new DateTime(2022,10,23)},
            new Disciplina{NomeDisciplina="Educação Inclusiva e Cidadania",DataInicial=new DateTime(2022,09,21), DataFinal=new DateTime(2022,11,09)},
            new Disciplina{NomeDisciplina="Gestão da Sala de Aula",DataInicial=new DateTime(2022,11,16), DataFinal=new DateTime(2022,12,30)},
            new Disciplina{NomeDisciplina="Met. Dinâmicas e Inovativas",DataInicial=new DateTime(2022,10,31), DataFinal=new DateTime(2022,11,14)},
            new Disciplina{NomeDisciplina="Projeto Integrador",DataInicial=new DateTime(2022,11,21), DataFinal=new DateTime(2022,12,05)},
            new Disciplina{NomeDisciplina="Avaliação por Competências",DataInicial=new DateTime(2023,01,01), DataFinal=new DateTime(2023,01,02)},
            new Disciplina{NomeDisciplina="Aprendizagem por Competências",DataInicial=new DateTime(2023,01,02), DataFinal=new DateTime(2023,01,03)},
            new Disciplina{NomeDisciplina="Prática Docente a Distância",DataInicial=new DateTime(2023,01,03), DataFinal=new DateTime(2023,01,04)},
            new Disciplina{NomeDisciplina="Legislação e Diretrizes da Educação Profissional e tecnológicas",DataInicial=new DateTime(2023,01,04), DataFinal=new DateTime(2023,01,05)},
            new Disciplina{NomeDisciplina="Ambiente de Aprendizagem Inovativos",DataInicial=new DateTime(2023,01,05), DataFinal=new DateTime(2023,01,06)},
        };

        static void Main(string[] args)
        {
            var dataOrdenada = from d in Disciplinas
                               orderby d.NomeDisciplina ascending
                               select d;

            foreach (var item in dataOrdenada)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }
}
