﻿using AgendaMais.Classes.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.VOs
{
    class ItemAgendaVO
    {
        private int id_produto;
        private int id_agenda;
        private int quantidade;
        private double desconto;

        public int Id_produto
        {
            get => id_produto;
            set
            {
                if (ProdutoDAO.GetRegistroPorId(value) == null)
                    throw new Exception("Produto com id " + value + " não encontrado na tabela produto");
                else
                    id_produto = value;
            }
        }
        public int Id_agenda
        {
            get => id_agenda;
            set
            {
                if(value > 0)//if (VendaDAO.GetRegistroPorId(value).Rows.Count != 0)
                    id_agenda = value;
                else
                    throw new Exception("Agenda com id " + value + " não encontrado na tabela agenda");
            }
        }
        public int Quantidade
        {
            get => quantidade;
            set
            {
                if (value < 0)
                    throw new Exception("Quantidade não pode ser um valor negativa");
                else
                    quantidade = value;
            }
        }
        public double Desconto
        {
            get => Math.Round(desconto, 2);
            set
            {
                if (value < 0)
                    throw new Exception("Desconto não pode ser um valor negativo");
                else
                    desconto = Math.Round(value, 2);
            }
        }
    }
}