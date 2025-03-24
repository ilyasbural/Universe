﻿namespace Universe.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserEducationConfiguration : IEntityTypeConfiguration<UserEducation>
    {
        public void Configure(EntityTypeBuilder<UserEducation> builder)
        {
            builder.Property(e => e.Id);
            builder.Property(x => x.RegisterDate).HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnType("DATETIME");
            builder.Property(e => e.IsActive);
            builder.ToTable("UserEducation");
        }
    }
}