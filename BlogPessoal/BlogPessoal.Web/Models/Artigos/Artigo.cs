using BlogPessoal.Web.Models.Autores;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models.Artigos
{
    public class Artigo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Conteúdo")]
        [DataType(DataType.MultilineText)]
        public string Conteudo { get; set; }

        [Required]
        [Display(Name = "Data de Publicação")]
        public DateTime DataPublicacao { get; set; }

        [Required]
        public int CategoriaDeArtigoId { get; set; }

        [Required]
        public int AutorId { get; set; }

        [Required]
        public bool Removido { get; set; }

        public virtual CategoriaDeArtigo CategoriaDeArtigo { get; set; }
        public virtual Autor Autor { get; set; }
    }
}