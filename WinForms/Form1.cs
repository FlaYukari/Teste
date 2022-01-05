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
                Endereco = "Rua Santos, 100",
                Celular = 9-9999-9999,
                Email = "xxx.yyyy@hotmail.com"
            };
            context.Pessoas.Add(pessoa);

            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = context.Pessoas.Find(3);
        }
    }
}
