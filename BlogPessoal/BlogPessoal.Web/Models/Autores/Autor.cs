using BlogPessoal.Web.Models.Artigos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models.Autores
{
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "E-mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "O e-mail informado é inválido.")]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        public bool Administrador { get; set; }

        [Required]
        [Display(Name = "Data de Cadastro")]
        public DateTime DataDeCadastro { get; set; }

        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}