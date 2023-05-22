using Bibliotecon.Dto;
using Bibliotecon.Interfaces;
using Bibliotecon.Models;
using Bibliotecon.Services;

namespace Bibliotecon
{
    public partial class UserControlCadLivros : UserControl
    {

       

        private ILivroService _livroService;


        public UserControlCadLivros(ILivroService livroService)
        {
            _livroService = livroService;
        }


        public UserControlCadLivros()
        {
            _livroService = new LivroService(new DemoDbContext());
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var livroService = new LivroService(new DemoDbContext());
            var livro = new CadastroLivroRequest
            {
                Titulo = textBox1.Text,
                Autor = textBox5.Text,
                Editora = textBox7.Text,
                AnoPublicacao = Convert.ToInt32(textBox3.Text),
                Categoria = textBox2.Text,
                Status = true
            };
            var response = await _livroService.InserirLivroAsync(livro);
            MessageBox.Show($"Livro cadastrado com sucesso!\nCódigo do livro: {response.CodLivro}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlCadLivros_Load(object sender, EventArgs e)
        {

        }
    }
}
