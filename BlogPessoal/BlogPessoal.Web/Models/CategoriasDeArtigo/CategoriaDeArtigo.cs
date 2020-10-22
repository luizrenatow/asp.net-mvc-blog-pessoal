using BlogPessoal.Web.Models.Artigos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models
{
    public class CategoriaDeArtigo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}