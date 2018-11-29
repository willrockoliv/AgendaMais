using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.VOs
{
    class VendaVO
    {
        private int id;
        private double valor;
        private double custo;
        private double desconto;
        private DateTime data_hora;

        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new Exception("id não pode ser menor ou igual a zero");
                else
                    id = value;
            }
        }
        public double Valor { get => Math.Round(valor, 2); set => valor = Math.Round(value, 2); }
        public double Custo { get => Math.Round(custo, 2); set => custo = Math.Round(value, 2); }
        public double Desconto { get => Math.Round(desconto, 2); set => desconto = Math.Round(value, 2); }
        public DateTime Data_hora
        {
            get => data_hora;
            set
            {
                if (value == null)
                    throw new Exception("Data e hora é obrigatório.");
                else
                    data_hora = value;
            }
        }
    }
}
