using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Boolean Sexo { get; set; }
    }
}