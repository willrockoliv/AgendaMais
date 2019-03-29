using AgendaMais.Classes;
using AgendaMais.Classes.Enums;
using AgendaMais.Properties;
using AgendaMais.Telas.Relatórios;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace AgendaMais
{
    public partial class frAgendados : Form
    {
        #region Variáveis Globais
        DateTime segunda = new DateTime();
        DateTime terca = new DateTime();
        DateTime quarta = new DateTime();
        DateTime quinta = new DateTime();
        DateTime sexta = new DateTime();
        DateTime sabado = new DateTime();
        DateTime domingo = new DateTime();

        MetodosAgenda[] agendaSemana = new MetodosAgenda[7];
        MetodosAgenda agendaSegunda = new MetodosAgenda();
        MetodosAgenda agendaTerca = new MetodosAgenda();
        MetodosAgenda agendaQuarta = new MetodosAgenda();
        MetodosAgenda agendaQuinta = new MetodosAgenda();
        MetodosAgenda agendaSexta = new MetodosAgenda();
        MetodosAgenda agendaSabado = new MetodosAgenda();
        MetodosAgenda agendaDomingo = new MetodosAgenda();

        MetodosAgenda[] agendaMes = new MetodosAgenda[12];
        MetodosAgenda agendaJaneiro = new MetodosAgenda();
        MetodosAgenda agendaFevereiro = new MetodosAgenda();
        MetodosAgenda agendaMarco = new MetodosAgenda();
        MetodosAgenda agendaAbril = new MetodosAgenda();
        MetodosAgenda agendaMaio = new MetodosAgenda();
        MetodosAgenda agendaJunho = new MetodosAgenda();
        MetodosAgenda agendaJulho = new MetodosAgenda();
        MetodosAgenda agendaAgosto = new MetodosAgenda();
        MetodosAgenda agendaSetembro = new MetodosAgenda();
        MetodosAgenda agendaOutubro = new MetodosAgenda();
        MetodosAgenda agendaNovembro = new MetodosAgenda();
        MetodosAgenda agendaDezembro = new MetodosAgenda();
        #endregion

        #region Métodos Auxiliares
        void AlteraMesSemana(Enum_TipoExibicaoAgenda p_enum_frAgendados)
        {
            panSemanaContainer.Visible = Enum_TipoExibicaoAgenda.semana == p_enum_frAgendados;
            panTop.Visible = Enum_TipoExibicaoAgenda.semana == p_enum_frAgendados;

            panMesContainer.Visible = Enum_TipoExibicaoAgenda.mes == p_enum_frAgendados;

            if (Enum_TipoExibicaoAgenda.semana == p_enum_frAgendados)
            {
                panSemana.BackColor = Color.FromArgb(173, 177, 195);
                panMes.BackColor = Color.FromArgb(170, 120, 135, 155);

                AlteraDiaSemana((EnumDiasSemana)(int)DateTime.Now.DayOfWeek);

                agendaSemana[(int)DateTime.Now.DayOfWeek].ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
            }
            else if (Enum_TipoExibicaoAgenda.mes == p_enum_frAgendados)
            {
                panSemana.BackColor = Color.FromArgb(170, 120, 135, 155);
                panMes.BackColor = Color.FromArgb(173, 177, 195);

                AlteraMes((EnumMeses)(DateTime.Now.Month - 1));
                agendaMes[DateTime.Now.Month - 1].ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
            }
        }

        void AlteraDiaSemana(EnumDiasSemana p_enumDiasSemana)
        {
            if (EnumDiasSemana.segunda == p_enumDiasSemana)
            {
                panSeg.BackColor = Color.FromArgb(215, 217, 223);
                panTer.BackColor = Color.FromArgb(173, 177, 195);
                panQua.BackColor = Color.FromArgb(173, 177, 195);
                panQui.BackColor = Color.FromArgb(173, 177, 195);
                panSex.BackColor = Color.FromArgb(173, 177, 195);
                panSab.BackColor = Color.FromArgb(173, 177, 195);
                panDom.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumDiasSemana.terca == p_enumDiasSemana)
            {
                panSeg.BackColor = Color.FromArgb(173, 177, 195);
                panTer.BackColor = Color.FromArgb(215, 217, 223);
                panQua.BackColor = Color.FromArgb(173, 177, 195);
                panQui.BackColor = Color.FromArgb(173, 177, 195);
                panSex.BackColor = Color.FromArgb(173, 177, 195);
                panSab.BackColor = Color.FromArgb(173, 177, 195);
                panDom.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumDiasSemana.quarta == p_enumDiasSemana)
            {
                panSeg.BackColor = Color.FromArgb(173, 177, 195);
                panTer.BackColor = Color.FromArgb(173, 177, 195);
                panQua.BackColor = Color.FromArgb(215, 217, 223);
                panQui.BackColor = Color.FromArgb(173, 177, 195);
                panSex.BackColor = Color.FromArgb(173, 177, 195);
                panSab.BackColor = Color.FromArgb(173, 177, 195);
                panDom.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumDiasSemana.quinta == p_enumDiasSemana)
            {
                panSeg.BackColor = Color.FromArgb(173, 177, 195);
                panTer.BackColor = Color.FromArgb(173, 177, 195);
                panQua.BackColor = Color.FromArgb(173, 177, 195);
                panQui.BackColor = Color.FromArgb(215, 217, 223);
                panSex.BackColor = Color.FromArgb(173, 177, 195);
                panSab.BackColor = Color.FromArgb(173, 177, 195);
                panDom.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumDiasSemana.sexta == p_enumDiasSemana)
            {
                panSeg.BackColor = Color.FromArgb(173, 177, 195);
                panTer.BackColor = Color.FromArgb(173, 177, 195);
                panQua.BackColor = Color.FromArgb(173, 177, 195);
                panQui.BackColor = Color.FromArgb(173, 177, 195);
                panSex.BackColor = Color.FromArgb(215, 217, 223);
                panSab.BackColor = Color.FromArgb(173, 177, 195);
                panDom.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumDiasSemana.sabado == p_enumDiasSemana)
            {
                panSeg.BackColor = Color.FromArgb(173, 177, 195);
                panTer.BackColor = Color.FromArgb(173, 177, 195);
                panQua.BackColor = Color.FromArgb(173, 177, 195);
                panQui.BackColor = Color.FromArgb(173, 177, 195);
                panSex.BackColor = Color.FromArgb(173, 177, 195);
                panSab.BackColor = Color.FromArgb(215, 217, 223);
                panDom.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumDiasSemana.domingo == p_enumDiasSemana)
            {
                panSeg.BackColor = Color.FromArgb(173, 177, 195);
                panTer.BackColor = Color.FromArgb(173, 177, 195);
                panQua.BackColor = Color.FromArgb(173, 177, 195);
                panQui.BackColor = Color.FromArgb(173, 177, 195);
                panSex.BackColor = Color.FromArgb(173, 177, 195);
                panSab.BackColor = Color.FromArgb(173, 177, 195);
                panDom.BackColor = Color.FromArgb(215, 217, 223);
            }
        }

        void AlteraMes(EnumMeses p_enumMeses)
        {
            if (EnumMeses.janeiro == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(215, 217, 223);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.fevereiro == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(215, 217, 223);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.marco == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(215, 217, 223);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.abril == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(215, 217, 223);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.maio == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(215, 217, 223);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.junho == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(215, 217, 223);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.julho == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(215, 217, 223);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.agosto == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(215, 217, 223);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.setembro == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(215, 217, 223);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.outubro == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(215, 217, 223);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.novembro == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(215, 217, 223);
                panDez.BackColor = Color.FromArgb(173, 177, 195);
            }
            else if (EnumMeses.dezembro == p_enumMeses)
            {
                panJan.BackColor = Color.FromArgb(173, 177, 195);
                panFev.BackColor = Color.FromArgb(173, 177, 195);
                panMar.BackColor = Color.FromArgb(173, 177, 195);
                panAbr.BackColor = Color.FromArgb(173, 177, 195);
                panMai.BackColor = Color.FromArgb(173, 177, 195);
                panJun.BackColor = Color.FromArgb(173, 177, 195);
                panJul.BackColor = Color.FromArgb(173, 177, 195);
                panAgo.BackColor = Color.FromArgb(173, 177, 195);
                panSet.BackColor = Color.FromArgb(173, 177, 195);
                panOut.BackColor = Color.FromArgb(173, 177, 195);
                panNov.BackColor = Color.FromArgb(173, 177, 195);
                panDez.BackColor = Color.FromArgb(215, 217, 223);
            }
        }

        void DefineDatasSemana()
        {
            int dia = (int)DateTime.Now.DayOfWeek;
            if (dia == 0)
            {
                segunda = DateTime.Now.AddDays(-6);
                terca = DateTime.Now.AddDays(-5);
                quarta = DateTime.Now.AddDays(-4);
                quinta = DateTime.Now.AddDays(-3);
                sexta = DateTime.Now.AddDays(-2);
                sabado = DateTime.Now.AddDays(-1);
                domingo = DateTime.Now;

                lblDom.BackColor = Color.FromArgb(215, 217, 223);

                lblSeg.Text = "SEGUNDA \n(" + segunda.Day + ")";
                lblTer.Text = "TERÇA \n(" + terca.Day + ")";
                lblQua.Text = "QUARTA \n(" + quarta.Day + ")";
                lblQui.Text = "QUINTA \n(" + quinta.Day + ")";
                lblSex.Text = "SEXTA \n(" + sexta.Day + ")";
                lblSab.Text = "SÁBADO \n(" + sabado.Day + ")";
                lblDom.Text = "DOMINGO \n(" + domingo.Day + ")";
            }
            else if (dia == 1)
            {
                segunda = DateTime.Now;
                terca = DateTime.Now.AddDays(1);
                quarta = DateTime.Now.AddDays(2);
                quinta = DateTime.Now.AddDays(3);
                sexta = DateTime.Now.AddDays(4);
                sabado = DateTime.Now.AddDays(5);
                domingo = DateTime.Now.AddDays(6);

                lblSeg.BackColor = Color.FromArgb(215, 217, 223);

                lblSeg.Text = "SEGUNDA \n(" + segunda.Day + ")";
                lblTer.Text = "TERÇA \n(" + terca.Day + ")";
                lblQua.Text = "QUARTA \n(" + quarta.Day + ")";
                lblQui.Text = "QUINTA \n(" + quinta.Day + ")";
                lblSex.Text = "SEXTA \n(" + sexta.Day + ")";
                lblSab.Text = "SÁBADO \n(" + sabado.Day + ")";
                lblDom.Text = "DOMINGO \n(" + domingo.Day + ")";
            }
            else if (dia == 2)
            {
                segunda = DateTime.Now.AddDays(-1);
                terca = DateTime.Now;
                quarta = DateTime.Now.AddDays(1);
                quinta = DateTime.Now.AddDays(2);
                sexta = DateTime.Now.AddDays(3);
                sabado = DateTime.Now.AddDays(4);
                domingo = DateTime.Now.AddDays(5);

                lblTer.BackColor = Color.FromArgb(215, 217, 223);

                lblSeg.Text = "SEGUNDA \n(" + segunda.Day + ")";
                lblTer.Text = "TERÇA \n(" + terca.Day + ")";
                lblQua.Text = "QUARTA \n(" + quarta.Day + ")";
                lblQui.Text = "QUINTA \n(" + quinta.Day + ")";
                lblSex.Text = "SEXTA \n(" + sexta.Day + ")";
                lblSab.Text = "SÁBADO \n(" + sabado.Day + ")";
                lblDom.Text = "DOMINGO \n(" + domingo.Day + ")";
            }
            else if (dia == 3)
            {
                segunda = DateTime.Now.AddDays(-2);
                terca = DateTime.Now.AddDays(-1);
                quarta = DateTime.Now;
                quinta = DateTime.Now.AddDays(1);
                sexta = DateTime.Now.AddDays(2);
                sabado = DateTime.Now.AddDays(3);
                domingo = DateTime.Now.AddDays(4);

                lblQua.BackColor = Color.FromArgb(215, 217, 223);

                lblSeg.Text = "SEGUNDA \n(" + segunda.Day + ")";
                lblTer.Text = "TERÇA \n(" + terca.Day + ")";
                lblQua.Text = "QUARTA \n(" + quarta.Day + ")";
                lblQui.Text = "QUINTA \n(" + quinta.Day + ")";
                lblSex.Text = "SEXTA \n(" + sexta.Day + ")";
                lblSab.Text = "SÁBADO \n(" + sabado.Day + ")";
                lblDom.Text = "DOMINGO \n(" + domingo.Day + ")";
            }
            else if (dia == 4)
            {
                segunda = DateTime.Now.AddDays(-3);
                terca = DateTime.Now.AddDays(-2);
                quarta = DateTime.Now.AddDays(-1);
                quinta = DateTime.Now;
                sexta = DateTime.Now.AddDays(1);
                sabado = DateTime.Now.AddDays(2);
                domingo = DateTime.Now.AddDays(3);

                lblQui.BackColor = Color.FromArgb(215, 217, 223);

                lblSeg.Text = "SEGUNDA \n(" + segunda.Day + ")";
                lblTer.Text = "TERÇA \n(" + terca.Day + ")";
                lblQua.Text = "QUARTA \n(" + quarta.Day + ")";
                lblQui.Text = "QUINTA \n(" + quinta.Day + ")";
                lblSex.Text = "SEXTA \n(" + sexta.Day + ")";
                lblSab.Text = "SÁBADO \n(" + sabado.Day + ")";
                lblDom.Text = "DOMINGO \n(" + domingo.Day + ")";
            }
            else if (dia == 5)
            {
                segunda = DateTime.Now.AddDays(-4);
                terca = DateTime.Now.AddDays(-3);
                quarta = DateTime.Now.AddDays(-2);
                quinta = DateTime.Now.AddDays(-1);
                sexta = DateTime.Now;
                sabado = DateTime.Now.AddDays(1);
                domingo = DateTime.Now.AddDays(2);

                lblSex.BackColor = Color.FromArgb(215, 217, 223);

                lblSeg.Text = "SEGUNDA \n(" + segunda.Day + ")";
                lblTer.Text = "TERÇA \n(" + terca.Day + ")";
                lblQua.Text = "QUARTA \n(" + quarta.Day + ")";
                lblQui.Text = "QUINTA \n(" + quinta.Day + ")";
                lblSex.Text = "SEXTA \n(" + sexta.Day + ")";
                lblSab.Text = "SÁBADO \n(" + sabado.Day + ")";
                lblDom.Text = "DOMINGO \n(" + domingo.Day + ")";
            }
            else if (dia == 6)
            {
                segunda = DateTime.Now.AddDays(-5);
                terca = DateTime.Now.AddDays(-4);
                quarta = DateTime.Now.AddDays(-3);
                quinta = DateTime.Now.AddDays(-2);
                sexta = DateTime.Now.AddDays(-1);
                sabado = DateTime.Now;
                domingo = DateTime.Now.AddDays(1);

                lblSab.BackColor = Color.FromArgb(215, 217, 223);

                lblSeg.Text = "SEGUNDA \n(" + segunda.Day + ")";
                lblTer.Text = "TERÇA \n(" + terca.Day + ")";
                lblQua.Text = "QUARTA \n(" + quarta.Day + ")";
                lblQui.Text = "QUINTA \n(" + quinta.Day + ")";
                lblSex.Text = "SEXTA \n(" + sexta.Day + ")";
                lblSab.Text = "SÁBADO \n(" + sabado.Day + ")";
                lblDom.Text = "DOMINGO \n(" + domingo.Day + ")";
            }
        }

        public void AtualizaAgendaSemana()
        {
            using (new Carregando())
            {
                agendaDomingo.Atualiza_listAgenda(Convert.ToDateTime(domingo.ToString("dd/MM/yyyy") + " 00:00:00"), Convert.ToDateTime(domingo.ToString("dd/MM/yyyy") + " 23:59:59"), 'P', 'C', 'N');
                agendaSegunda.Atualiza_listAgenda(Convert.ToDateTime(segunda.ToString("dd/MM/yyyy") + " 00:00:00"), Convert.ToDateTime(segunda.ToString("dd/MM/yyyy") + " 23:59:59"), 'P', 'C', 'N');
                agendaTerca.Atualiza_listAgenda(Convert.ToDateTime(terca.ToString("dd/MM/yyyy") + " 00:00:00"), Convert.ToDateTime(terca.ToString("dd/MM/yyyy") + " 23:59:59"), 'P', 'C', 'N');
                agendaQuarta.Atualiza_listAgenda(Convert.ToDateTime(quarta.ToString("dd/MM/yyyy") + " 00:00:00"), Convert.ToDateTime(quarta.ToString("dd/MM/yyyy") + " 23:59:59"), 'P', 'C', 'N');
                agendaQuinta.Atualiza_listAgenda(Convert.ToDateTime(quinta.ToString("dd/MM/yyyy") + " 00:00:00"), Convert.ToDateTime(quinta.ToString("dd/MM/yyyy") + " 23:59:59"), 'P', 'C', 'N');
                agendaSexta.Atualiza_listAgenda(Convert.ToDateTime(sexta.ToString("dd/MM/yyyy") + " 00:00:00"), Convert.ToDateTime(sexta.ToString("dd/MM/yyyy") + " 23:59:59"), 'P', 'C', 'N');
                agendaSabado.Atualiza_listAgenda(Convert.ToDateTime(sabado.ToString("dd/MM/yyyy") + " 00:00:00"), Convert.ToDateTime(sabado.ToString("dd/MM/yyyy") + " 23:59:59"), 'P', 'C', 'N');
            }

            agendaSemana[0] = agendaDomingo;
            agendaSemana[1] = agendaSegunda;
            agendaSemana[2] = agendaTerca;
            agendaSemana[3] = agendaQuarta;
            agendaSemana[4] = agendaQuinta;
            agendaSemana[5] = agendaSexta;
            agendaSemana[6] = agendaSabado;
        }

        static bool AnoBissexto(DateTime ano)
        {
            bool bissexto = false;

            if (ano.Year % 4 == 0)
                if (ano.Year % 100 != 0)
                    bissexto = true;
                else if (ano.Year % 400 == 0)
                    bissexto = true;

            return bissexto;
        }

        public void AtualizaAgendaMeses()
        {
            using (new Carregando())
            {
                agendaJaneiro.Atualiza_listAgenda(Convert.ToDateTime("01/01/" + DateTime.Now.Year + " 00:00:00"),
                                                  Convert.ToDateTime("31/01/" + DateTime.Now.Year + " 23:59:59"),
                                                  'P', 'C', 'N');
                if (AnoBissexto(DateTime.Now))
                    agendaFevereiro.Atualiza_listAgenda(Convert.ToDateTime("01/02/" + DateTime.Now.Year + " 00:00:00"),
                                                        Convert.ToDateTime("29/02/" + DateTime.Now.Year + " 23:59:59"),
                                                        'P', 'C', 'N');
                else
                    agendaFevereiro.Atualiza_listAgenda(Convert.ToDateTime("01/02/" + DateTime.Now.Year + " 00:00:00"),
                                                        Convert.ToDateTime("28/02/" + DateTime.Now.Year + " 23:59:59"),
                                                        'P', 'C', 'N');
                agendaMarco.Atualiza_listAgenda(Convert.ToDateTime("01/03/" + DateTime.Now.Year + " 00:00:00"),
                                                Convert.ToDateTime("31/03/" + DateTime.Now.Year + " 23:59:59"),
                                                'P', 'C', 'N');
                agendaAbril.Atualiza_listAgenda(Convert.ToDateTime("01/04/" + DateTime.Now.Year + " 00:00:00"),
                                                Convert.ToDateTime("30/04/" + DateTime.Now.Year + " 23:59:59"),
                                                'P', 'C', 'N');
                agendaMaio.Atualiza_listAgenda(Convert.ToDateTime("01/05/" + DateTime.Now.Year + " 00:00:00"),
                                               Convert.ToDateTime("31/05/" + DateTime.Now.Year + " 23:59:59"),
                                               'P', 'C', 'N');
                agendaJunho.Atualiza_listAgenda(Convert.ToDateTime("01/06/" + DateTime.Now.Year + " 00:00:00"),
                                                Convert.ToDateTime("30/06/" + DateTime.Now.Year + " 23:59:59"),
                                                'P', 'C', 'N');
                agendaJulho.Atualiza_listAgenda(Convert.ToDateTime("01/07/" + DateTime.Now.Year + " 00:00:00"),
                                                Convert.ToDateTime("31/07/" + DateTime.Now.Year + " 23:59:59"),
                                                'P', 'C', 'N');
                agendaAgosto.Atualiza_listAgenda(Convert.ToDateTime("01/08/" + DateTime.Now.Year + " 00:00:00"),
                                                 Convert.ToDateTime("31/08/" + DateTime.Now.Year + " 23:59:59"),
                                                 'P', 'C', 'N');
                agendaSetembro.Atualiza_listAgenda(Convert.ToDateTime("01/09/" + DateTime.Now.Year + " 00:00:00"),
                                                   Convert.ToDateTime("30/09/" + DateTime.Now.Year + " 23:59:59"),
                                                   'P', 'C', 'N');
                agendaOutubro.Atualiza_listAgenda(Convert.ToDateTime("01/10/" + DateTime.Now.Year + " 00:00:00"),
                                                  Convert.ToDateTime("31/10/" + DateTime.Now.Year + " 23:59:59"),
                                                  'P', 'C', 'N');
                agendaNovembro.Atualiza_listAgenda(Convert.ToDateTime("01/11/" + DateTime.Now.Year + " 00:00:00"),
                                                   Convert.ToDateTime("30/11/" + DateTime.Now.Year + " 23:59:59"),
                                                   'P', 'C', 'N');
                agendaDezembro.Atualiza_listAgenda(Convert.ToDateTime("01/12/" + DateTime.Now.Year + " 00:00:00"),
                                                   Convert.ToDateTime("31/12/" + DateTime.Now.Year + " 23:59:59"),
                                                   'P', 'C', 'N');
            }

            agendaMes[0] = agendaJaneiro;
            agendaMes[1] = agendaFevereiro;
            agendaMes[2] = agendaMarco;
            agendaMes[3] = agendaAbril;
            agendaMes[4] = agendaMaio;
            agendaMes[5] = agendaJunho;
            agendaMes[6] = agendaJulho;
            agendaMes[7] = agendaAgosto;
            agendaMes[8] = agendaSetembro;
            agendaMes[9] = agendaOutubro;
            agendaMes[10] = agendaNovembro;
            agendaMes[11] = agendaDezembro;
        }

        public void AtualizaTodasAgendas()
        {
            AtualizaAgendaSemana();
            AtualizaAgendaMeses();
        }
        #endregion

        public frAgendados()
        {
            InitializeComponent();
            DefineDatasSemana();
            AtualizaTodasAgendas();
            AlteraMesSemana(Enum_TipoExibicaoAgenda.semana);
            AlteraDiaSemana((EnumDiasSemana)(int)DateTime.Now.DayOfWeek);
            agendaSemana[(int)DateTime.Now.DayOfWeek].ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }

        #region Eventos Painel Semana e Mes

        #region Semana
        private void panSemana_Click(object sender, EventArgs e)
        {
            AlteraMesSemana(Enum_TipoExibicaoAgenda.semana);
        }

        private void panDom_Click(object sender, EventArgs e)
        {
            AlteraDiaSemana(EnumDiasSemana.domingo);
            agendaDomingo.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }

        private void panSeg_Click(object sender, EventArgs e)
        {
            AlteraDiaSemana(EnumDiasSemana.segunda);
            agendaSegunda.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }

        private void panTer_Click(object sender, EventArgs e)
        {
            AlteraDiaSemana(EnumDiasSemana.terca);
            agendaTerca.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }

        private void panQua_Click(object sender, EventArgs e)
        {
            AlteraDiaSemana(EnumDiasSemana.quarta);
            agendaQuarta.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }

        private void panQui_Click(object sender, EventArgs e)
        {
            AlteraDiaSemana(EnumDiasSemana.quinta);
            agendaQuinta.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }

        private void panSex_Click(object sender, EventArgs e)
        {
            AlteraDiaSemana(EnumDiasSemana.sexta);
            agendaSexta.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }

        private void lblSab_Click(object sender, EventArgs e)
        {
            AlteraDiaSemana(EnumDiasSemana.sabado);
            agendaSabado.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.semana);
        }
        #endregion

        #region Mes
        private void panMes_Click(object sender, EventArgs e)
        {
            AlteraMesSemana(Enum_TipoExibicaoAgenda.mes);
        }

        private void panJan_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.janeiro);
            agendaJaneiro.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panFev_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.fevereiro);
            agendaFevereiro.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panMar_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.marco);
            agendaMarco.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panAbr_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.abril);
            agendaAbril.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panMai_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.maio);
            agendaMaio.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panJun_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.junho);
            agendaJunho.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panJul_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.julho);
            agendaJulho.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panAgo_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.agosto);
            agendaAgosto.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panSet_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.setembro);
            agendaSetembro.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panOut_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.outubro);
            agendaOutubro.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panNov_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.novembro);
            agendaNovembro.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }

        private void panDez_Click(object sender, EventArgs e)
        {
            AlteraMes(EnumMeses.dezembro);
            agendaDezembro.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.mes);
        }


        #endregion

        #endregion

        #region ptbRelatorios
        private void ptbRelatorios_Click(object sender, EventArgs e)
        {
            frFrequenciaDeAgendamento frFrequenciaDeAgendamento = new frFrequenciaDeAgendamento();
            frFrequenciaDeAgendamento.Show();
        }

        private void ptbRelatorios_MouseEnter(object sender, EventArgs e)
        {
            ptbRelatorios.Image = Resources.Relatorios;
        }

        private void ptbRelatorios_MouseLeave(object sender, EventArgs e)
        {
            ptbRelatorios.Image = ptbRelatorios.Image = Resources.Relatorios_transparency;
        }
        #endregion

        #region ptbAgendamento
        private void ptbAgendamento_Click(object sender, EventArgs e)
        {
            frAgendamento frAgendamento;
            using (new Carregando("Carregando..."))
                frAgendamento = new frAgendamento();
            frAgendamento.ShowDialog();
            AtualizaTodasAgendas();
        }

        private void ptbAgendamento_MouseEnter(object sender, EventArgs e)
        {
            ptbAgendamento.Image = Resources.agendamento;
        }

        private void ptbAgendamento_MouseLeave(object sender, EventArgs e)
        {
            ptbAgendamento.Image = Resources.agendamento_transparency;
        }
        #endregion

        #region ptbCadCliente
        private void ptbClientes_Click(object sender, EventArgs e)
        {
            frCadCliente frCadCliente = new frCadCliente();
            frCadCliente.ShowDialog();
        }

        private void ptbClientes_MouseEnter(object sender, EventArgs e)
        {
            ptbClientes.Image = Resources.peaple__4_;
        }

        private void ptbClientes_MouseLeave(object sender, EventArgs e)
        {
            ptbClientes.Image = Resources.peaple__4__transparency;
        }
        #endregion
    }
}
