using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.BD.VOs
{
    class ContaVO
    {
        public enum EnumTipoConta { a_receber, a_pagar };

        private int id;
        private string descricao;
        private EnumTipoConta tipoConta;
        private bool ativo = true;

        public int Id
        {
            get => id; set
            {
                if (value <= 0)
                    throw new Exception("id não pode ser menor ou igual a zero");
                else
                    id = value;
            }
        }

        public string Descricao { get => descricao; set => descricao = value; }

        public EnumTipoConta TipoConta { get => tipoConta; set => tipoConta = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}

