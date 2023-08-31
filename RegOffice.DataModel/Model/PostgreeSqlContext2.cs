using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegOffice.DataModel.Model
{
    public partial class PostgreeSqlContext : DbContext
    {
        public virtual DbSet<ProductTariff> ProductTariffs { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductTariff>(entity =>
            {
                entity.HasKey(e => new { e.ContractTariffId, e.ProductId })
                    .HasName("pk_product_tariff");

                entity.ToTable("ro_product_tariff");

                entity.HasAnnotation("Relational:Comment", "Таблица услуг продукта");

                entity.HasIndex(e => e.ContractTariffId, "product_tariff_contract_tariff_id_idx");

                entity.HasIndex(e => e.ProductId, "product_tariff_product_id_idx");

                entity.Property(e => e.ContractTariffId)
                    .HasColumnName("contract_tariff_id")
                    .HasComment("Услуга по договору");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasComment("Продукт");
            });
        }
    }
}
