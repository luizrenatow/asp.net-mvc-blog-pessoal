using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models
{
    public class CategoriaDeArtigo
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

    }
}