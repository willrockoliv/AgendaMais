using AgendaMais.Classes.BD.VOs;
using AgendaMais.Classes.DAOs;
using AgendaMais.Telas.Relatorios;
using AgendaMais.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AgendaMais.Classes.BD.DAOs
{
    class NotificacoesDAO
    {
        #region BD
        static NotificacoesVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                NotificacoesVO notificacoesVO = new NotificacoesVO();
                notificacoesVO.Id = Convert.ToInt32(row["id"]);
                notificacoesVO.Descricao = row["descricao"].ToString();
                notificacoesVO.Chamar_tela = row["chamar_tela"].ToString();
                notificacoesVO.Visualizado = Convert.ToBoolean(row["visualizado"]);

                return notificacoesVO;
            }
            else
                return null;
        }

        static List<NotificacoesVO> MontaListVO(DataTable table_notificacoes)
        {
            if (table_notificacoes != null)
            {
                List<NotificacoesVO> listNotificacoesVO = new List<NotificacoesVO>();

                for (int i = 0; i < table_notificacoes.Rows.Count; i++)
                    listNotificacoesVO.Add(MontaVO(table_notificacoes.Rows[i]));

                return listNotificacoesVO;
            }
            else
                return null;
        }

        public static int ProximoId()
        {
            return DB.ProximoID("notificacoes");
        }

        public static List<NotificacoesVO> GetTodosRegistros()
        {
            string sql = "SELECT * FROM notificacoes order by id";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static void InserirRegistros(NotificacoesVO notificacoesVO)
        {
            string sql = "INSERT INTO notificacoes(" +
                            "id," +
                            "descricao," +
                            "chamar_tela," +
                            "visualizado) " +
                         "VALUES (" +
                           $"{notificacoesVO.Id}," +
                           $"'{notificacoesVO.Descricao}'," +
                           $"'{notificacoesVO.Chamar_tela}'," +
                           $"{notificacoesVO.Visualizado})";
            DB.ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(NotificacoesVO notificacoesVO)
        {
            string sql = "UPDATE notificacoes SET " +
                            $"descricao='{notificacoesVO.Descricao}', " +
                            $"chamar_tela='{notificacoesVO.Chamar_tela}', " +
                            $"visualizado={notificacoesVO.Visualizado} " +
                         "WHERE " +
                            $"id={notificacoesVO.Id}";
            DB.ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            string sql = String.Format($"Delete From notificacoes Where id={id}");
            DB.ExecutaSQL(sql);
        }
        #endregion

        #region Notificações
        public static void CarregarNotificacoes(FlowLayoutPanel flpNotificacoes, Panel panNotificacao)
        {
            RelatoriosDAO freqAgendamento = new RelatoriosDAO();
            freqAgendamento.relatorio_FrequenciaDeAgendamentos();

            int cont = 0;
            for (int i = 0; i < freqAgendamento.ListFreqAgendamentos.Count; i++)
            {
                if (freqAgendamento.ListFreqAgendamentos[i].status == 0)
                    cont++;
            }

            flpNotificacoes.Controls.Clear();

            if (cont == 0)
                flpNotificacoes.Controls.Add(ConstrutorNaoHaNotificacoes());
            else if (cont == 1)
            {
                flpNotificacoes.Controls.Add(ConstrutorNotificacao(0, "Passando pra avisar que você\r\ntem 1 cliente que precisa\r\nde atenção. Que tal conferir?", "frFrequenciaDeAgendamento"));
                panNotificacao.BackgroundImage = Resources.notificacao2;
            }
            else
            {
                flpNotificacoes.Controls.Add(ConstrutorNotificacao(0, $"Passando pra avisar que você\r\ntem {cont} clientes que precisam\r\nde atenção. Que tal conferir?", "frFrequenciaDeAgendamento"));
                panNotificacao.BackgroundImage = Resources.notificacao2;
            }
        }

        static Panel ConstrutorNotificacao(int id, string msg, string tag)
        {
            // 
            // panNotificacaoMsg
            // 
            Panel panNotificacaoMsg = new Panel();
            panNotificacaoMsg.BackColor = System.Drawing.Color.Transparent;
            panNotificacaoMsg.Cursor = Cursors.Hand;
            panNotificacaoMsg.Location = new System.Drawing.Point(3, 58);
            panNotificacaoMsg.Name = $"panNotificacaoMsg{id}";
            panNotificacaoMsg.Size = new System.Drawing.Size(289, 62);
            panNotificacaoMsg.Tag = tag;
            panNotificacaoMsg.Click += new EventHandler(panNotificacaoMsg_Click);
            // 
            // lblNotificacaoMsg
            // 
            Label lblNotificacaoMsg = new Label();
            lblNotificacaoMsg.Anchor = AnchorStyles.Top;
            lblNotificacaoMsg.BackColor = System.Drawing.Color.Transparent;
            lblNotificacaoMsg.Cursor = Cursors.Hand;
            lblNotificacaoMsg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNotificacaoMsg.ForeColor = System.Drawing.Color.White;
            lblNotificacaoMsg.Location = new System.Drawing.Point(3, 5);
            lblNotificacaoMsg.Name = $"lblNotificacaoMsg{id}";
            lblNotificacaoMsg.Size = new System.Drawing.Size(214, 51);
            lblNotificacaoMsg.Text = msg;
            lblNotificacaoMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblNotificacaoMsg.Tag = tag;
            lblNotificacaoMsg.Click += new EventHandler(panNotificacaoMsg_Click);
            // 
            // lblFecharNotificacaoMsg
            // 
            Label lblFecharNotificacaoMsg = new Label();
            lblFecharNotificacaoMsg.Anchor = AnchorStyles.Top;
            lblFecharNotificacaoMsg.BackColor = System.Drawing.Color.Transparent;
            lblFecharNotificacaoMsg.Cursor = Cursors.Hand;
            lblFecharNotificacaoMsg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFecharNotificacaoMsg.ForeColor = System.Drawing.Color.White;
            lblFecharNotificacaoMsg.Location = new System.Drawing.Point(271, 5);
            lblFecharNotificacaoMsg.Name = $"lblFecharNotificacaoMsg{id}";
            lblFecharNotificacaoMsg.Size = new System.Drawing.Size(15, 17);
            lblFecharNotificacaoMsg.Text = "X";
            lblFecharNotificacaoMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblFecharNotificacaoMsg.Click += new EventHandler(lblFecharNotificacaoMsg_Click);

            panNotificacaoMsg.Controls.Add(lblFecharNotificacaoMsg);
            panNotificacaoMsg.Controls.Add(lblNotificacaoMsg);
            return panNotificacaoMsg;
        }

        public static Panel ConstrutorNaoHaNotificacoes()
        {
            // 
            // lblNaoHaNotificacoes
            // 
            Label lblNaoHaNotificacoes = new Label();
            lblNaoHaNotificacoes.Anchor = AnchorStyles.Top;
            lblNaoHaNotificacoes.AutoSize = true;
            lblNaoHaNotificacoes.BackColor = System.Drawing.Color.Transparent;
            lblNaoHaNotificacoes.Cursor = Cursors.Default;
            lblNaoHaNotificacoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNaoHaNotificacoes.ForeColor = System.Drawing.Color.White;
            lblNaoHaNotificacoes.Location = new System.Drawing.Point(62, 5);
            lblNaoHaNotificacoes.Name = "lblNaoHaNotificacoes";
            lblNaoHaNotificacoes.Size = new System.Drawing.Size(162, 40);
            lblNaoHaNotificacoes.Text = "Não há notificações \r\nno momento.";
            lblNaoHaNotificacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panNaoHaNotificacoes
            // 
            Panel panNaoHaNotificacoes = new Panel();
            panNaoHaNotificacoes.BackColor = System.Drawing.Color.Transparent;
            panNaoHaNotificacoes.Cursor = Cursors.Default;
            panNaoHaNotificacoes.Location = new System.Drawing.Point(3, 3);
            panNaoHaNotificacoes.Name = "panNaoHaNotificacoes";
            panNaoHaNotificacoes.Size = new System.Drawing.Size(289, 49);
            panNaoHaNotificacoes.TabIndex = 14;

            panNaoHaNotificacoes.Controls.Add(lblNaoHaNotificacoes);
            return panNaoHaNotificacoes;
        }
        #endregion

        #region Eventos
        public static void RemoveNotificacao(FlowLayoutPanel flpMenuNotificacao, int index)
        {
            flpMenuNotificacao.Controls.RemoveAt(index);
            if (flpMenuNotificacao.Controls.Count == 0)
                flpMenuNotificacao.Controls.Add(ConstrutorNaoHaNotificacoes());
        }

        public static void lblFecharNotificacaoMsg_Click(object sender, EventArgs e)
        {
            Label lblFecharNotificacao = (Label)sender;
            FlowLayoutPanel flpMenuNotificacao = (FlowLayoutPanel)lblFecharNotificacao.FindForm().Controls.Find("flpMenuNotificacao", false)[0];
            int index = Convert.ToInt32(lblFecharNotificacao.Name.Replace("lblFecharNotificacaoMsg",""));
            RemoveNotificacao(flpMenuNotificacao, index);
        }

        public static void panNotificacaoMsg_Click(object sender, EventArgs e)
        {
            if(sender is Label)
            {
                Label lblNotificacaoMsg = (Label)sender;
                if(lblNotificacaoMsg.Tag.ToString() == "frFrequenciaDeAgendamento")
                {
                    frFrequenciaDeAgendamento frFrequenciaDeAgendamento = new frFrequenciaDeAgendamento();
                    frFrequenciaDeAgendamento.Show();

                    FlowLayoutPanel flpMenuNotificacao = (FlowLayoutPanel)lblNotificacaoMsg.FindForm().Controls.Find("flpMenuNotificacao", false)[0];
                    int index = Convert.ToInt32(lblNotificacaoMsg.Name.Replace("lblNotificacaoMsg", ""));
                    RemoveNotificacao(flpMenuNotificacao, index);
                }
            }
            else if (sender is Panel)
            {
                Panel panNotificacaoMsg = (Panel)sender;
                if (panNotificacaoMsg.Tag.ToString() == "frFrequenciaDeAgendamento")
                {
                    frFrequenciaDeAgendamento frFrequenciaDeAgendamento = new frFrequenciaDeAgendamento();
                    frFrequenciaDeAgendamento.Show();

                    FlowLayoutPanel flpMenuNotificacao = (FlowLayoutPanel)panNotificacaoMsg.FindForm().Controls.Find("flpMenuNotificacao", false)[0];
                    int index = Convert.ToInt32(panNotificacaoMsg.Name.Replace("panNotificacaoMsg", ""));
                    RemoveNotificacao(flpMenuNotificacao, index);
                }
            }
        }
        #endregion
    }
}
