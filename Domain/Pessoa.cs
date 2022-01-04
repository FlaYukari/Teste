﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(2000)]
        [Required]
        public string Endereco { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        [Phone]
        public int Telefone { get; set; }
        [Required]
        [Phone]
        public int Celular { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        //[RegexStringValidator(@"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$")]
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Boolean Sexo { get; set; }
    }
}

