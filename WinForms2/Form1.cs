using Domain;
using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = "Pessoa teste DevMedia",
                Endereco = "Rua Santos, 100",
                Celular = 9 - 9999 - 9999,
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
