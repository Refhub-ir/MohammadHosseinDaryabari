﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refhub.Data.Models;

public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
{
    public void Configure(EntityTypeBuilder<BookAuthor> builder)
    {
        builder.HasKey(ba => new { ba.BookId, ba.AuthorId });

        builder.HasOne(ba => ba.Book)
               .WithMany(b => b.BookAuthors)
               .HasForeignKey(ba => ba.BookId);

        builder.HasOne(ba => ba.Author)
               .WithMany(a => a.BookAuthors)
               .HasForeignKey(ba => ba.AuthorId);
    }
}
