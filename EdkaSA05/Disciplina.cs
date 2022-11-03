using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA005
{
    public class Disciplina
    {
        public string NomeDisciplina { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        //polimofirsmo
        //override
        public override string ToString()=>$"{NomeDisciplina, -10}-----{DataInicial:dd/MM/yyyy}-----{DataFinal:dd/MM/yyyy}";
        
    }
}
