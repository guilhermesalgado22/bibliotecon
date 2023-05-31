using Bibliotecon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotecon
{
    public partial class UserControlConsultaSelecao : UserControl
    {
        public UserControlConsultaSelecao()
        {
            InitializeComponent();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consulta_Emprestimo_click(object sender, EventArgs e)
        {
            ConsultaEmprestimo consultaEmprestimo = new ConsultaEmprestimo();
            consultaEmprestimo.Show();
        }

        private void Consultar_Devolucao_Click(object sender, EventArgs e)
        {
            ConsultarDevolucao consultarDevolucao = new ConsultarDevolucao();
            consultarDevolucao.Show();
        }

        private void Consultar_Livros_Click(object sender, EventArgs e)
        {
            ConsultarLivros consultarLivros = new ConsultarLivros();
            consultarLivros.Show();
        }

        private void Consultar_Funcionario_Click(object sender, EventArgs e)
        {
            ConsultarLeitor consultarFuncionario = new ConsultarLeitor();
            consultarFuncionario.Show();

        }

        private void Consultar_Reservas_Click(object sender, EventArgs e)
        {
            ConsultarReservas consultarReservas = new ConsultarReservas();
            consultarReservas.Show();
        }

        private void UserControlConsultaSelecao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaExemplar consultareexemplar = new ConsultaExemplar();
            consultareexemplar.Show();
        }
    }
}
