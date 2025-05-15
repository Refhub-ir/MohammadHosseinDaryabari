using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Refhub.Data.Models;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(c => c.Books)
            .WithOne(c => c.Category)
            .HasForeignKey(c => c.CategoryId);
    }
}
