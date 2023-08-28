using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RegOffice.DataModel.Model;

namespace RegOffice.DataModel.Model
{
//    public partial class PostgreeSqlContext : DbContext
//    {
//        public virtual DbSet<ProductTariff> ProductTariffs { get; set; }

//        public PostgreeSqlContext()
//        {
//        }

//        public PostgreeSqlContext(DbContextOptions<PostgreeSqlContext> options) : base(options)
//        {
//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseNpgsql("Host=192.168.1.56;Database=regofficex;Username=registrator;Password=ujhdjgajr");
//            }
//        }

//        partial void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasPostgresExtension("pathman", "pg_pathman")
//                .HasPostgresExtension("dblink");

//            modelBuilder.Entity<ProductTariff>(entity =>
//            {
//                entity.HasKey(e => new { e.ContractTariffId, e.ProductId })
//                    .HasName("pk_product_tariff");

//                entity.ToTable("ro_product_tariff");

//                entity.HasAnnotation("Relational:Comment", "Таблица услуг продукта");

//                entity.HasIndex(e => e.ContractTariffId, "product_tariff_contract_tariff_id_idx");

//                entity.HasIndex(e => e.ProductId, "product_tariff_product_id_idx");

//                entity.Property(e => e.ContractTariffId)
//                    .HasColumnName("contract_tariff_id")
//                    .HasComment("Услуга по договору");

//                entity.Property(e => e.ProductId)
//                    .HasColumnName("product_id")
//                    .HasComment("Продукт");
//            });

//            modelBuilder.Entity<ProlongationShortDatum>(entity =>
//            {
//                entity.HasKey(e => e.ProlongationId)
//                    .HasName("ro_prolongation_short_data_pkey");

//                entity.ToTable("ro_prolongation_short_data");

//                entity.HasAnnotation("Relational:Comment", "Таблица для вкладки \"Работа с продлениями\"");

//                entity.HasIndex(e => e.CertificateInitialDate, "certificate_initial_date_idx");

//                entity.HasIndex(e => e.AbonentId, "prolongation_short_data_abonent_id_idx");

//                entity.HasIndex(e => e.CertificateEndDate, "prolongation_short_data_certificate_end_date_idx");

//                entity.HasIndex(e => e.ContractId, "prolongation_short_data_contract_id_idx");

//                entity.HasIndex(e => new { e.ContractId, e.ProductId }, "prolongation_short_data_contract_product_idx")
//                    .IsUnique();

//                entity.HasIndex(e => e.ProductId, "prolongation_short_data_product_idx");

//                entity.HasIndex(e => e.TariffEndDate, "prolongation_short_data_tariff_end_date_idx");

//                entity.HasIndex(e => e.TariffInitialDate, "tariff_initial_date_idx");

//                entity.Property(e => e.ProlongationId)
//                    .HasColumnName("prolongation_id")
//                    .HasComment("Идентификатор продления");

//                entity.Property(e => e.AbonentId)
//                    .HasColumnName("abonent_id")
//                    .HasComment("Идентификатор абонента");

//                entity.Property(e => e.CertificateEndDate)
//                    .HasColumnName("certificate_end_date")
//                    .HasComment("Дата окончания сертификата");

//                entity.Property(e => e.CertificateInitialDate)
//                    .HasColumnName("certificate_initial_date")
//                    .HasComment("Дата начала сертификата");

//                entity.Property(e => e.Comment)
//                    .HasColumnType("character varying")
//                    .HasColumnName("comment")
//                    .HasComment("Комментарий");

//                entity.Property(e => e.ContractId)
//                    .HasColumnName("contract_id")
//                    .HasComment("Идентификатор договора");

//                entity.Property(e => e.IgnoreDispatch)
//                    .HasColumnName("ignore_dispatch")
//                    .HasComment("Флаг определяет необходимость проверки наличия отправок абонента");

//                entity.Property(e => e.NoDispatch)
//                    .HasColumnName("no_dispatch")
//                    .HasComment("Флаг определяет факт отсутствия отправок в ФНС/ПФР при наличии соответсвующих направлений");

//                entity.Property(e => e.ProductId)
//                    .HasColumnName("product_id")
//                    .HasComment("Идентификатор продукта");

//                entity.Property(e => e.ReasonId)
//                    .HasColumnName("reason_id")
//                    .HasComment("Причина непродления абонента");

//                entity.Property(e => e.RegistrationNumber)
//                    .HasMaxLength(255)
//                    .HasColumnName("registration_number")
//                    .HasComment("Рег. номер продукта");

//                entity.Property(e => e.TariffEndDate)
//                    .HasColumnName("tariff_end_date")
//                    .HasComment("Дата окончания тарифа");

//                entity.Property(e => e.TariffInitialDate)
//                    .HasColumnName("tariff_initial_date")
//                    .HasComment("Дата начала тарифа");

//                entity.Property(e => e.TotalSum)
//                    .HasColumnName("total_sum")
//                    .HasComment("Общая стоимость");

//                entity.Property(e => e.TransferDate)
//                    .HasColumnName("transfer_date")
//                    .HasComment("Дата переноса");
//            });

//            modelBuilder.HasSequence("ro_issuer_issuer_id_seq");

//            modelBuilder.HasSequence("ro_log_type_log_type_id_seq").HasMax(2147483647);

//            modelBuilder.HasSequence("ro_potential_abonent_trading_platform_id_seq");

//            modelBuilder.HasSequence("ro_potential_abonent_trading_platform_type_id_seq");

//            modelBuilder.HasSequence("ro_price_tax_price_id_seq");

//            modelBuilder.HasSequence("ro_tariff_tariff_id_seq");

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
}
