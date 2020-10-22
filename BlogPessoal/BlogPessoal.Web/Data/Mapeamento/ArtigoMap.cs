using BlogPessoal.Web.Models.Artigos;
using System.Data.Entity.ModelConfiguration;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class ArtigoMap : EntityTypeConfiguration<Artigo>
    {
        public ArtigoMap()
        {
            ToTable("artigo", "dbo");
            HasKey(x => x.Id);

            Property(x => x.Titulo).IsRequired().HasMaxLength(300);
            Property(x => x.Conteudo).IsRequired();
            Property(x => x.DataPublicacao).IsRequired().HasColumnName("data_publicacao");
            Property(x => x.CategoriaDeArtigoId).IsRequired().HasColumnName("categoria_artigo_id");
            Property(x => x.AutorId).IsRequired().HasColumnName("autor_id");
            Property(x => x.Removido).IsRequired();

            HasRequired(t => t.CategoriaDeArtigo)
                .WithMany(t => t.Artigos)
                .HasForeignKey(t => t.CategoriaDeArtigoId)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.Autor)
               .WithMany(t => t.Artigos)
               .HasForeignKey(t => t.AutorId)
               .WillCascadeOnDelete(false);
        }
    }
}