﻿namespace Universe.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManagementEmailConfiguration : IEntityTypeConfiguration<ManagementEmail>
    {
        public void Configure(EntityTypeBuilder<ManagementEmail> builder)
        {
            builder.Property(e => e.Id);
            builder.Property(x => x.RegisterDate).HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnType("DATETIME");
            builder.Property(e => e.IsActive);
            builder.ToTable("ManagementEmail");
        }
    }
}