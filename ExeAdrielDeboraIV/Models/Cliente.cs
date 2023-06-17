using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExeAdrielDeboraIV.Models
{
    public class Cliente
    {

        [DisplayName("Código")]
        [Range(1, 500, ErrorMessage = "O código deve ser maior que zero")]
        [Required(ErrorMessage = "O código é obrigatório")]
        public int IdCli { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string NomeCLi { get; set; }

        [Required(ErrorMessage = "Informe o CPF")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set;}

        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set;}

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set;}

        public DateTime DataCadastro  { get; set;}
    }
}