using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBank
{
    public class ContaModelo
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string agencia { get; set; }
        public string numero { get; set; }
        public decimal saldo { get; set; }
        public string tipo { get; set; }

        public virtual void saque(decimal valor)
        {
            saldo -= valor;
        }
    }
}
