using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;
using AgendaMais.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static AgendaMais.Classes.VOs.AgendaVO;

namespace AgendaMais.Classes
{
    public class MetodosAgenda
    {
        #region Variáveis Globais
        public AgendaVO agendaVO = new AgendaVO();
        public List<Panel> listPanAgendamentos = new List<Panel>();
        public List<AgendaVO> listAgenda = new List<AgendaVO>();
        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Este método constrói um Panel de agendamento com as informações passadas por parâmetro
        /// </summary>
        /// <param name="hora"></param>
        /// <param name="atendente"></param>
        /// <param name="cliente"></param>
        /// <param name="tel_cel"></param>
        /// <param name="serv_prod"></param>
        /// <param name="posicao"></param>
        /// <returns></returns>
        Panel ConstrutorAgendamentos(string hora, string atendente, string cliente, string tel_cel, List<ProdutoVO> Serv_prod, bool notificar, int posicao)
        {
            #region panAgendamento
            Panel panAgendamento = new Panel();
            panAgendamento.Name = posicao.ToString();
            panAgendamento.Anchor = AnchorStyles.Top;
            panAgendamento.BackColor = Color.White;
            panAgendamento.Size = new Size(1218, 40);
            panAgendamento.Cursor = Cursors.Hand;
            panAgendamento.DoubleClick += new EventHandler(Agendamento_DoubleClick);
            panAgendamento.MouseHover += new EventHandler(panAgendamento_MouseHover);
            panAgendamento.MouseLeave += new EventHandler(panAgendamento_MouseLeave);
            #endregion

            #region txtHorario
            TextBox txtHorario = new TextBox();
            txtHorario.Name = "txtHorario" + posicao;
            txtHorario.BackColor = System.Drawing.Color.White;
            txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtHorario.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular);
            txtHorario.ForeColor = System.Drawing.Color.Black;
            txtHorario.Location = new System.Drawing.Point(31, 8);
            txtHorario.ReadOnly = true;
            txtHorario.Size = new System.Drawing.Size(92, 23);
            txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtHorario.Enabled = false;
            txtHorario.Text = hora;
            #endregion

            #region txtAtendente
            TextBox txtAtendente = new TextBox();
            txtAtendente.Name = "txtAtentende" + posicao;
            txtAtendente.BackColor = Color.White;
            txtAtendente.BorderStyle = BorderStyle.None;
            txtAtendente.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            txtAtendente.ForeColor = Color.Black;
            txtAtendente.Location = new Point(129, 8);
            txtAtendente.ReadOnly = true;
            txtAtendente.Size = new Size(275, 23);
            txtAtendente.TextAlign = HorizontalAlignment.Center;
            txtAtendente.Enabled = false;
            if (atendente != "")
                txtAtendente.Text = atendente;
            else
                txtAtendente.Text = "Não informado";
            #endregion

            #region txtCliente
            TextBox txtCliente = new TextBox();
            txtCliente.Name = "txtCliente" + posicao;
            txtCliente.BackColor = System.Drawing.Color.White;
            txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCliente.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular);
            txtCliente.ForeColor = System.Drawing.Color.Black;
            txtCliente.Location = new System.Drawing.Point(410, 8);
            txtCliente.ReadOnly = true;
            txtCliente.Size = new System.Drawing.Size(212, 23);
            txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtCliente.Enabled = false;
            txtCliente.Text = cliente;
            #endregion

            #region txtTelCel
            TextBox txtTelCel = new TextBox();
            txtTelCel.Name = "txtTelCel" + posicao;
            txtTelCel.BackColor = System.Drawing.Color.White;
            txtTelCel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtTelCel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular);
            txtTelCel.ForeColor = System.Drawing.Color.Black;
            txtTelCel.Location = new System.Drawing.Point(628, 8);
            txtTelCel.ReadOnly = true;
            txtTelCel.Size = new System.Drawing.Size(165, 23);
            txtTelCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtTelCel.Enabled = false;
            txtTelCel.Text = tel_cel;
            #endregion

            #region cbSerProd
            ComboBox cbServProd = new ComboBox();
            cbServProd.Name = "cbServProd" + posicao;
            cbServProd.Anchor = AnchorStyles.Top;
            cbServProd.BackColor = Color.White;
            cbServProd.Cursor = Cursors.Hand;
            cbServProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServProd.FlatStyle = FlatStyle.Flat;
            cbServProd.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, (0));
            cbServProd.FormattingEnabled = true;
            foreach (ProdutoVO x in Serv_prod)
                cbServProd.Items.Add(x.Descricao);
            if (cbServProd.Items.Count != 0)
                cbServProd.SelectedIndex = 0;
            cbServProd.Location = new Point(813, 5);
            cbServProd.Size = new Size(243, 30);
            #endregion

            #region ckbNotificar
            CheckBox ckbNotificar = new CheckBox();
            ckbNotificar.Anchor = AnchorStyles.Top;
            ckbNotificar.Appearance = Appearance.Button;
            ckbNotificar.BackColor = Color.White;
            ckbNotificar.Checked = notificar;
            ckbNotificar.Cursor = Cursors.Hand;
            ckbNotificar.FlatAppearance.BorderColor = Color.White;
            ckbNotificar.FlatAppearance.BorderSize = 0;
            ckbNotificar.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            ckbNotificar.FlatStyle = FlatStyle.Flat;
            ckbNotificar.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbNotificar.ForeColor = Color.Black;
            ckbNotificar.Location = new Point(1061, 7);
            ckbNotificar.Name = "ckbNotificar" + posicao;
            ckbNotificar.Size = new Size(75, 26);
            ckbNotificar.Text = "NOTIFICAR";
            ckbNotificar.TextAlign = ContentAlignment.MiddleCenter;
            ckbNotificar.CheckedChanged += new EventHandler(ckbNotificar_CheckedChanged);
            #endregion

            #region ptbConfirmar
            PictureBox ptbConfirmar = new PictureBox();
            ptbConfirmar.Name = "ptbConfirmar" + posicao;
            ptbConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ptbConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            ptbConfirmar.BackgroundImage = global::AgendaMais.Properties.Resources.checked__2_;
            ptbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ptbConfirmar.Location = new System.Drawing.Point(1142, 3);
            ptbConfirmar.Size = new System.Drawing.Size(34, 34);
            ptbConfirmar.MouseLeave += new System.EventHandler(ptbConfirmar_MouseLeave);
            ptbConfirmar.MouseHover += new System.EventHandler(ptbConfirmar_MouseHover);
            ptbConfirmar.Click += new EventHandler(ptbConfirmar_Click);
            #endregion

            #region ptbCancelar
            PictureBox ptbCancelar = new PictureBox();
            ptbCancelar.Name = "ptbCancelar" + posicao;
            ptbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ptbCancelar.BackColor = System.Drawing.Color.IndianRed;
            ptbCancelar.BackgroundImage = global::AgendaMais.Properties.Resources.excluir;
            ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ptbCancelar.Location = new System.Drawing.Point(1180, 3);
            ptbCancelar.Size = new System.Drawing.Size(34, 34);
            ptbCancelar.MouseLeave += new System.EventHandler(ptbCancelar_MouseLeave);
            ptbCancelar.MouseHover += new System.EventHandler(ptbCancelar_MouseHover);
            ptbCancelar.Click += new EventHandler(ptbCancelar_Click);
            #endregion

            #region Add controls ao panAgendamento
            panAgendamento.Controls.Add(txtHorario);
            panAgendamento.Controls.Add(txtAtendente);
            panAgendamento.Controls.Add(txtCliente);
            panAgendamento.Controls.Add(txtTelCel);
            panAgendamento.Controls.Add(cbServProd);
            panAgendamento.Controls.Add(ckbNotificar);
            panAgendamento.Controls.Add(ptbConfirmar);
            panAgendamento.Controls.Add(ptbCancelar);
            #endregion

            return panAgendamento;
        }

        /// <summary>
        /// Este método é uma sobrecarga do método acima, diferenciando pela data do agendamento e status do agendamento
        /// </summary>
        /// <param name="p_Enum_TipoExibicaoAgenda"></param>
        /// <param name="p_enumStatusAgendamento"></param>
        /// <param name="data"></param>
        /// <param name="hora"></param>
        /// <param name="atendente"></param>
        /// <param name="cliente"></param>
        /// <param name="tel_cel"></param>
        /// <param name="serv_prod"></param>
        /// <param name="posicao"></param>
        /// <returns></returns>
        Panel ConstrutorAgendamentos(Enum_TipoExibicaoAgenda p_Enum_TipoExibicaoAgenda, EnumStatusAgendamento p_enumStatusAgendamento, string data, string hora, string atendente, string cliente, string tel_cel, List<ProdutoVO> Serv_prod, bool notificar, int posicao)
        {
            #region panAgendamento
            Panel panAgendamento = new Panel();
            panAgendamento.Name = posicao.ToString();
            panAgendamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panAgendamento.BackColor = System.Drawing.Color.White;
            panAgendamento.Size = new System.Drawing.Size(1218, 40);
            panAgendamento.Cursor = Cursors.Hand;
            panAgendamento.DoubleClick += new EventHandler(Agendamento_DoubleClick);
            panAgendamento.MouseHover += new EventHandler(panAgendamento_MouseHover);
            panAgendamento.MouseLeave += new EventHandler(panAgendamento_MouseLeave);
            #endregion

            #region ptbStatus
            PictureBox ptbStatus = new PictureBox();
            ptbStatus.Name = "ptbStatus" + posicao;
            ptbStatus.Anchor = AnchorStyles.Top;
            if (EnumStatusAgendamento.confirmado == p_enumStatusAgendamento)
                ptbStatus.BackgroundImage = Properties.Resources.status_confirmado;
            else if (EnumStatusAgendamento.cancelado == p_enumStatusAgendamento)
                ptbStatus.BackgroundImage = Properties.Resources.status_cancelado;
            else if (EnumStatusAgendamento.pendente == p_enumStatusAgendamento)
                ptbStatus.BackgroundImage = Properties.Resources.status_pendente;
            ptbStatus.BackgroundImageLayout = ImageLayout.Zoom;
            ptbStatus.Location = new Point(38, 3);
            ptbStatus.Size = new Size(34, 34);
            #endregion

            #region txtHorario
            TextBox txtHorario = new TextBox();
            txtHorario.Name = "txtHorario" + posicao;
            txtHorario.BackColor = Color.White;
            txtHorario.BorderStyle = BorderStyle.None;
            txtHorario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, (0));
            txtHorario.ForeColor = Color.Black;
            txtHorario.Location = new Point(100, 8);
            txtHorario.ReadOnly = true;
            txtHorario.Size = new Size(128, 20);
            txtHorario.TextAlign = HorizontalAlignment.Center;
            txtHorario.Enabled = false;
            if (p_Enum_TipoExibicaoAgenda == Enum_TipoExibicaoAgenda.mes)
                txtHorario.Text = data + " " + hora;
            else if (p_Enum_TipoExibicaoAgenda == Enum_TipoExibicaoAgenda.semana)
                txtHorario.Text = hora;
            #endregion

            #region txtAtendente
            TextBox txtAtendente = new TextBox();
            txtAtendente.Name = "txtAtentende" + posicao;
            txtAtendente.BackColor = Color.White;
            txtAtendente.BorderStyle = BorderStyle.None;
            txtAtendente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, (0));
            txtAtendente.ForeColor = Color.Black;
            txtAtendente.Location = new Point(234, 8);
            txtAtendente.ReadOnly = true;
            txtAtendente.Size = new Size(200, 20);
            txtAtendente.TextAlign = HorizontalAlignment.Center;
            txtAtendente.Enabled = false;
            if (atendente != "")
                txtAtendente.Text = atendente;
            else
                txtAtendente.Text = "Não informado";
            #endregion

            #region txtCliente
            TextBox txtCliente = new TextBox();
            txtCliente.Name = "txtCliente" + posicao;
            txtCliente.BackColor = Color.White;
            txtCliente.BorderStyle = BorderStyle.None;
            txtCliente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, (0));
            txtCliente.ForeColor = Color.Black;
            txtCliente.Location = new Point(440, 8);
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(205, 20);
            txtCliente.TextAlign = HorizontalAlignment.Center;
            txtCliente.Enabled = false;
            txtCliente.Text = cliente;
            #endregion

            #region txtTelCel
            TextBox txtTelCel = new TextBox();
            txtTelCel.Name = "txtTelCel" + posicao;
            txtTelCel.BackColor = Color.White;
            txtTelCel.BorderStyle = BorderStyle.None;
            txtTelCel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, (0));
            txtTelCel.ForeColor = Color.Black;
            txtTelCel.Location = new Point(651, 8);
            txtTelCel.ReadOnly = true;
            txtTelCel.Size = new Size(167, 24);
            txtTelCel.TextAlign = HorizontalAlignment.Center;
            txtTelCel.Enabled = false;
            txtTelCel.Text = tel_cel;
            #endregion

            #region cbSerProd
            ComboBox cbServProd = new ComboBox();
            cbServProd.Name = "cbServProd" + posicao;
            cbServProd.Anchor = AnchorStyles.Top;
            cbServProd.BackColor = Color.White;
            cbServProd.Cursor = Cursors.Hand;
            cbServProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServProd.FlatStyle = FlatStyle.Flat;
            cbServProd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, (0));
            cbServProd.FormattingEnabled = true;
            foreach (ProdutoVO x in Serv_prod)
                cbServProd.Items.Add(x.Descricao);
            if (cbServProd.Items.Count != 0)
                cbServProd.SelectedIndex = 0;
            cbServProd.Location = new Point(824, 5);
            cbServProd.Size = new Size(231, 29);
            #endregion

            #region ckbNotificar
            CheckBox ckbNotificar = new CheckBox();
            ckbNotificar.Anchor = AnchorStyles.Top;
            ckbNotificar.Appearance = Appearance.Button;
            ckbNotificar.AutoSize = true;
            ckbNotificar.BackColor = Color.White;
            ckbNotificar.Checked = notificar;
            ckbNotificar.Cursor = Cursors.Hand;
            ckbNotificar.FlatAppearance.BorderColor = Color.White;
            ckbNotificar.FlatAppearance.BorderSize = 0;
            ckbNotificar.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            ckbNotificar.FlatStyle = FlatStyle.Flat;
            ckbNotificar.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbNotificar.ForeColor = Color.Black;
            ckbNotificar.Location = new Point(1061, 7);
            ckbNotificar.Name = "ckbNotificar" + posicao;
            ckbNotificar.Size = new Size(75, 26);
            ckbNotificar.Text = "NOTIFICAR";
            ckbNotificar.TextAlign = ContentAlignment.MiddleCenter;
            ckbNotificar.CheckedChanged += new EventHandler(ckbNotificar_CheckedChanged);
            #endregion

            #region ptbConfirmar
            PictureBox ptbConfirmar = new PictureBox();
            ptbConfirmar.Name = "ptbConfirmar" + posicao;
            ptbConfirmar.Anchor = AnchorStyles.Top;
            ptbConfirmar.BackColor = Color.DarkSeaGreen;
            ptbConfirmar.BackgroundImage = Properties.Resources.checked__2_;
            ptbConfirmar.BackgroundImageLayout = ImageLayout.Zoom;
            ptbConfirmar.Location = new Point(1142, 3);
            ptbConfirmar.Size = new Size(34, 34);
            ptbConfirmar.MouseLeave += new EventHandler(ptbConfirmar_MouseLeave);
            ptbConfirmar.MouseHover += new EventHandler(ptbConfirmar_MouseHover);
            ptbConfirmar.Click += new EventHandler(ptbConfirmar_Click);
            #endregion

            #region ptbCancelar
            PictureBox ptbCancelar = new PictureBox();
            ptbCancelar.Name = "ptbCancelar" + posicao;
            ptbCancelar.Anchor = AnchorStyles.Top;
            ptbCancelar.BackColor = Color.IndianRed;
            ptbCancelar.BackgroundImage = Properties.Resources.excluir;
            ptbCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            ptbCancelar.Location = new Point(1180, 3);
            ptbCancelar.Size = new Size(34, 34);
            ptbCancelar.MouseLeave += new EventHandler(ptbCancelar_MouseLeave);
            ptbCancelar.MouseHover += new EventHandler(ptbCancelar_MouseHover);
            ptbCancelar.Click += new EventHandler(ptbCancelar_Click);
            #endregion

            #region Add controls ao panAgendamento
            panAgendamento.Controls.Add(ptbStatus);
            panAgendamento.Controls.Add(txtHorario);
            panAgendamento.Controls.Add(txtAtendente);
            panAgendamento.Controls.Add(txtCliente);
            panAgendamento.Controls.Add(txtTelCel);
            panAgendamento.Controls.Add(cbServProd);
            if (Convert.ToDateTime(data) <= DateTime.Now)
            {
                panAgendamento.Controls.Add(ptbConfirmar);
                panAgendamento.Controls.Add(ckbNotificar);
            }
            panAgendamento.Controls.Add(ptbCancelar);
            #endregion

            return panAgendamento;
        }

        public void Atualiza_listAgenda(DateTime data_ini, DateTime data_fim, char status1, char status2, char status3)
        {
            //listPanAgendamentos.Clear();
            listAgenda = new List<AgendaVO>();

            // select agendamentos
            listAgenda = AgendaDAO.GetRegistros(String.Format("where a.data_hora between '{0}' and '{1}' and " +
                                                              "(a.status='{2}' or a.status='{3}' or a.status='{4}') " +
                                                              "order by a.data_hora",
                                                              data_ini.ToString(), data_fim.ToString(), status1, status2, status3));
        }

        public void ExibeAgendamentos(FlowLayoutPanel flpAgendamentos, Enum_TipoExibicaoAgenda p_Enum_TipoExibicaoAgenda)
        {
            flpAgendamentos.Visible = false;
            flpAgendamentos.Controls.Clear();
            listPanAgendamentos.Clear();
            if (listAgenda != null)
            {
                for (int i = 0; i < listAgenda.Count; i++)
                {
                    if (p_Enum_TipoExibicaoAgenda == Enum_TipoExibicaoAgenda.hoje)
                        listPanAgendamentos.Add(ConstrutorAgendamentos(listAgenda[i].Data_hora.ToString("HH:mm"),
                                                                       listAgenda[i].Nome_funcionario,
                                                                       listAgenda[i].Nome_cliente,
                                                                       listAgenda[i].Tel_cel,
                                                                       listAgenda[i].Itens,
                                                                       listAgenda[i].Notificar,
                                                                       i));
                    else if (p_Enum_TipoExibicaoAgenda == Enum_TipoExibicaoAgenda.semana)
                        listPanAgendamentos.Add(ConstrutorAgendamentos(Enum_TipoExibicaoAgenda.semana,
                                                                       (EnumStatusAgendamento)(listAgenda[i].Status),
                                                                       listAgenda[i].Data_hora.ToString("dd/MM/yyyy"),
                                                                       listAgenda[i].Data_hora.ToString("HH:mm"),
                                                                       listAgenda[i].Nome_funcionario,
                                                                       listAgenda[i].Nome_cliente,
                                                                       listAgenda[i].Tel_cel,
                                                                       listAgenda[i].Itens,
                                                                       listAgenda[i].Notificar,
                                                                       i));
                    else if (p_Enum_TipoExibicaoAgenda == Enum_TipoExibicaoAgenda.mes)
                        listPanAgendamentos.Add(ConstrutorAgendamentos(Enum_TipoExibicaoAgenda.mes,
                                                                       (EnumStatusAgendamento)(listAgenda[i].Status),
                                                                       listAgenda[i].Data_hora.ToString("dd/MM/yyyy"),
                                                                       listAgenda[i].Data_hora.ToString("HH:mm"),
                                                                       listAgenda[i].Nome_funcionario,
                                                                       listAgenda[i].Nome_cliente,
                                                                       listAgenda[i].Tel_cel,
                                                                       listAgenda[i].Itens,
                                                                       listAgenda[i].Notificar,
                                                                       i));
                    flpAgendamentos.Controls.Add(listPanAgendamentos[i]);
                }
            }
            flpAgendamentos.Visible = true;
        }

        public void AtualizaStatus(FlowLayoutPanel flpAgendamentos)
        {
            Panel panAgendamento = new Panel();
            TextBox txtHora;

            for (int i = 0; i < flpAgendamentos.Controls.Count; i++)
            {
                panAgendamento = (Panel)flpAgendamentos.Controls[i];
                for (int j = 0; j < panAgendamento.Controls.Count; j++)
                {
                    if (panAgendamento.Controls[j] is TextBox)
                    {
                        txtHora = (TextBox)panAgendamento.Controls[j];
                        if (txtHora.Name.Contains("txtHora"))
                        {
                            if (((Convert.ToDateTime(txtHora.Text)) - (DateTime.Now)).TotalMinutes < 30 && ((Convert.ToDateTime(txtHora.Text)) - (DateTime.Now)).TotalMinutes > 0)
                                AlteraCorPanAgendamentos(panAgendamento, Color.FromArgb(252, 255, 196));
                            else if (Convert.ToDateTime(txtHora.Text) < DateTime.Now)
                                AlteraCorPanAgendamentos(panAgendamento, Color.FromArgb(255, 164, 153));
                            break;
                        }
                    }
                }
            }
        }

        static void AlteraCorPanAgendamentos(Panel panAgendamento, Color cor)
        {
            panAgendamento.BackColor = cor;

            foreach (object obj in panAgendamento.Controls)
            {
                if (obj is TextBox)
                {
                    TextBox txtBox = (TextBox)obj;
                    txtBox.BackColor = cor;
                }
                else if (obj is ComboBox)
                {
                    ComboBox cbServProd = (ComboBox)obj;
                    cbServProd.BackColor = cor;
                }
            }
        }

        #endregion

        #region Eventos Agendamentos

        #region Panel Agendamento
        private void Agendamento_DoubleClick(object sender, EventArgs e)
        {
            Panel panAgendamento = (Panel)sender;
            int posicao = Convert.ToInt32(panAgendamento.Name);

            frAgendamento frAgendamento = new frAgendamento(listAgenda[posicao]);
            frAgendamento.ShowDialog();

            if (frAgendamento.alteracao)
            {
                FlowLayoutPanel flpAgendamentos = (FlowLayoutPanel)(panAgendamento.FindForm().Controls.Find("flpAgendamentos", false)[0]);
                AtualizaStatus(flpAgendamentos);
                if (panAgendamento.FindForm().Name == "frPrincipal")
                {
                    Atualiza_listAgenda(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00"),
                                        Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59"),
                                        'P', 'P', 'P');
                    ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.hoje);
                }
                else if (panAgendamento.FindForm().Name == "frAgendados")
                    if ((panAgendamento.FindForm().Controls.Find("panSemana", false)) != null)
                    {
                        frAgendados frAgendados = panAgendamento.FindForm() as frAgendados;
                        frAgendados.AtualizaTodasAgendas();
                        ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
                    }
            }
        }

        public void panAgendamento_MouseHover(object sender, EventArgs e)
        {
            Panel panAgendamento = new Panel();
            panAgendamento = (Panel)sender;

            panAgendamento.BorderStyle = BorderStyle.Fixed3D;
        }

        public void panAgendamento_MouseLeave(object sender, EventArgs e)
        {
            Panel panAgendamento = new Panel();
            panAgendamento = (Panel)sender;

            panAgendamento.BorderStyle = BorderStyle.None;
        }
        #endregion

        #region Confirmar
        private static void ptbConfirmar_MouseHover(object sender, EventArgs e)
        {
            PictureBox ptbConfirmar = (PictureBox)sender;
            ptbConfirmar.BackColor = Color.LightGreen;
        }

        private static void ptbConfirmar_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ptbConfirmar = (PictureBox)sender;
            ptbConfirmar.BackColor = Color.DarkSeaGreen;
        }

        private void ptbConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Este agendamento foi confirmado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PictureBox ptbConfirmar = new PictureBox();
                ptbConfirmar = (PictureBox)sender;
                int posicao = Convert.ToInt32(ptbConfirmar.Name.Replace("ptbConfirmar", ""));
                agendaVO = new AgendaVO();
                agendaVO = listAgenda[posicao];
                agendaVO.Status = 'C';
                AgendaDAO.AtualizarRegistro(agendaVO);
                FlowLayoutPanel flpAgendamentos = (FlowLayoutPanel)(ptbConfirmar.FindForm().Controls.Find("flpAgendamentos", false)[0]);
                if (ptbConfirmar.FindForm().Name == "frPrincipal")
                {
                    listAgenda.Remove(agendaVO);
                    ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.hoje);
                    AtualizaStatus(flpAgendamentos);
                }
                else if (ptbConfirmar.FindForm().Name == "frAgendados")
                    if ((ptbConfirmar.FindForm().Controls.Find("panSemana", false)) != null)
                        ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
                    else if ((ptbConfirmar.FindForm().Controls.Find("panSemana", false)) != null)
                        ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
            }
            else
                return;
        }
        #endregion

        #region Cancelar
        private static void ptbCancelar_MouseHover(object sender, EventArgs e)
        {
            PictureBox ptbCancelar = (PictureBox)sender;
            ptbCancelar.BackColor = Color.LightCoral;
        }

        private static void ptbCancelar_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ptbCancelar = (PictureBox)sender;
            ptbCancelar.BackColor = Color.IndianRed;
        }

        private void ptbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Este agendamento foi cancelado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PictureBox ptbCancelar = new PictureBox();
                ptbCancelar = (PictureBox)sender;
                int posicao = Convert.ToInt32(ptbCancelar.Name.Replace("ptbCancelar", ""));
                agendaVO = new AgendaVO();
                agendaVO = listAgenda[posicao];
                agendaVO.Status = 'N';
                AgendaDAO.AtualizarRegistro(agendaVO);
                FlowLayoutPanel flpAgendamentos = (FlowLayoutPanel)(ptbCancelar.FindForm().Controls.Find("flpAgendamentos", false)[0]);
                if (ptbCancelar.FindForm().Name == "frPrincipal")
                {
                    listAgenda.Remove(agendaVO);
                    AtualizaStatus(flpAgendamentos);
                    ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.hoje);
                }
                else if (ptbCancelar.FindForm().Name == "frAgendados")
                    if ((ptbCancelar.FindForm().Controls.Find("panSemana", false)) != null)
                        ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
                    else if ((ptbCancelar.FindForm().Controls.Find("panSemana", false)) != null)
                        ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
            }
            else
                return;
        }
        #endregion

        #region Notificar
        private void ckbNotificar_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ckbNotificar = new CheckBox();
            ckbNotificar = (CheckBox)sender;
            int posicao = Convert.ToInt32(ckbNotificar.Name.Replace("ckbNotificar", ""));
            agendaVO = new AgendaVO();
            agendaVO = listAgenda[posicao];
            agendaVO.Notificar = ckbNotificar.Checked;
            AgendaDAO.AtualizarRegistro(agendaVO);
            FlowLayoutPanel flpAgendamentos = (FlowLayoutPanel)(ckbNotificar.FindForm().Controls.Find("flpAgendamentos", false)[0]);
            if (ckbNotificar.FindForm().Name == "frPrincipal")
            {
                AtualizaStatus(flpAgendamentos);
                ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.hoje);
            }
            else if (ckbNotificar.FindForm().Name == "frAgendados")
                if ((ckbNotificar.FindForm().Controls.Find("panSemana", false)) != null)
                    ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
                else if ((ckbNotificar.FindForm().Controls.Find("panSemana", false)) != null)
                    ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }
        #endregion

        #endregion
    }
}
