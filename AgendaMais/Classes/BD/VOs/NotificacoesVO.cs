using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.BD.VOs
{
    class NotificacoesVO
    {
        private int id;
        private string descricao;
        private string chamar_tela;
        private bool visualizado;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Chamar_tela { get => chamar_tela; set => chamar_tela = value; }
        public bool Visualizado { get => visualizado; set => visualizado = value; }
    }
}
