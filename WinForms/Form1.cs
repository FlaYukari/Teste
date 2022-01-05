using Data;
using Domain;
using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private PessoaDBContext context;

        public Form1()
        {
            InitializeComponent();

            context = new PessoaDBContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = "Pessoa teste DevMedia",
                Endereco = "Rua Augusto Jesus, 103"
            };
            context.Pessoas.Add(pessoa);

            context.SaveChanges();
        }
    }
}
