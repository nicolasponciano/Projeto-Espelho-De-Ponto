using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_03___PROJETO_01
{
    internal class Funcionario
    {
        public string Nome { get; set; }

        public string QtdHoras { get; set; }

        public string HoraTrabalhada { get; set; }

        public string getSalario()
        {
            return (float.Parse(QtdHoras) * float.Parse(HoraTrabalhada)).ToString();
        }
    }

}
