﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.VOs
{
    public class AgendaVO
    {
        private int id;
        private int id_venda;
        private List<ProdutoVO> serv_prod;
        private int id_cliente;
        private string nome_cliente;
        private string tel_cel;
        private int id_funcionario;
        private string nome_funcionario;
        private DateTime data;
        private DateTime hora;
        //private double valor_total;
        //private int qtd_total_itens;
        //private double desc_total;
        private string obs;
        private char status;

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
        public int Id_venda
        {
            get => id_venda; set
            {
                if (value <= 0)
                    throw new Exception("id_venda não pode ser menor ou igual a zero");
                else
                    id_venda = value;
            }
        }
        public int Id_cliente
        {
            get => id_cliente; set
            {
                if (value <= 0)
                    throw new Exception("id_cliente não pode ser menor ou igual a zero");
                else
                    id_cliente = value;
            }
        }
        public int Id_funcionario
        {
            get => id_funcionario; set
            {
                if (value <= 0)
                    throw new Exception("id_funcionario não pode ser menor ou igual a zero");
                else
                    id_funcionario = value;
            }
        }
        public DateTime Data
        {
            get => data;
            set
            {
                if (value == null)
                    throw new Exception("Data é obrigatório.");
                else
                    data = value;
            }
        }
        public DateTime Hora
        {
            get => hora;
            set
            {
                if (value == null)
                    throw new Exception("Hora é obrigatório.");
                else
                    hora = value;
            }
        }
        //public double Valor_total { get => valor_total; set => valor_total = value; }
        //public int Qtd_total_itens { get => qtd_total_itens; set => qtd_total_itens = value; }
        //public double Desc_total { get => desc_total; set => desc_total = value; }
        public string Obs { get => obs; set => obs = value; }
        //public string[] Serv_prod { get => serv_prod; set => serv_prod = value; }
        public List<ProdutoVO> Itens { get => serv_prod; set => serv_prod = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Tel_cel { get => tel_cel; set => tel_cel = value; }
        public string Nome_funcionario { get => nome_funcionario; set => nome_funcionario = value; }
        public char Status
        {
            get => status;
            set
            {
                if (value.ToString().ToUpper() == "P" || value.ToString().ToUpper() == "C" || value.ToString().ToUpper() == "N")
                    status = Convert.ToChar(value.ToString().ToUpper());
                else
                    throw new Exception("Status inválido para o agendamento");
            }
        }

        
    }
}
