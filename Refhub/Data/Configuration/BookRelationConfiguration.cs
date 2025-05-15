using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Refhub.Data.Models;

public class BookRelationConfiguration : IEntityTypeConfiguration<BookRelation>
{
    public void Configure(EntityTypeBuilder<BookRelation> builder)
    {
        builder.HasKey(br => new { br.BookId, br.RelatedBookId });

        builder.HasOne(br => br.Book)
               .WithMany(b => b.RelatedTo)
               .HasForeignKey(br => br.BookId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(br => br.RelatedBook)
               .WithMany(b => b.RelatedFrom)
               .HasForeignKey(br => br.RelatedBookId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
