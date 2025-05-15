using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Refhub.Data.Models;

public class BookKeywordConfiguration : IEntityTypeConfiguration<BookKeyword>
{
    public void Configure(EntityTypeBuilder<BookKeyword> builder)
    {
        builder.HasKey(bk => new { bk.BookId, bk.KeywordId });

        builder.HasOne(bk => bk.Book)
               .WithMany(b => b.BookKeywords)
               .HasForeignKey(bk => bk.BookId);

        builder.HasOne(bk => bk.Keyword)
               .WithMany(k => k.BookKeywords)
               .HasForeignKey(bk => bk.KeywordId);
    }
}
