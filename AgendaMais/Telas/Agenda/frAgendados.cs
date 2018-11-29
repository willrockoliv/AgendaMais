using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frAgendados : Form
    {
        #region old
        //#region Veriáveis Públicas
        ///// <summary>
        ///// Struct que será usada para organizar os dados de agendamentos cadastrados
        ///// </summary>
        //public struct ListaAgenda
        //{
        //    public DateTime data, hora;
        //    public int codigo, codInterno, codFuncionario;
        //    public string nome, telcel, obs, nomeFuncionario;
        //}
        //public string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";

        //public static List<DataRow> Agenda;
        //#endregion

        //#region Métodos
        ///// <summary>
        ///// Carrega os agendamentos do dia corrente ordenados por hora e chama o método ExibeAgenda()
        ///// </summary>
        //public static void AtualizaAgenda(ref ListBox ltbHoje)
        //{

        //    string condicao = string.Format("data = '{0}' ORDER BY hora", DateTime.Now.ToString("dd/MM/yyyy"));
        //    Agenda = new List<DataRow>();

        //    DataTable tableAgenda = AgendaDAO.GetRegistros("");

        //    foreach (DataRow linha in tableAgenda.Rows)
        //    {
        //        Agenda.Add(linha);
        //    }

        //    ExibeAgenda(ref ltbHoje);
        //}

        ///// <summary>
        ///// Chama o método LayoutAgenda() e exibe os agendamentos do dia na ListBox ltbHoje
        ///// </summary>
        ///// <param name="ltbHoje">ListBox da tela frPrincipal</param>
        //public static void ExibeAgenda(ref ListBox ltbHoje)
        //{
        //    ////string[] agenda = Classes.Agenda.LayoutAgendaHoje(Agenda);

        //    //ltbHoje.Items.Clear();

        //    //foreach (string linha in agenda)
        //    //{
        //    //    ltbHoje.Items.Add(linha);
        //    //}
        //}

        ///// <summary>
        ///// Exibe em cada ListBox 
        ///// </summary>
        ///// <param name="arquivoAgenda"></param>
        ///// <param name="ltbDom"></param>
        ///// <param name="ltbSeg"></param>
        ///// <param name="ltbTer"></param>
        ///// <param name="ltbQua"></param>
        ///// <param name="ltbQui"></param>
        ///// <param name="ltbSex"></param>
        ///// <param name="ltbSab"></param>
        ///// <param name="lblDiaDom"></param>
        ///// <param name="lblDiaSeg"></param>
        ///// <param name="lblDiaTer"></param>
        ///// <param name="lblDiaQua"></param>
        ///// <param name="lblDiaQui"></param>
        ///// <param name="lblDiaSex"></param>
        ///// <param name="lblDiaSab"></param>
        //public static void ExibeAgendaDiaSemana(string arquivoAgenda, ref ListBox ltbDom, ref ListBox ltbSeg, ref ListBox ltbTer, ref ListBox ltbQua, ref ListBox ltbQui,
        //                                        ref ListBox ltbSex, ref ListBox ltbSab,
        //                                        Label lblDiaDom, Label lblDiaSeg, Label lblDiaTer, Label lblDiaQua, Label lblDiaQui, Label lblDiaSex,
        //                                        Label lblDiaSab)
        //{
        //    #region Variáveis
        //    //CarregaArquivo Arquivo = new CarregaArquivo();
        //    // string[] agenda = Arquivo.Agenda(arquivoAgenda);
        //    //ListaAgenda[] listaAgenda = new ListaAgenda[agenda.Length];
        //    string[] listaAgendaOrdenada, layout;
        //    string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";
        //    #endregion

        //    //listaAgenda = AlimentaListaAgenda(agenda);

        //    //Exibe os agendamentos organizados por horário.
        //    #region Domingo
        //    listaAgendaOrdenada = OrdenaPorDataHora(listaAgenda, Convert.ToDateTime(lblDiaDom.Text));

        //    layout = LayoutAgenda(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbDom com os agendamentos do dia atualizados, organizados por horário
        //    ltbDom.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbDom.Items.Add(agendamento);
        //    }

        //    // Atualiza o arquivo agenda_dom.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_dom.txt", listaAgendaOrdenada, Encoding.Default);
        //    #endregion

        //    #region Segunda
        //    listaAgendaOrdenada = OrdenaPorDataHora(listaAgenda, Convert.ToDateTime(lblDiaSeg.Text));

        //    layout = LayoutAgenda(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbSeg com os agendamentos do dia atualizados, organizados por horário
        //    ltbSeg.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbSeg.Items.Add(agendamento);
        //    }
        //    // Atualiza o arquivo agenda_seg.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_seg.txt", listaAgendaOrdenada, Encoding.Default);
        //    #endregion

        //    #region Terça
        //    listaAgendaOrdenada = OrdenaPorDataHora(listaAgenda, Convert.ToDateTime(lblDiaTer.Text));

        //    layout = LayoutAgenda(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbTer com os agendamentos do dia atualizados, organizados por horário
        //    ltbTer.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbTer.Items.Add(agendamento);
        //    }
        //    // Atualiza o arquivo agenda_ter.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_ter.txt", listaAgendaOrdenada, Encoding.Default);
        //    #endregion

        //    #region Quarta
        //    listaAgendaOrdenada = OrdenaPorDataHora(listaAgenda, Convert.ToDateTime(lblDiaQua.Text));

        //    layout = LayoutAgenda(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbQua com os agendamentos do dia atualizados, organizados por horário
        //    ltbQua.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbQua.Items.Add(agendamento);
        //    }
        //    // Atualiza o arquivo agenda_qua.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_qua.txt", listaAgendaOrdenada, Encoding.Default);
        //    #endregion

        //    #region Quinta
        //    listaAgendaOrdenada = OrdenaPorDataHora(listaAgenda, Convert.ToDateTime(lblDiaQui.Text));

        //    layout = LayoutAgenda(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbQui com os agendamentos do dia atualizados, organizados por horário
        //    ltbQui.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbQui.Items.Add(agendamento);
        //    }
        //    // Atualiza o arquivo agenda_qui.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_qui.txt", listaAgendaOrdenada, Encoding.Default);
        //    #endregion

        //    #region Sexta
        //    listaAgendaOrdenada = OrdenaPorDataHora(listaAgenda, Convert.ToDateTime(lblDiaSex.Text));

        //    layout = LayoutAgenda(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbSex com os agendamentos do dia atualizados, organizados por horário
        //    ltbSex.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbSex.Items.Add(agendamento);
        //    }
        //    // Atualiza o arquivo agenda_sex.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_sex.txt", listaAgendaOrdenada, Encoding.Default);
        //    #endregion

        //    #region Sábado
        //    listaAgendaOrdenada = OrdenaPorDataHora(listaAgenda, Convert.ToDateTime(lblDiaSab.Text));

        //    layout = LayoutAgenda(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbSab com os agendamentos do dia atualizados, organizados por horário
        //    ltbSab.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbSab.Items.Add(agendamento);
        //    }
        //    // Atualiza o arquivo agenda_sab.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_sab.txt", listaAgendaOrdenada, Encoding.Default);
        //    #endregion
        //}

        ///// <summary>
        ///// Organiza o vetor com os agendamentos da data passada por parâmetro, por horário crescente
        ///// </summary>
        ///// <param name="listaAgenda">Vetor com todos os agendamentos cadastrados</param>
        ///// <param name="dia">Data que será usada como parâmetro para filtrar quais agendamentos devem ser orgamizados</param>
        ///// <returns>Retorna um vetor de string com todos os agendamentos da data atual organizados por hora</returns>
        //public static string[] OrdenaPorDataHora(ListaAgenda[] listaAgenda, DateTime dia)
        //{
        //    #region Variáveis
        //    string[] agendaDoDia = new string[0], agendaPorHorario;
        //    int j = -1, posicaoMenorHorario = 0;
        //    string codigo, nomeFuncionario, codFuncionario;
        //    #endregion

        //    #region Seleção dos agendamentos do dia
        //    for (int i = 0; i < listaAgenda.Length; i++)
        //    {
        //        #region old
        //        /*
        //        if (Convert.ToDateTime(listaAgenda[i].data) == dia)
        //        {
        //            Array.Resize(ref agendaDoDia, agendaDoDia.Length + 1);

        //            j++;

        //            if (listaAgenda[i].codigo == -1)
        //                codigo = "-";
        //            else
        //                codigo = listaAgenda[i].codigo.ToString();

        //            agendaDoDia[j] = listaAgenda[i].codInterno.ToString() + "|" + listaAgenda[i].hora.ToString("HH:mm") + "  //  " + codigo + "  //  " + listaAgenda[i].nome + "  //  " + listaAgenda[i].telcel + "  //  " + listaAgenda[i].obs;
        //        }
        //        */
        //        #endregion
        //        if (Convert.ToDateTime(listaAgenda[i].data) == dia)
        //        {
        //            Array.Resize(ref agendaDoDia, agendaDoDia.Length + 1);

        //            j++;

        //            if (listaAgenda[i].codFuncionario == -1)
        //            {
        //                codFuncionario = "";
        //                nomeFuncionario = "-";
        //            }
        //            else
        //            {
        //                codFuncionario = listaAgenda[i].codFuncionario.ToString();
        //                nomeFuncionario = listaAgenda[i].nomeFuncionario.Trim();
        //            }

        //            if (listaAgenda[i].codigo == -1)
        //                codigo = "";
        //            else
        //                codigo = listaAgenda[i].codigo.ToString();

        //            agendaDoDia[j] = listaAgenda[i].codInterno.ToString() + "|" + listaAgenda[i].hora.ToString("HH:mm") + "  |  " + codFuncionario + "  |  " + nomeFuncionario + "  |  " + codigo + "  |  " + listaAgenda[i].nome + "  |  " + listaAgenda[i].telcel + "  |  " + listaAgenda[i].obs;
        //        }
        //    }
        //    #endregion

        //    // Se não possui agendamento ou apenas 1, não entra no processo de ordenar por horário
        //    if (agendaDoDia.Length == 0 || agendaDoDia.Length == 1)
        //        return agendaDoDia;

        //    #region Ordenação por horário
        //    agendaPorHorario = new string[agendaDoDia.Length];

        //    for (int i = 0; i < agendaDoDia.Length; i++)
        //    {
        //        // Armazena o proximo agendamento que não foi validado
        //        for (j = 0; j < agendaDoDia.Length; j++)
        //        {
        //            if (agendaDoDia[j] != null)
        //            {
        //                agendaPorHorario[i] = agendaDoDia[j];
        //                posicaoMenorHorario = j;
        //                break;
        //            }
        //        }

        //        // Valida qual o próximo menor horário de agendamento
        //        for (j = 0; j < agendaDoDia.Length; j++)
        //        {
        //            if (agendaDoDia[j] != null)
        //            {
        //                // Separa o cadastro do código interno
        //                string[] temp1 = agendaPorHorario[i].Split('|');
        //                string[] temp2 = agendaDoDia[j].Split('|');

        //                if (Convert.ToDateTime(temp1[1].Trim().Substring(0, 5)) > Convert.ToDateTime(temp2[1].Trim().Substring(0, 5)))
        //                {
        //                    agendaPorHorario[i] = agendaDoDia[j];
        //                    posicaoMenorHorario = j;
        //                }
        //            }
        //        }

        //        //Exclui o menor horário para não ser validado novamente
        //        agendaDoDia[posicaoMenorHorario] = null;
        //    }

        //    return agendaPorHorario;
        //    #endregion
        //}

        //public static void ExibeAgendaMes(ref ListBox ltbMes, string mes)
        //{
        //    #region Variáveis
        //    CarregaArquivo Arquivo = new CarregaArquivo();
        //    string[] agenda = Arquivo.Agenda("agenda.txt");
        //    ListaAgenda[] listaAgenda = new ListaAgenda[agenda.Length];
        //    string[] listaAgendaOrdenada, layout;
        //    string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";
        //    #endregion

        //    listaAgenda = AlimentaListaAgenda(agenda);

        //    listaAgendaOrdenada = OrdenaPorDataHoraMes(listaAgenda, mes);

        //    layout = LayoutAgendaMes(listaAgendaOrdenada);

        //    // Limpa e realimenta a ListBox ltbMes com os agendamentos do dia atualizados, organizados por horário
        //    ltbMes.Items.Clear();
        //    foreach (string agendamento in layout)
        //    {
        //        ltbMes.Items.Add(agendamento);
        //    }

        //    // Atualiza o arquivo agenda_mes.txt
        //    File.WriteAllLines(caminhoBD + "\\agenda_mes.txt", listaAgendaOrdenada, Encoding.Default);
        //}

        ///// <summary>
        ///// Organiza o vetor com os agendamentos do mês passado por parâmetro, por horário crescente
        ///// </summary>
        ///// <param name="listaAgenda">Vetor com todos os agendamentos cadastrados</param>
        ///// <param name="mes">Mês que será usado como parâmetro para filtrar quais agendamentos devem ser orgamizados</param>
        ///// <returns>Retorna um vetor de string com todos os agendamentos da data atual organizados por hora</returns>
        //public static string[] OrdenaPorDataHoraMes(ListaAgenda[] listaAgenda, string mes)
        //{
        //    #region Variáveis
        //    string[] agendaDoMes = new string[0], agendaPorHora, agendaPorDataHora;
        //    int j = -1, posicaoMenor = 0;
        //    string codigo, nomeFuncionario, codFuncionario;
        //    #endregion

        //    #region Seleção dos agendamentos do mes
        //    for (int i = 0; i < listaAgenda.Length; i++)
        //    {
        //        if (listaAgenda[i].data.ToString("MM/yyyy") == mes)
        //        {
        //            Array.Resize(ref agendaDoMes, agendaDoMes.Length + 1);

        //            j++;

        //            if (listaAgenda[i].codFuncionario == -1)
        //            {
        //                codFuncionario = "";
        //                nomeFuncionario = "-";
        //            }
        //            else
        //            {
        //                codFuncionario = listaAgenda[i].codFuncionario.ToString();
        //                nomeFuncionario = listaAgenda[i].nomeFuncionario.Trim();
        //            }

        //            if (listaAgenda[i].codigo == -1)
        //                codigo = "";
        //            else
        //                codigo = listaAgenda[i].codigo.ToString();

        //            agendaDoMes[j] = listaAgenda[i].codInterno.ToString() + "|" + listaAgenda[i].data.ToString("dd/MM/yyyy") + "  |  " + listaAgenda[i].hora.ToString("HH:mm") + "  |  " + codFuncionario + "  |  " + nomeFuncionario + "  |  " + codigo + "  |  " + listaAgenda[i].nome + "  |  " + listaAgenda[i].telcel + "  |  " + listaAgenda[i].obs;
        //        }
        //    }
        //    #endregion

        //    // Se não possui agendamento ou apenas 1, não entra no processo de ordenar por horário
        //    if (agendaDoMes.Length == 0 || agendaDoMes.Length == 1)
        //        return agendaDoMes;

        //    #region Ordenação por horário
        //    agendaPorHora = new string[agendaDoMes.Length];

        //    for (int i = 0; i < agendaDoMes.Length; i++)
        //    {
        //        // Armazena o proximo agendamento que não foi validado
        //        for (j = 0; j < agendaDoMes.Length; j++)
        //        {
        //            if (agendaDoMes[j] != null)
        //            {
        //                agendaPorHora[i] = agendaDoMes[j];
        //                posicaoMenor = j;
        //                break;
        //            }
        //        }

        //        // Valida qual o próximo menor horário de agendamento
        //        for (j = 0; j < agendaDoMes.Length; j++)
        //        {
        //            if (agendaDoMes[j] != null)
        //            {
        //                // Separa o cadastro do código interno
        //                string[] temp1 = agendaPorHora[i].Replace("  //  ", "|").Split('|');
        //                string[] temp2 = agendaDoMes[j].Replace("  //  ", "|").Split('|');

        //                if (Convert.ToDateTime(temp1[2].Trim().Substring(0, 5)) > Convert.ToDateTime(temp2[2].Trim().Substring(0, 5)))
        //                {
        //                    agendaPorHora[i] = agendaDoMes[j];
        //                    posicaoMenor = j;
        //                }
        //            }
        //        }

        //        //Exclui o menor horário para não ser validado novamente
        //        agendaDoMes[posicaoMenor] = null;
        //    }
        //    #endregion

        //    #region Ordenação por Data
        //    agendaPorDataHora = new string[agendaPorHora.Length];

        //    for (int i = 0; i < agendaPorHora.Length; i++)
        //    {
        //        // Armazena o proximo agendamento que não foi validado
        //        for (j = 0; j < agendaPorHora.Length; j++)
        //        {
        //            if (agendaPorHora[j] != null)
        //            {
        //                agendaPorDataHora[i] = agendaPorHora[j];
        //                posicaoMenor = j;
        //                break;
        //            }
        //        }

        //        // Valida qual a próxima menor data de agendamento
        //        for (j = 0; j < agendaPorHora.Length; j++)
        //        {
        //            if (agendaPorHora[j] != null)
        //            {
        //                // Separa o cadastro do código interno
        //                string[] temp1 = agendaPorDataHora[i].Replace("  //  ", "|").Split('|');
        //                string[] temp2 = agendaPorHora[j].Replace("  //  ", "|").Split('|');

        //                if (Convert.ToDateTime(temp1[1].Trim()) > Convert.ToDateTime(temp2[1].Trim()))
        //                {
        //                    agendaPorDataHora[i] = agendaPorHora[j];
        //                    posicaoMenor = j;
        //                }
        //            }
        //        }

        //        //Exclui a menor data para não ser validado novamente
        //        agendaPorHora[posicaoMenor] = null;
        //    }
        //    #endregion

        //    return agendaPorDataHora;
        //}

        //public static string[] LayoutAgenda(string[] agendamentos)
        //{
        //    string[] temp, layout = new string[agendamentos.Length];
        //    int i = -1;
        //    int qtdEspacos;

        //    foreach (string item in agendamentos)
        //    {
        //        #region old
        //        /*
        //        i++;

        //        temp = item.Replace("  //  ", "|").Split('|');

        //        // Código do cliente
        //        if (temp[2].Trim().Length >= 4)
        //            temp[2] = temp[2].Trim().Substring(0, 4);
        //        else
        //        {
        //            qtdEspacos = 4 - temp[2].Trim().Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[2] = temp[2] + " ";
        //            }
        //        }

        //        //Nome do cliente
        //        if (temp[3].Length >= 25)
        //            temp[3] = temp[3].Trim().Substring(0, 25);
        //        else
        //        {
        //            qtdEspacos = 25 - temp[3].Trim().Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[3] = temp[3] + " ";
        //            }
        //        }

        //        //Telefone do cliente
        //        if (temp[4].Length >= 15)
        //            temp[4] = temp[4].Trim().Substring(0, 15);
        //        else
        //        {
        //            qtdEspacos = 15 - temp[4].Trim().Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[4] = temp[4] + " ";
        //            }
        //        }

        //        layout[i] = "  " + temp[1] + "  |  " + temp[2] + "  |  " + temp[3] + "  |  " + temp[4] + "  |  " + temp[5];
        //    }
        //    */
        //        #endregion

        //        i++;

        //        temp = item.Split('|');

        //        // Nome do Funcionário
        //        if (temp[3].Trim().Length >= 21)
        //            temp[3] = temp[3].Substring(0, 21);
        //        else
        //        {
        //            qtdEspacos = 21 - temp[3].Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[3] = temp[3] + " ";
        //            }
        //        }

        //        //Nome do cliente
        //        if (temp[5].Length >= 22)
        //            temp[5] = temp[5].Substring(0, 22);
        //        else
        //        {
        //            qtdEspacos = 22 - temp[5].Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[5] = temp[5] + " ";
        //            }
        //        }

        //        //Telefone do cliente
        //        if (temp[6].Length >= 17)
        //            temp[6] = temp[6].Substring(0, 17);
        //        else
        //        {
        //            qtdEspacos = 17 - temp[6].Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[6] = temp[6] + " ";
        //            }
        //        }

        //        layout[i] = "   " + temp[1].Trim() + "   |" + temp[3] + "  |" + temp[5] + "  |" + temp[6] + "  |  " + temp[7].Trim();
        //    }

        //    return layout;
        //}


        //public static string[] LayoutAgendaMes(string[] agendamentos)
        //{
        //    string[] temp, layout = new string[agendamentos.Length];
        //    int i = -1;
        //    int qtdEspacos;

        //    foreach (string item in agendamentos)
        //    {
        //        i++;

        //        temp = item.Split('|');

        //        // Nome do Funcionário
        //        if (temp[4].Trim().Length >= 24)
        //            temp[4] = temp[4].Substring(0, 24);
        //        else
        //        {
        //            qtdEspacos = 24 - temp[4].Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[4] = temp[4] + " ";
        //            }
        //        }

        //        //Nome do cliente
        //        if (temp[6].Length >= 25)
        //            temp[6] = temp[6].Substring(0, 25);
        //        else
        //        {
        //            qtdEspacos = 25 - temp[6].Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[6] = temp[6] + " ";
        //            }
        //        }

        //        //Telefone do cliente
        //        if (temp[7].Length >= 17)
        //            temp[7] = temp[7].Substring(0, 17);
        //        else
        //        {
        //            qtdEspacos = 17 - temp[7].Length;
        //            for (int j = 0; j < qtdEspacos; j++)
        //            {
        //                temp[7] = temp[7] + " ";
        //            }
        //        }

        //        layout[i] = "   " + temp[1].Trim() + "   |   " + temp[2].Trim() + "   |" + temp[4] + "  |" + temp[6] + "  |" + temp[7] + "  |  " + temp[8].Trim();
        //    }

        //    return layout;
        //}

        //public static void ExibeDiasSemana(ref Label lblDiaDom, ref Label lblDiaSeg, ref Label lblDiaTer, ref Label lblDiaQua, ref Label lblDiaQui,
        //                                   ref Label lblDiaSex, ref Label lblDiaSab)
        //{
        //    DateTime date = DateTime.Now;
        //    string hoje = date.DayOfWeek.ToString();
        //    string dia = date.ToString("dd");
        //    if (hoje == "Sunday")
        //    {
        //        lblDiaDom.Text = date.ToString("dd/MM/yyyy");
        //        lblDiaDom.BackColor = Color.Aquamarine;
        //        lblDiaSeg.Text = (date.AddDays(1)).ToString("dd/MM/yyyy");
        //        lblDiaTer.Text = (date.AddDays(2)).ToString("dd/MM/yyyy");
        //        lblDiaQua.Text = (date.AddDays(3)).ToString("dd/MM/yyyy");
        //        lblDiaQui.Text = (date.AddDays(4)).ToString("dd/MM/yyyy");
        //        lblDiaSex.Text = (date.AddDays(5)).ToString("dd/MM/yyyy");
        //        lblDiaSab.Text = (date.AddDays(6)).ToString("dd/MM/yyyy");
        //    }
        //    else if (hoje == "Monday")
        //    {
        //        lblDiaDom.Text = (date.AddDays(-1)).ToString("dd/MM/yyyy");
        //        lblDiaSeg.Text = date.ToString("dd/MM/yyyy");
        //        lblDiaSeg.BackColor = Color.Aquamarine; ;
        //        lblDiaTer.Text = (date.AddDays(1)).ToString("dd/MM/yyyy");
        //        lblDiaQua.Text = (date.AddDays(2)).ToString("dd/MM/yyyy");
        //        lblDiaQui.Text = (date.AddDays(3)).ToString("dd/MM/yyyy");
        //        lblDiaSex.Text = (date.AddDays(4)).ToString("dd/MM/yyyy");
        //        lblDiaSab.Text = (date.AddDays(5)).ToString("dd/MM/yyyy");
        //    }
        //    else if (hoje == "Tuesday")
        //    {
        //        lblDiaDom.Text = (date.AddDays(-2)).ToString("dd/MM/yyyy");
        //        lblDiaSeg.Text = (date.AddDays(-1)).ToString("dd/MM/yyyy");
        //        lblDiaTer.Text = date.ToString("dd/MM/yyyy");
        //        lblDiaTer.BackColor = Color.Aquamarine;
        //        lblDiaQua.Text = (date.AddDays(1)).ToString("dd/MM/yyyy");
        //        lblDiaQui.Text = (date.AddDays(2)).ToString("dd/MM/yyyy");
        //        lblDiaSex.Text = (date.AddDays(3)).ToString("dd/MM/yyyy");
        //        lblDiaSab.Text = (date.AddDays(4)).ToString("dd/MM/yyyy");
        //    }
        //    else if (hoje == "Wednesday")
        //    {
        //        lblDiaDom.Text = (date.AddDays(-3)).ToString("dd/MM/yyyy");
        //        lblDiaSeg.Text = (date.AddDays(-2)).ToString("dd/MM/yyyy");
        //        lblDiaTer.Text = (date.AddDays(-1)).ToString("dd/MM/yyyy");
        //        lblDiaQua.Text = date.ToString("dd/MM/yyyy");
        //        lblDiaQua.BackColor = Color.Aquamarine;
        //        lblDiaQui.Text = (date.AddDays(1)).ToString("dd/MM/yyyy");
        //        lblDiaSex.Text = (date.AddDays(2)).ToString("dd/MM/yyyy");
        //        lblDiaSab.Text = (date.AddDays(3)).ToString("dd/MM/yyyy");
        //    }
        //    else if (hoje == "Thursday")
        //    {
        //        lblDiaDom.Text = (date.AddDays(-4)).ToString("dd/MM/yyyy");
        //        lblDiaSeg.Text = (date.AddDays(-3)).ToString("dd/MM/yyyy");
        //        lblDiaTer.Text = (date.AddDays(-2)).ToString("dd/MM/yyyy");
        //        lblDiaQua.Text = (date.AddDays(-1)).ToString("dd/MM/yyyy");
        //        lblDiaQui.Text = date.ToString("dd/MM/yyyy");
        //        lblDiaQui.BackColor = Color.Aquamarine;
        //        lblDiaSex.Text = (date.AddDays(1)).ToString("dd/MM/yyyy");
        //        lblDiaSab.Text = (date.AddDays(2)).ToString("dd/MM/yyyy");
        //    }
        //    else if (hoje == "Friday")
        //    {
        //        lblDiaDom.Text = (date.AddDays(-5)).ToString("dd/MM/yyyy");
        //        lblDiaSeg.Text = (date.AddDays(-4)).ToString("dd/MM/yyyy");
        //        lblDiaTer.Text = (date.AddDays(-3)).ToString("dd/MM/yyyy");
        //        lblDiaQua.Text = (date.AddDays(-2)).ToString("dd/MM/yyyy");
        //        lblDiaQui.Text = (date.AddDays(-1)).ToString("dd/MM/yyyy");
        //        lblDiaSex.Text = date.ToString("dd/MM/yyyy");
        //        lblDiaSex.BackColor = Color.Aquamarine; ;
        //        lblDiaSab.Text = (date.AddDays(1)).ToString("dd/MM/yyyy");
        //    }
        //    else if (hoje == "Saturday")
        //    {
        //        lblDiaDom.Text = (date.AddDays(-6)).ToString("dd/MM/yyyy");
        //        lblDiaSeg.Text = (date.AddDays(-5)).ToString("dd/MM/yyyy");
        //        lblDiaTer.Text = (date.AddDays(-4)).ToString("dd/MM/yyyy");
        //        lblDiaQua.Text = (date.AddDays(-3)).ToString("dd/MM/yyyy");
        //        lblDiaQui.Text = (date.AddDays(-2)).ToString("dd/MM/yyyy");
        //        lblDiaSex.Text = (date.AddDays(-1)).ToString("dd/MM/yyyy");
        //        lblDiaSab.Text = date.ToString("dd/MM/yyyy");
        //        lblDiaSab.BackColor = Color.Aquamarine;
        //    }
        //}

        //public static ListaAgenda[] AlimentaListaAgenda(string[] agenda)
        //{
        //    ListaAgenda[] listaAgenda = new ListaAgenda[agenda.Length];
        //    int i = -1;

        //    foreach (string item in agenda)
        //    {
        //        i++;
        //        string[] temp = item.Split('|');

        //        listaAgenda[i].codInterno = Convert.ToInt32(temp[0].Trim());

        //        listaAgenda[i].data = Convert.ToDateTime(temp[1].Trim());

        //        listaAgenda[i].hora = Convert.ToDateTime(temp[2].Trim());

        //        if (temp[3].Trim() != "")
        //            listaAgenda[i].codigo = Convert.ToInt16(temp[3].Trim());
        //        else
        //            listaAgenda[i].codigo = -1;

        //        listaAgenda[i].nome = temp[4].Trim();

        //        if (temp[6].Trim() != "")
        //            listaAgenda[i].telcel = temp[6].Trim();
        //        else
        //            listaAgenda[i].telcel = "-";

        //        if (temp[7].Trim() != "")
        //            listaAgenda[i].obs = temp[7].Trim();
        //        else
        //            listaAgenda[i].obs = "-";

        //        if (temp[8].Trim() != "")
        //            listaAgenda[i].codFuncionario = Convert.ToInt32(temp[8].Trim());
        //        else
        //            listaAgenda[i].codFuncionario = -1;

        //        if (temp[9].Trim() != "")
        //            listaAgenda[i].nomeFuncionario = temp[9].Trim();
        //    }

        //    return listaAgenda;
        //}

        //public static void ValidaCliqueMes(ref Panel panJan, ref Panel panFev, ref Panel panMar, ref Panel panAbr, ref Panel panMai, ref Panel panJun,
        //                                   ref Panel panJul, ref Panel panAgo, ref Panel panSet, ref Panel panOut, ref Panel panNov, ref Panel panDez,
        //                                   ref Label lblJan, ref Label lblFev, ref Label lblMar, ref Label lblAbr, ref Label lblMai, ref Label lblJun,
        //                                   ref Label lblJul, ref Label lblAgo, ref Label lblSet, ref Label lblOut, ref Label lblNov, ref Label lblDez,
        //                                   string mes)
        //{
        //    if (mes == DateTime.Now.ToString("01/yyyy"))
        //    {
        //        panJan.BackColor = Color.Aquamarine;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.Aquamarine;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("02/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.Aquamarine;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.Aquamarine;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("03/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.Aquamarine;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.Aquamarine;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("04/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.Aquamarine;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.Aquamarine;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("05/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.Aquamarine;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.Aquamarine;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("06/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.Aquamarine;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.Aquamarine;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("07/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.Aquamarine;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.Aquamarine;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("08/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.Aquamarine;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.Aquamarine;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("09/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.Aquamarine;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.Aquamarine;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("10/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.Aquamarine;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.Aquamarine;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("11/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.Aquamarine;
        //        panDez.BackColor = Color.AliceBlue;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.Aquamarine;
        //        lblDez.BackColor = Color.AliceBlue;
        //    }
        //    else if (mes == DateTime.Now.ToString("12/yyyy"))
        //    {
        //        panJan.BackColor = Color.AliceBlue;
        //        panFev.BackColor = Color.AliceBlue;
        //        panMar.BackColor = Color.AliceBlue;
        //        panAbr.BackColor = Color.AliceBlue;
        //        panMai.BackColor = Color.AliceBlue;
        //        panJun.BackColor = Color.AliceBlue;
        //        panJul.BackColor = Color.AliceBlue;
        //        panAgo.BackColor = Color.AliceBlue;
        //        panSet.BackColor = Color.AliceBlue;
        //        panOut.BackColor = Color.AliceBlue;
        //        panNov.BackColor = Color.AliceBlue;
        //        panDez.BackColor = Color.Aquamarine;

        //        lblJan.BackColor = Color.AliceBlue;
        //        lblFev.BackColor = Color.AliceBlue;
        //        lblMar.BackColor = Color.AliceBlue;
        //        lblAbr.BackColor = Color.AliceBlue;
        //        lblMai.BackColor = Color.AliceBlue;
        //        lblJun.BackColor = Color.AliceBlue;
        //        lblJul.BackColor = Color.AliceBlue;
        //        lblAgo.BackColor = Color.AliceBlue;
        //        lblSet.BackColor = Color.AliceBlue;
        //        lblOut.BackColor = Color.AliceBlue;
        //        lblNov.BackColor = Color.AliceBlue;
        //        lblDez.BackColor = Color.Aquamarine;
        //    }
        //}

        //public static void AtualizaAgendados(ref ListBox ltbHoje,
        //                                     ref Label lblDiaDom, ref Label lblDiaSeg, ref Label lblDiaTer, ref Label lblDiaQua,
        //                                     ref Label lblDiaQui, ref Label lblDiaSex, ref Label lblDiaSab,
        //                                     ref ListBox ltbDom, ref ListBox ltbSeg, ref ListBox ltbTer, ref ListBox ltbQua, ref ListBox ltbQui,
        //                                     ref ListBox ltbSex, ref ListBox ltbSab,
        //                                     ref Panel panJan, ref Panel panFev, ref Panel panMar, ref Panel panAbr, ref Panel panMai, ref Panel panJun,
        //                                     ref Panel panJul, ref Panel panAgo, ref Panel panSet, ref Panel panOut, ref Panel panNov, ref Panel panDez,
        //                                     ref Label lblJan, ref Label lblFev, ref Label lblMar, ref Label lblAbr, ref Label lblMai, ref Label lblJun,
        //                                     ref Label lblJul, ref Label lblAgo, ref Label lblSet, ref Label lblOut, ref Label lblNov, ref Label lblDez,
        //                                     ref ListBox ltbMes)
        //{
        //    ExibeAgenda(ref ltbHoje);
        //    ExibeDiasSemana(ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua, ref lblDiaQui, ref lblDiaSex, ref lblDiaSab);
        //    ExibeAgendaDiaSemana("agenda.txt", ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui, ref ltbSex, ref ltbSab,
        //                         lblDiaDom, lblDiaSeg, lblDiaTer, lblDiaQua, lblDiaQui, lblDiaSex, lblDiaSab);
        //    ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
        //                                   ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
        //                                   ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
        //                                   ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
        //                                   DateTime.Now.ToString("MM/yyyy"));
        //    ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("MM/yyyy"));
        //}

        //public static void ExcluiAgendamento(string arquivoAgenda, int posicao,
        //                                     ref ListBox ltbHoje,
        //                                     ref Label lblDiaDom, ref Label lblDiaSeg, ref Label lblDiaTer, ref Label lblDiaQua,
        //                                     ref Label lblDiaQui, ref Label lblDiaSex, ref Label lblDiaSab,
        //                                     ref ListBox ltbDom, ref ListBox ltbSeg, ref ListBox ltbTer, ref ListBox ltbQua, ref ListBox ltbQui,
        //                                     ref ListBox ltbSex, ref ListBox ltbSab,
        //                                     ref Panel panJan, ref Panel panFev, ref Panel panMar, ref Panel panAbr, ref Panel panMai, ref Panel panJun,
        //                                     ref Panel panJul, ref Panel panAgo, ref Panel panSet, ref Panel panOut, ref Panel panNov, ref Panel panDez,
        //                                     ref Label lblJan, ref Label lblFev, ref Label lblMar, ref Label lblAbr, ref Label lblMai, ref Label lblJun,
        //                                     ref Label lblJul, ref Label lblAgo, ref Label lblSet, ref Label lblOut, ref Label lblNov, ref Label lblDez,
        //                                     ref ListBox ltbMes)
        //{
        //    #region Vairáveis
        //    CarregaArquivo arquivo = new CarregaArquivo();
        //    string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";
        //    string[] agenda = arquivo.Agenda("agenda.txt"), agendaHoje = arquivo.Agenda(arquivoAgenda), tempAgenda, tempAgendaHoje;
        //    string excluir;
        //    #endregion

        //    // Atualiza o arquivo agenda.txt
        //    File.WriteAllText(caminhoBD + "\\agenda.txt", null);
        //    foreach (string item in agenda)
        //    {
        //        tempAgenda = item.Split('|');
        //        tempAgendaHoje = agendaHoje[posicao].Split('|');

        //        if (tempAgenda[0].Trim() != tempAgendaHoje[0].Trim())
        //            File.AppendAllText(caminhoBD + "\\agenda.txt", item + Environment.NewLine, Encoding.Default);
        //    }

        //    // Exclui agendamento selecionado
        //    if (arquivoAgenda == "agenda_hoje.txt")
        //    {
        //        excluir = ltbHoje.SelectedItem.ToString();
        //        ltbHoje.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_mes.txt")
        //    {
        //        excluir = ltbMes.SelectedItem.ToString();
        //        ltbMes.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_dom.txt")
        //    {
        //        excluir = ltbDom.SelectedItem.ToString();
        //        ltbDom.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_seg.txt")
        //    {
        //        excluir = ltbSeg.SelectedItem.ToString();
        //        ltbSeg.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_ter.txt")
        //    {
        //        excluir = ltbTer.SelectedItem.ToString();
        //        ltbTer.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_qua.txt")
        //    {
        //        excluir = ltbQua.SelectedItem.ToString();
        //        ltbQua.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_qui.txt")
        //    {
        //        excluir = ltbQui.SelectedItem.ToString();
        //        ltbQui.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_sex.txt")
        //    {
        //        excluir = ltbSex.SelectedItem.ToString();
        //        ltbSex.Items.Remove(excluir);
        //    }
        //    else if (arquivoAgenda == "agenda_sab.txt")
        //    {
        //        excluir = ltbSab.SelectedItem.ToString();
        //        ltbSab.Items.Remove(excluir);
        //    }


        //    //Atualiza todas as ListBox e seus respectivos arquivos .txt
        //    AtualizaAgendados(ref ltbHoje,
        //                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
        //                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
        //                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
        //                      ref ltbSex, ref ltbSab,
        //                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
        //                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
        //                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
        //                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
        //                      ref ltbMes);
        //}
        //#endregion

        #endregion

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
            panTopSemana.Visible = Enum_TipoExibicaoAgenda.semana == p_enum_frAgendados;

            panMesContainer.Visible = Enum_TipoExibicaoAgenda.mes == p_enum_frAgendados;
            panTopMes.Visible = Enum_TipoExibicaoAgenda.mes == p_enum_frAgendados;

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
                agendaDomingo.Atualiza_listAgenda(domingo, domingo, 'P', 'C', 'N');
                agendaSegunda.Atualiza_listAgenda(segunda, segunda, 'P', 'C', 'N');
                agendaTerca.Atualiza_listAgenda(terca, terca, 'P', 'C', 'N');
                agendaQuarta.Atualiza_listAgenda(quarta, quarta, 'P', 'C', 'N');
                agendaQuinta.Atualiza_listAgenda(quinta, quinta, 'P', 'C', 'N');
                agendaSexta.Atualiza_listAgenda(sexta, sexta, 'P', 'C', 'N');
                agendaSabado.Atualiza_listAgenda(sabado, sabado, 'P', 'C', 'N');
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

        /*
        #region Eventos
        #region Click Panel e Label meses
        #region Janeiro
        private void panJan_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("01/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("01/yyyy"));
        }

        private void lblJan_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("01/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("01/yyyy"));
        }
        #endregion

        #region Fevereiro
        private void panFev_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("02/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("02/yyyy"));
        }

        private void lblFev_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("02/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("02/yyyy"));
        }
        #endregion

        #region Março
        private void panMar_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("03/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("03/yyyy"));
        }

        private void lblMar_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("03/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("03/yyyy"));
        }
        #endregion

        #region Abril
        private void panAbr_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("04/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("04/yyyy"));
        }

        private void lblAbr_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("04/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("04/yyyy"));
        }

        #endregion

        #region Maio
        private void panMai_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("05/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("05/yyyy"));
        }

        private void lblMai_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("05/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("05/yyyy"));
        }
        #endregion

        #region Junho
        private void panJun_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("06/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("06/yyyy"));
        }

        private void lblJun_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("06/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("06/yyyy"));
        }
        #endregion

        #region Julho
        private void panJul_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("07/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("07/yyyy"));
        }

        private void lblJul_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("07/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("07/yyyy"));
        }
        #endregion

        #region Agosto
        private void panAgo_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("08/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("08/yyyy"));
        }

        private void lblAgo_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("08/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("08/yyyy"));
        }
        #endregion

        #region Setembro
        private void panSet_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("09/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("09/yyyy"));
        }

        private void lblSet_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("09/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("09/yyyy"));
        }
        #endregion

        #region Outubro
        private void panOut_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("10/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("10/yyyy"));
        }

        private void lblOut_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("10/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("10/yyyy"));
        }
        #endregion

        #region Novembro
        private void panNov_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("11/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("11/yyyy"));
        }

        private void lblNov_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("11/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("11/yyyy"));
        }
        #endregion

        #region Dezembro
        private void panDez_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                                       ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                                       ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                                       ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                                       DateTime.Now.ToString("12/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("12/yyyy"));
        }

        private void lblDez_Click(object sender, EventArgs e)
        {
            ValidaCliqueMes(ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                           ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                           ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                           ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                           DateTime.Now.ToString("12/yyyy"));
            ExibeAgendaMes(ref ltbMes, DateTime.Now.ToString("12/yyyy"));
        }

        #endregion
        #endregion

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (ltbHoje.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbHoje.SelectedIndex.ToString().Trim() + "|agenda_hoje.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbDom.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbDom.SelectedIndex.ToString().Trim() + "|agenda_dom.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbSeg.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbSeg.SelectedIndex.ToString().Trim() + "|agenda_seg.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbTer.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbTer.SelectedIndex.ToString().Trim() + "|agenda_ter.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbQua.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbQua.SelectedIndex.ToString().Trim() + "|agenda_qua.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbQui.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbQui.SelectedIndex.ToString().Trim() + "|agenda_qui.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbSex.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbSex.SelectedIndex.ToString().Trim() + "|agenda_sex.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbSab.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbSab.SelectedIndex.ToString().Trim() + "|agenda_sab.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
            }
            else if (ltbMes.SelectedIndex != -1)
            {
                File.WriteAllText(caminhoBD + "\\agendamento.txt", ltbMes.SelectedIndex.ToString().Trim() + "|agenda_mes.txt", Encoding.Default);
                frAgendamento Agendamento = new frAgendamento();
                Agendamento.ShowDialog();
                File.WriteAllText(caminhoBD + "\\agendamento.txt", null);
                if (Agendamento.exibir)
                    AtualizaAgendados(ref ltbHoje,
                                          ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                          ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                          ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                          ref ltbSex, ref ltbSab,
                                          ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                          ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                          ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                          ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                          ref ltbMes);
            }
        }

        private void btnNovoCad_Click(object sender, EventArgs e)
        {
            frAgendamento Agendamento = new frAgendamento();
            Agendamento.ShowDialog();
            if (Agendamento.exibir)
                AtualizaAgendados(ref ltbHoje,
                                      ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                      ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                      ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                      ref ltbSex, ref ltbSab,
                                      ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                      ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                      ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                      ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                      ref ltbMes);
        }

        #region Valida Cliques Agendados
        private void ltbDom_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;
            ltbMes.SelectedIndex = -1;

            ltbSeg.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }

        private void ltbSeg_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;
            ltbMes.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }

        private void ltbTer_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;
            ltbMes.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbSeg.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }

        private void ltbQua_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;
            ltbMes.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbSeg.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }

        private void ltbQui_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;
            ltbMes.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbSeg.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }

        private void ltbSex_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;
            ltbMes.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbSeg.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }

        private void ltbSab_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;
            ltbMes.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbSeg.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
        }

        private void ltbHoje_Click(object sender, EventArgs e)
        {
            ltbMes.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbSeg.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }

        private void ltbMes_Click(object sender, EventArgs e)
        {
            ltbHoje.SelectedIndex = -1;

            ltbDom.SelectedIndex = -1;
            ltbSeg.SelectedIndex = -1;
            ltbTer.SelectedIndex = -1;
            ltbQua.SelectedIndex = -1;
            ltbQui.SelectedIndex = -1;
            ltbSex.SelectedIndex = -1;
            ltbSab.SelectedIndex = -1;
        }
        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ltbHoje.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_hoje.txt", ltbHoje.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbDom.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_dom.txt", ltbDom.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbSeg.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_Seg.txt", ltbSeg.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbTer.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_Ter.txt", ltbTer.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbQua.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_Qua.txt", ltbQua.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbQui.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_qui.txt", ltbQui.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbSex.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_sex.txt", ltbSex.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbSab.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_sab.txt", ltbSab.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
            else if (ltbMes.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja excluir o agendamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluiAgendamento("agenda_mes.txt", ltbMes.SelectedIndex,
                                  ref ltbHoje,
                                  ref lblDiaDom, ref lblDiaSeg, ref lblDiaTer, ref lblDiaQua,
                                  ref lblDiaQui, ref lblDiaSex, ref lblDiaSab,
                                  ref ltbDom, ref ltbSeg, ref ltbTer, ref ltbQua, ref ltbQui,
                                  ref ltbSex, ref ltbSab,
                                  ref panJan, ref panFev, ref panMar, ref panAbr, ref panMai, ref panJun,
                                  ref panJul, ref panAgo, ref panSet, ref panOut, ref panNov, ref panDez,
                                  ref lblJan, ref lblFev, ref lblMar, ref lblAbr, ref lblMai, ref lblJun,
                                  ref lblJul, ref lblAgo, ref lblSet, ref lblOut, ref lblNov, ref lblDez,
                                  ref ltbMes);
                }
                else
                    return;
            }
        }
        #endregion
        */
    }
}
