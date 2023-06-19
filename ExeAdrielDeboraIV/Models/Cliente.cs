using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace ExeAdrielDeboraIV.Models
{
    public class Cliente
    {

        [DisplayName("Código do Cliente")]
        [Range(1, 500, ErrorMessage = "O código deve ser maior que zero")]
        [Required(ErrorMessage = "O código é obrigatório")]
        public int IdCli { get; set; }


        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string NomeCLi { get; set; }

        //[RegularExpression(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2}))", 
        //    ErrorMessage = "O campo deve conter no máximo 15 caracteres")]
        [Required(ErrorMessage = "Informe o CPF")]
        public int CPF { get; set; }


        [EmailAddress]
        [DisplayName("E_mail")]
        [Required(ErrorMessage = "O email é obrigatório")]
        //[RegularExpression(@"/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$/i",
        //    ErrorMessage = "Digite um email válido")]
        public string Email { get; set;}

        [System.Web.Mvc.Remote("SelectCadastro", "Cliente", ErrorMessage = "Este Login já existe!")]
        [RegularExpression(@"[a-zA-ZçÇ0-9]{6,15}",
            ErrorMessage = "O campo deve conter no máximo 15 caracteres")]
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set;}

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set;}

        [DataType(DataType.Password)]
        [DisplayName("Confirme a senha")]
        [System.Web.Mvc.Compare("Senha", ErrorMessage = "As senhas são diferentes.")]
        public string ConfirmarSenha { get; set; }

      
        [DataType(DataType.Date)]
        public DateTime DataCadastro  { get; set;}
    }
}