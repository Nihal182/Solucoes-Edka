using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.SA04
{
    public class Despesa
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public override string ToString() => $"{Descricao,-10}-------- {Valor,9} -{Vencimento:dd/MM/yyyy}";
    }
}
