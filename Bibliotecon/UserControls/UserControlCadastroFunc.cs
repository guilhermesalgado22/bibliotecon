using Bibliotecon.Dto;
using Bibliotecon.Models;
using Bibliotecon.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotecon
{
    public partial class UserControlCadastroFunc : UserControl
    {
        public UserControlCadastroFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var cadastrarLeitorRequest = new CadastrarLeitorRequest
            {
                Nome = textBox13.Text,
                Endereco = textBox3.Text,
                Cidade = textBox5.Text,
                Telefone = textBox6.Text,
                Bairro = textBox2.Text,
                Sexo = textBox7.Text,
                DataNascimento = DateOnly.ParseExact(textBox9.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                CPF = textBox1.Text,
                RG = textBox10.Text,
                Status = true,
            };


            var service = new LeitorService(new DemoDbContext());
            var response = await service.InserirLeitorAsync(cadastrarLeitorRequest);

            if (response.CodLeitor > 0)
            {
                MessageBox.Show("Leitor cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar leitor");
            }
        }
    }
}
