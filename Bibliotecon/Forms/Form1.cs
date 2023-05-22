using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotecon.Interfaces;
using Bibliotecon.Dto;
    using Bibliotecon.Models;


namespace Bibliotecon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Cadastrar_Livros_Click(object sender, EventArgs e)
        {
            ExibirCadastroLivros();
        }

        private void ExibirCadastroLivros()
        {
            
            panel4.Controls.Clear();
            UserControlCadLivros CadastroLivrosControl = new UserControlCadLivros();
            panel4.Controls.Add(CadastroLivrosControl);
            CadastroLivrosControl.Dock = DockStyle.None;
            CadastroLivrosControl.AutoSize = true;
            CadastroLivrosControl.Anchor = AnchorStyles.None;
            CadastroLivrosControl.Location = new Point((panel4.Width - CadastroLivrosControl.Width) / 2,
                                                        (panel4.Height - CadastroLivrosControl.Height) / 2);
            //InitializeComponent();
        }

       private void MainForm_Resize_Livros(object sender, EventArgs e)
        {
          ExibirCadastroLivros();
        }
        private void Cadastrar_Leitor_Click(object sender, EventArgs e)
        {
            ExibirCadastroUser();
        }
        private void ExibirCadastroUser()
        {
            panel4.Controls.Clear();
            UserControlCadastroFunc CadastroUserControl = new UserControlCadastroFunc();
            panel4.Controls.Add(CadastroUserControl);
            CadastroUserControl.Dock = DockStyle.None;
            CadastroUserControl.AutoSize = true;
            CadastroUserControl.Anchor = AnchorStyles.None;
            CadastroUserControl.Location = new Point((panel4.Width - CadastroUserControl.Width) / 2,
                                                     (panel4.Height - CadastroUserControl.Height) / 2);
        }

        private void MainForm_Resize_Cadastro(object sender, EventArgs e)
        {
            ExibirCadastroUser();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarReservas_Click(object sender, EventArgs e)
        {
            ExibirCadastroReservas();
        }

        private void ExibirCadastroReservas()
        {
            panel4.Controls.Clear();
            UserControlReserva CadastroReservasUserControl = new UserControlReserva();
            panel4.Controls.Add(CadastroReservasUserControl);
            CadastroReservasUserControl.Dock = DockStyle.None;
            CadastroReservasUserControl.AutoSize = true;
            CadastroReservasUserControl.Anchor = AnchorStyles.None;
            CadastroReservasUserControl.Location = new Point((panel4.Width - CadastroReservasUserControl.Width) / 2,
                                                             (panel4.Height - CadastroReservasUserControl.Height) / 2);
        }

        private void MainForm_Resize_Reservas(object sender, EventArgs e)
        {
            ExibirCadastroReservas();
        }

        private void Cadastrar_Emprestimo_Click(object sender, EventArgs e)
        {
            ExibirCadastroEmprestimo();
        }

        private void ExibirCadastroEmprestimo()
        {
            panel4.Controls.Clear();
            UserControlEmprestimo CadastroEmprestimoUserControl = new UserControlEmprestimo();
            panel4.Controls.Add(CadastroEmprestimoUserControl);
            CadastroEmprestimoUserControl.Dock = DockStyle.None;
            CadastroEmprestimoUserControl.AutoSize = true;
            CadastroEmprestimoUserControl.Anchor = AnchorStyles.None;
            CadastroEmprestimoUserControl.Location = new Point((panel4.Width - CadastroEmprestimoUserControl.Width) / 2,
                                                               (panel4.Height - CadastroEmprestimoUserControl.Height) / 2);
        }

        private void MainForm_Resize_Emprestimo(object sender, EventArgs e)
        {
            ExibirCadastroEmprestimo();
        }

        private void Cadastrar_Devolucao_Click(object sender, EventArgs e)
        {
            ExibirCadastroDevolucao();
        }

        private void ExibirCadastroDevolucao()
        {
            panel4.Controls.Clear();
            UserControlDevolucao CadastroDevolucaoUserControl = new UserControlDevolucao();
            panel4.Controls.Add(CadastroDevolucaoUserControl);
            CadastroDevolucaoUserControl.Dock = DockStyle.None;
            CadastroDevolucaoUserControl.AutoSize = true;
            CadastroDevolucaoUserControl.Anchor = AnchorStyles.None;
            CadastroDevolucaoUserControl.Location = new Point((panel4.Width - CadastroDevolucaoUserControl.Width) / 2,
                                                              (panel4.Height - CadastroDevolucaoUserControl.Height) / 2);
        }

        private void MainForm_Resize_Devolucao(object sender, EventArgs e)
        {
            ExibirCadastroDevolucao();
        }

        private void Consultar_Selecao_Click(object sender, EventArgs e)
        {
            ExibirConsultaSelecao();
        }

        private void ExibirConsultaSelecao()
        {
            panel4.Controls.Clear();
            UserControlConsultaSelecao ConsultaSelecaoUserControl = new UserControlConsultaSelecao();
            panel4.Controls.Add(ConsultaSelecaoUserControl);
            ConsultaSelecaoUserControl.Dock = DockStyle.None;
            ConsultaSelecaoUserControl.AutoSize = true;
            ConsultaSelecaoUserControl.Anchor = AnchorStyles.None;
            ConsultaSelecaoUserControl.Location = new Point((panel4.Width - ConsultaSelecaoUserControl.Width) / 2,
                                                            (panel4.Height - ConsultaSelecaoUserControl.Height) / 2);
        }

        private void MainForm_Resize_ConsultaSelecao(object sender, EventArgs e)
        {
            ExibirConsultaSelecao();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastrar_Exemplar_Click(object sender, EventArgs e)
        {
           ExibirCadastroExemplar();
        }

            private void ExibirCadastroExemplar()
            {
                panel4.Controls.Clear();
                UserControlCadastroExemplar CadastroExemplarControl = new UserControlCadastroExemplar();
                panel4.Controls.Add(CadastroExemplarControl);
                CadastroExemplarControl.Dock = DockStyle.None;
                CadastroExemplarControl.AutoSize = true;
                CadastroExemplarControl.Anchor = AnchorStyles.None;
                CadastroExemplarControl.Location = new Point((panel4.Width - CadastroExemplarControl.Width) / 2,
                                                            (panel4.Height - CadastroExemplarControl.Height) / 2);
            }

            private void MainForm_Resize_Exemplar(object sender, EventArgs e)
            {
                ExibirCadastroExemplar();
            }
        }
}

