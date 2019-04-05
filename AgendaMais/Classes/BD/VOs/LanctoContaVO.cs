using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.BD.VOs
{
    class LanctoContaVO
    {
        private int id;
        private int id_conta;
        private string id_pessoa;
        private DateTime data;
        private double valor;
        private bool fixa = false;
        private bool repetir = false;
        private int qtd_repeticoes;
        private bool pago = false;

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
        public int Id_conta
        {
            get => id_conta;
            set
            {
                if (value <= 0)
                    throw new Exception("id_conta não pode ser menor ou igual a zero");
                else
                    id_conta = value;
            }
        }

        public string Id_pessoa { get => id_pessoa; set => id_pessoa = value; }

        public DateTime Data { get => data; set => data = value; }

        public double Valor
        {
            get => Math.Round(valor, 2);
            set
            {
                if (value < 0)
                    throw new Exception("valor não pode ser negativo");
                else
                    valor = Math.Round(value, 2);
            }
        }

        public bool Fixa { get => fixa; set => fixa = value; }
        public bool Repetir { get => repetir; set => repetir = value; }
        public int Qtd_repeticoes
        {
            get => qtd_repeticoes;
            set
            {
                if (value <= 0)
                    throw new Exception("qtd_repeticoes não pode ser menor ou igual a zero");
                else
                    qtd_repeticoes = value;

            }
        }
        public bool Pago { get => pago; set => pago = value; }
    }
}
