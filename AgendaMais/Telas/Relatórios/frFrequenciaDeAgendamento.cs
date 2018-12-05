using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgendaMais.Telas.Relatórios
{
    public partial class frFrequenciaDeAgendamento : Form
    {
        Panel ConstrutorPanDados(string nome, int confirmados, int cancelados, int pendentes, int frequencia, DateTime possivel_data_retorno)
        {
            #region panDados
            Panel panDados = new Panel();
            panDados.BackColor = Color.White;
            panDados.Size = new Size(944, 35);
            panDados.Enabled = false;
            #endregion

            #region txtNome
            TextBox txtNome = new TextBox();
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(7, 7);
            txtNome.Size = new Size(193, 20);
            txtNome.Text = nome;
            txtNome.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region txtConfirmados
            TextBox txtConfirmados = new TextBox();
            txtConfirmados.BackColor = Color.White;
            txtConfirmados.BorderStyle = BorderStyle.None;
            txtConfirmados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmados.Location = new Point(232, 7);
            txtConfirmados.Size = new Size(72, 20);
            txtConfirmados.Text = confirmados.ToString();
            txtConfirmados.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region txtCancelados
            TextBox txtCancelados = new TextBox();
            txtCancelados.BackColor = Color.White;
            txtCancelados.BorderStyle = BorderStyle.None;
            txtCancelados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCancelados.Location = new Point(357, 7);
            txtCancelados.Size = new Size(72, 20);
            txtCancelados.Text = cancelados.ToString();
            txtCancelados.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region txtPendentes
            TextBox txtPendentes = new TextBox();
            txtPendentes.BackColor = Color.White;
            txtPendentes.BorderStyle = BorderStyle.None;
            txtPendentes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPendentes.Location = new Point(474, 7);
            txtPendentes.Size = new Size(72, 20);
            txtPendentes.Text = pendentes.ToString();
            txtPendentes.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region txtFrequencia
            TextBox txtFrequencia = new TextBox();
            txtFrequencia.BackColor = Color.White;
            txtFrequencia.BorderStyle = BorderStyle.None;
            txtFrequencia.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFrequencia.Location = new Point(552, 7);
            txtFrequencia.Size = new Size(149, 20);
            if (frequencia == 0)
                txtFrequencia.Text = "-";
            else
                txtFrequencia.Text = $"a cada {frequencia.ToString()} dias";
            txtFrequencia.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region txtPossivelDataRetorno
            TextBox txtPossivelDataRetorno = new TextBox();
            txtPossivelDataRetorno.BackColor = Color.White;
            txtPossivelDataRetorno.BorderStyle = BorderStyle.None;
            txtPossivelDataRetorno.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPossivelDataRetorno.ForeColor = Color.Black;
            txtPossivelDataRetorno.Location = new Point(707, 7);
            txtPossivelDataRetorno.Size = new Size(72, 20);
            if (frequencia == 0)
                txtPossivelDataRetorno.Text = "-";
            else
                txtPossivelDataRetorno.Text = possivel_data_retorno.ToString("dd/MM");
            txtPossivelDataRetorno.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region ptbStatus
            PictureBox ptbStatus = new PictureBox();
            if (frequencia == 0)
                ptbStatus.Image = null;
            else
            {
                TimeSpan diff = DateTime.Now - possivel_data_retorno;
                if (diff.Days > 10)
                    ptbStatus.Image = Properties.Resources.vermelho;
                else if (diff.Days >= 1)
                    ptbStatus.Image = Properties.Resources.amarelo;
                else
                    ptbStatus.Image = Properties.Resources.verde;
            }
            ptbStatus.Location = new Point(874, 2);
            ptbStatus.Size = new Size(30, 30);
            ptbStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            #endregion

            panDados.Controls.Add(ptbStatus);
            panDados.Controls.Add(txtPossivelDataRetorno);
            panDados.Controls.Add(txtFrequencia);
            panDados.Controls.Add(txtPendentes);
            panDados.Controls.Add(txtCancelados);
            panDados.Controls.Add(txtConfirmados);
            panDados.Controls.Add(txtNome);

            return panDados;
        }

        void ExibeDados()
        {
            flpDados.Visible = false;

            using (new Carregando("Processando dados..."))
            {
                RelatoriosDAO relatoriosDAO = new RelatoriosDAO();
                relatoriosDAO.relatorio_FrequenciaDeAgendamentos();

                flpDados.Controls.Clear();
                for (int i = 0; i < relatoriosDAO.ListFreqAgendamentos.Count; i++)
                    flpDados.Controls.Add(ConstrutorPanDados(relatoriosDAO.ListFreqAgendamentos[i].nome,
                                                             relatoriosDAO.ListFreqAgendamentos[i].confirmados,
                                                             relatoriosDAO.ListFreqAgendamentos[i].cancelados,
                                                             relatoriosDAO.ListFreqAgendamentos[i].pendentes,
                                                             relatoriosDAO.ListFreqAgendamentos[i].frequencia,
                                                             relatoriosDAO.ListFreqAgendamentos[i].possivel_data_retorno));
            }

            flpDados.Visible = true;
        }

        public frFrequenciaDeAgendamento()
        {
            InitializeComponent();
        }

        private void frFrequenciaDeAgendamento_Load(object sender, EventArgs e)
        {
            ExibeDados();
        }
    }
}
