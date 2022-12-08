using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration;

class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.FirstName)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(u => u.LastName)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(u => u.Patronymic)
            .HasMaxLength(30);

        builder.Property(u => u.DateOfBirthd)
            .HasColumnType("datetime")
            .HasDefaultValueSql("GETDATE()")
            .IsRequired();

        builder.Property(u => u.Created)
            .HasColumnType("datetime")
            .HasDefaultValueSql("GETDATE()")
            .IsRequired();
    }
}