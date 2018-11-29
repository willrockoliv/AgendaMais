using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.VOs
{
    class GrupoProdutoVO
    {
        private int id;
        private string descricao;

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
    }
}
