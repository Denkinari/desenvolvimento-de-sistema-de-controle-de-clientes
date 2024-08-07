using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    public class Pessoa_juridica : Clientes
    {
        public string cnpj;
        public string ie;


        public override void Pagar_imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}