﻿namespace Universe.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserNetworkConfiguration : IEntityTypeConfiguration<UserNetwork>
    {
        public void Configure(EntityTypeBuilder<UserNetwork> builder)
        {
            builder.Property(e => e.Id);
            builder.Property(x => x.RegisterDate).HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnType("DATETIME");
            builder.Property(e => e.IsActive);
            builder.ToTable("UserNetwork");
        }
    }
}