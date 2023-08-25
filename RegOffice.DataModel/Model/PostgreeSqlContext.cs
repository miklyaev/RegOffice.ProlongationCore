using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegOffice.DataModel.Model
{
    public partial class PostgreeSqlContext : DbContext
    {
        public virtual DbSet<Abonent> Abonents { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<ContractTariff> ContractTariffs { get; set; }
        public virtual DbSet<ContractTariffExtension> ContractTariffExtensions { get; set; }
        public virtual DbSet<Key> Keys { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPerson> ProductPeoples { get; set; }
        public virtual DbSet<ProductTariff> ProductTariffs { get; set; }
        public virtual DbSet<ProlongationShortDataSummary> ProlongationShortDataSummaries { get; set; }
        public virtual DbSet<ProlongationShortDatum> ProlongationShortDatas { get; set; }
        public virtual DbSet<TariffAttribute> TariffAttributes { get; set; }

        public PostgreeSqlContext()
        {
        }

        public PostgreeSqlContext(DbContextOptions<PostgreeSqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=192.168.1.56;Database=regofficex;Username=registrator;Password=ujhdjgajr");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("dblink");

            modelBuilder.Entity<Abonent>(entity =>
            {
                entity.HasKey(e => e.AbonentId)
                    .HasName("pk_abonent");

                entity.ToTable("ro_abonent");

                entity.HasAnnotation("Relational:Comment", "Таблица абонентов");

                entity.HasIndex(e => e.AbonentTypeId, "abonent_abonent_type_id_idx");

                entity.HasIndex(e => e.CompanyGroupId, "abonent_company_group_id_idx");

                entity.HasIndex(e => e.LocationAddressId, "abonent_location_address_id_idx");

                entity.HasIndex(e => e.OfficeId, "abonent_office_id_idx");

                entity.HasIndex(e => e.OkopfId, "abonent_okopf_id_idx");

                entity.HasIndex(e => e.PostalAddressId, "abonent_postal_address_id_idx");

                entity.HasIndex(e => e.ShortName, "abonent_short_name_idx");

                entity.HasIndex(e => e.UserId, "abonent_user_id_idx");

                entity.HasIndex(e => e.RegionId, "idx_region_id");

                entity.HasIndex(e => e.RnsPfr, "idx_rns_pfr");

                entity.HasIndex(e => e.Inn, "inn");

                entity.HasIndex(e => e.AbonentGuid, "ro_abonent_abonent_guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.AbonentLogin, "sk_abonent_login")
                    .IsUnique();

                entity.HasIndex(e => new { e.Inn, e.Kpp }, "sk_inn_kpp")
                    .IsUnique();

                entity.Property(e => e.AbonentId)
                    .HasColumnName("abonent_id")
                    .HasComment("Код");

                entity.Property(e => e.AbonentGuid)
                    .HasColumnName("abonent_guid")
                    .HasDefaultValueSql("uuid_generate_v4()")
                    .HasComment("Ид. гуид");

                entity.Property(e => e.AbonentLogin)
                    .HasMaxLength(50)
                    .HasColumnName("abonent_login")
                    .HasComment("Логин");

                entity.Property(e => e.AbonentPassword)
                    .HasMaxLength(50)
                    .HasColumnName("abonent_password")
                    .HasComment("Пароль");

                entity.Property(e => e.AbonentTypeId)
                    .HasColumnName("abonent_type_id")
                    .HasComment("Идентификатор");

                entity.Property(e => e.BankName)
                    .HasColumnType("character varying")
                    .HasColumnName("bank_name")
                    .HasComment("Наименование банка");

                entity.Property(e => e.Bic)
                    .HasMaxLength(9)
                    .HasColumnName("bic")
                    .HasComment("БИК");

                entity.Property(e => e.CompanyGroupId)
                    .HasColumnName("company_group_id")
                    .HasComment("Головной абонент");

                entity.Property(e => e.ContactPeople)
                    .HasColumnType("character varying")
                    .HasColumnName("contact_people")
                    .HasComment("Контакты");

                entity.Property(e => e.CorrespondentAccount)
                    .HasMaxLength(20)
                    .HasColumnName("correspondent_account")
                    .HasComment("Корреспондентский счёт");

                entity.Property(e => e.CreationTime)
                    .HasPrecision(0)
                    .HasColumnName("creation_time")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата создания");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .HasComment("Эл. почта");

                entity.Property(e => e.EmplParentNo)
                    .HasMaxLength(5)
                    .HasColumnName("empl_parent_no")
                    .HasComment("Код подчиненности ФСС");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .HasColumnName("fax")
                    .HasComment("Факс");

                entity.Property(e => e.FullName)
                    .HasColumnType("character varying")
                    .HasColumnName("full_name")
                    .HasComment("Полное наименование");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("inn")
                    .HasComment("ИНН");

                entity.Property(e => e.KpFss)
                    .HasMaxLength(4)
                    .HasColumnName("kp_fss")
                    .HasComment("Код подразделения ФСС");

                entity.Property(e => e.Kpp)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("kpp")
                    .HasDefaultValueSql("''::character varying")
                    .HasComment("КПП");

                entity.Property(e => e.LocationAddressId)
                    .HasColumnName("location_address_id")
                    .HasComment("Фактический адрес");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(24)
                    .HasColumnName("mobile")
                    .HasComment("Мобильный телефон");

                entity.Property(e => e.Note)
                    .HasColumnType("character varying")
                    .HasColumnName("note")
                    .HasComment("Примечание");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasComment("Офис");

                entity.Property(e => e.Ogrn)
                    .HasMaxLength(15)
                    .HasColumnName("ogrn")
                    .HasComment("ОГРН");

                entity.Property(e => e.OkopfId)
                    .HasColumnName("okopf_id")
                    .HasComment("ОКОПФ");

                entity.Property(e => e.PaymentAccount)
                    .HasMaxLength(20)
                    .HasColumnName("payment_account")
                    .HasComment("Расчетный счет");

                entity.Property(e => e.PersonalAccount)
                    .HasMaxLength(20)
                    .HasColumnName("personal_account")
                    .HasComment("Лицевой счет");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasColumnName("phone")
                    .HasComment("Телефон");

                entity.Property(e => e.PostalAddressId)
                    .HasColumnName("postal_address_id")
                    .HasComment("Юридический адрес");

                entity.Property(e => e.RawContacts)
                    .HasColumnType("character varying")
                    .HasColumnName("raw_contacts")
                    .HasComment("Необработанные данные контактов");

                entity.Property(e => e.RawLocationAddress)
                    .HasColumnType("character varying")
                    .HasColumnName("raw_location_address")
                    .HasComment("Необработанные данные фактического адреса");

                entity.Property(e => e.RawPostalAddress)
                    .HasColumnType("character varying")
                    .HasColumnName("raw_postal_address")
                    .HasComment("Необработанные данные почтового адреса");

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasComment("Ид. региона");

                entity.Property(e => e.RnsFss)
                    .HasMaxLength(10)
                    .HasColumnName("rns_fss")
                    .HasComment("Рег. номер ФСС");

                entity.Property(e => e.RnsFssSub)
                    .HasMaxLength(10)
                    .HasColumnName("rns_fss_sub")
                    .HasComment("Рег. номер ФСС обособленного подразделения");

                entity.Property(e => e.RnsPfr)
                    .HasMaxLength(14)
                    .HasColumnName("rns_pfr")
                    .HasComment("Рег. номер ПФР");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("short_name")
                    .HasComment("Краткое наименование");

                entity.Property(e => e.StRnsPfr)
                    .HasMaxLength(14)
                    .HasColumnName("st_rns_pfr")
                    .HasComment("Рег. номер ПФР работодателя");

                entity.Property(e => e.UpdateTime)
                    .HasPrecision(0)
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата обновления");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("Пользователь");

                entity.HasOne(d => d.CompanyGroup)
                    .WithMany(p => p.InverseCompanyGroup)
                    .HasForeignKey(d => d.CompanyGroupId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_company_group");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Abonents)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_office");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("pk_agent");

                entity.ToTable("ro_agent");

                entity.HasAnnotation("Relational:Comment", "Таблица партнеров");

                entity.HasIndex(e => e.AbonentId, "agent_abonent_id_idx");

                entity.HasIndex(e => e.ContractId, "agent_contract_id_idx");

                entity.HasIndex(e => e.Cuid, "agent_cuid_idx");

                entity.HasIndex(e => e.LevelAucId, "agent_level_auc_id_idx");

                entity.HasIndex(e => e.LevelId, "agent_level_id_idx");

                entity.HasIndex(e => e.OldParentId, "agent_old_parent_id_idx");

                entity.HasIndex(e => e.ParentId, "agent_parent_id_idx");

                entity.HasIndex(e => e.AgentGuid, "ro_agent_agent_guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.BusinessRegionId, "ro_agent_business_region_id_idx");

                entity.HasIndex(e => new { e.AbonentId, e.ContractId, e.LevelId }, "sk_abonent_contract")
                    .IsUnique();

                entity.HasIndex(e => new { e.AgentName, e.AbonentId }, "sk_agent")
                    .IsUnique();

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasComment("Идентификатор");

                entity.Property(e => e.AbonentId)
                    .HasColumnName("abonent_id")
                    .HasComment("Абонент");

                entity.Property(e => e.AgentGuid)
                    .HasColumnName("agent_guid")
                    .HasDefaultValueSql("uuid_generate_v4()")
                    .HasComment("Ид. гуид");

                entity.Property(e => e.AgentName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("agent_name")
                    .HasComment("Наименование");

                entity.Property(e => e.BusinessRegionId)
                    .HasColumnName("business_region_id")
                    .HasComment("Идентификатор бизнес-региона");

                entity.Property(e => e.Code1c)
                    .HasMaxLength(10)
                    .HasColumnName("code_1c")
                    .HasComment("Код партнера 1С");

                entity.Property(e => e.Comment)
                    .HasColumnType("character varying")
                    .HasColumnName("comment")
                    .HasComment("Комментарий");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasComment("Договор");

                entity.Property(e => e.CreationTime)
                    .HasPrecision(0)
                    .HasColumnName("creation_time")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата создания");

                entity.Property(e => e.Cuid)
                    .HasMaxLength(9)
                    .HasColumnName("cuid")
                    .IsFixedLength()
                    .HasComment("СМ");

                entity.Property(e => e.Distributor1c)
                    .HasColumnName("distributor_1c")
                    .HasComment("Признак агента 1С");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .HasComment("Электронная почта партнера");

                entity.Property(e => e.InvoicePrefix)
                    .HasColumnType("character varying")
                    .HasColumnName("invoice_prefix");

                entity.Property(e => e.IsBit)
                    .HasColumnName("is_bit")
                    .HasComment("Признак партнёра БИТ");

                entity.Property(e => e.LevelAucId)
                    .HasColumnName("level_auc_id")
                    .HasComment("Уровень сертификации партнера");

                entity.Property(e => e.LevelId)
                    .HasColumnName("level_id")
                    .HasDefaultValueSql("4")
                    .HasComment("Уровень");

                entity.Property(e => e.OffTime)
                    .HasPrecision(0)
                    .HasColumnName("off_time")
                    .HasComment("Дата отключения");

                entity.Property(e => e.OldParentId).HasColumnName("old_parent_id");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasComment("Владелец");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasColumnName("phone")
                    .HasComment("Телефон партнера");

                entity.Property(e => e.SupportEmail)
                    .HasMaxLength(100)
                    .HasColumnName("support_email")
                    .HasComment("Электронная почта");

                entity.Property(e => e.SupportPhone)
                    .HasMaxLength(24)
                    .HasColumnName("support_phone")
                    .HasComment("Телефон горячей линии");

                entity.HasOne(d => d.Abonent)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.AbonentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_abonent");

                entity.HasOne(d => d.OldParent)
                    .WithMany(p => p.InverseOldParent)
                    .HasForeignKey(d => d.OldParentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_old_parent");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_parent");
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.HasKey(e => e.CertificateId)
                    .HasName("pk_certificate");

                entity.ToTable("ro_certificate");

                entity.HasAnnotation("Relational:Comment", "Таблица сертификатов");

                entity.HasIndex(e => e.CertId, "certificate_cert_id_idx");

                entity.HasIndex(e => e.CertificateTypeId, "certificate_certificate_type_id_idx");

                entity.HasIndex(e => e.ReceiptId, "certificate_receipt_id_idx");

                entity.HasIndex(e => e.StepId, "certificate_step_id_idx");

                entity.HasIndex(e => e.SubjectKeyId, "certificate_subject_key_id_idx");

                entity.HasIndex(e => e.ThumbPrint, "certificate_thumb_print_idx");

                entity.HasIndex(e => e.TrustCertificateId, "certificate_trust_certificate_id_idx");

                entity.HasIndex(e => e.EndTime, "idx_certificate_end_time");

                entity.HasIndex(e => e.InitialTime, "idx_certificate_initial_time");

                entity.HasIndex(e => new { e.CommonName, e.ThumbPrint }, "sk_certificate_cn_tp")
                    .IsUnique();

                entity.HasIndex(e => e.CertificateGuid, "sk_certificate_guid")
                    .IsUnique();

                entity.HasIndex(e => new { e.SerialNumber, e.IssuerCommonName }, "sk_certificate_sn_icn")
                    .IsUnique();

                entity.Property(e => e.CertificateId)
                    .HasColumnName("certificate_id")
                    .HasComment("Идентификатор");

                entity.Property(e => e.AuthorityKeyId)
                    .HasMaxLength(40)
                    .HasColumnName("authority_key_id")
                    .HasComment("Идентификатор ключа издателя");

                entity.Property(e => e.CertId)
                    .HasColumnName("cert_id")
                    .HasComment("Сертификат");

                entity.Property(e => e.CertificateGuid)
                    .HasColumnName("certificate_guid")
                    .HasComment("ГУИД");

                entity.Property(e => e.CertificateTypeId)
                    .HasColumnName("certificate_type_id")
                    .HasComment("Тип");

                entity.Property(e => e.CommonName)
                    .HasMaxLength(300)
                    .HasColumnName("common_name")
                    .HasComment("Общее имя");

                entity.Property(e => e.EndTime)
                    .HasPrecision(0)
                    .HasColumnName("end_time")
                    .HasComment("Дата окончания действия");

                entity.Property(e => e.InitialTime)
                    .HasPrecision(0)
                    .HasColumnName("initial_time")
                    .HasComment("Дата начала действия");

                entity.Property(e => e.IssuerCommonName)
                    .HasMaxLength(255)
                    .HasColumnName("issuer_common_name")
                    .HasComment("Общее имя издателя");

                entity.Property(e => e.Message)
                    .HasColumnType("character varying")
                    .HasColumnName("message")
                    .HasComment("Сообщение");

                entity.Property(e => e.ReceiptId)
                    .HasColumnName("receipt_id")
                    .HasComment("Печатная форма расписки");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("serial_number")
                    .HasComment("Серийный номер");

                entity.Property(e => e.StepId)
                    .HasColumnName("step_id")
                    .HasDefaultValueSql("5")
                    .HasComment("Состояние");

                entity.Property(e => e.SubjectKeyId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("subject_key_id")
                    .HasComment("Идентификатор ключа субъекта");

                entity.Property(e => e.ThumbPrint)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("thumb_print")
                    .HasComment("Отпечаток");

                entity.Property(e => e.TrustCertificateId)
                    .HasColumnName("trust_certificate_id")
                    .HasComment("Корневой");

                entity.HasOne(d => d.TrustCertificate)
                    .WithMany(p => p.InverseTrustCertificate)
                    .HasForeignKey(d => d.TrustCertificateId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_trust_certificate");
            });

            modelBuilder.Entity<ContractTariff>(entity =>
            {
                entity.HasKey(e => e.ContractTariffId)
                    .HasName("pk_contract_tariff");

                entity.ToTable("ro_contract_tariff");

                entity.HasAnnotation("Relational:Comment", "Таблица услуг по договору");

                entity.HasIndex(e => e.ContractId, "contract_tariff_contract_id_idx");

                entity.HasIndex(e => e.RegistrationNumber, "contract_tariff_registration_number_idx");

                entity.HasIndex(e => e.SectionId, "contract_tariff_section_id_idx");

                entity.HasIndex(e => new { e.SectionId, e.TariffId }, "contract_tariff_section_id_tariff_id_idx");

                entity.HasIndex(e => e.StepId, "contract_tariff_step_id_idx");

                entity.HasIndex(e => e.TariffId, "contract_tariff_tariff_id_idx");

                entity.HasIndex(e => e.UserId, "contract_tariff_user_id_idx");

                entity.HasIndex(e => e.EndDate, "idx_contract_tariff_end_date");

                entity.HasIndex(e => e.InitialDate, "idx_contract_tariff_initial_date");

                entity.HasIndex(e => e.RegistrationDate, "idx_registration_date");

                entity.HasIndex(e => e.ContractTariffGuid, "ro_contract_tariff_contract_tariff_guid_key")
                    .IsUnique();

                entity.Property(e => e.ContractTariffId)
                    .HasColumnName("contract_tariff_id")
                    .HasComment("Идентификатор");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasComment("Договор");

                entity.Property(e => e.ContractTariffGuid)
                    .HasColumnName("contract_tariff_guid")
                    .HasDefaultValueSql("uuid_generate_v4()")
                    .HasComment("Ид. гуид");

                entity.Property(e => e.Cost)
                    .HasPrecision(18, 2)
                    .HasColumnName("cost")
                    .HasComment("Затраты");

                entity.Property(e => e.DiscountSum)
                    .HasPrecision(18, 2)
                    .HasColumnName("discount_sum")
                    .HasComment("Сумма скидки");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasComment("Дата окончания");

                entity.Property(e => e.InitialDate)
                    .HasColumnName("initial_date")
                    .HasDefaultValueSql("('now'::text)::date")
                    .HasComment("Дата начала");

                entity.Property(e => e.IsPrimary)
                    .HasColumnName("is_primary")
                    .HasComment("Первичный");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasDefaultValueSql("1")
                    .HasComment("Количество");

                entity.Property(e => e.PercentDiscount)
                    .HasPrecision(5, 2)
                    .HasColumnName("percent_discount")
                    .HasComment("Процент скидки");

                entity.Property(e => e.Price)
                    .HasPrecision(18, 2)
                    .HasColumnName("price")
                    .HasComment("Цена");

                entity.Property(e => e.RegistrationDate)
                    .HasPrecision(0)
                    .HasColumnName("registration_date")
                    .HasDefaultValueSql("NULL::timestamp with time zone")
                    .HasComment("Дата регистрации");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(100)
                    .HasColumnName("registration_number")
                    .HasComment("Регистрационный номер");

                entity.Property(e => e.SectionId)
                    .HasColumnName("section_id")
                    .HasComment("Секция прайса");

                entity.Property(e => e.StepId)
                    .HasColumnName("step_id")
                    .HasDefaultValueSql("16")
                    .HasComment("Состояние");

                entity.Property(e => e.Sum)
                    .HasPrecision(18, 2)
                    .HasColumnName("sum")
                    .HasComment("Стоимость");

                entity.Property(e => e.TariffId)
                    .HasColumnName("tariff_id")
                    .HasComment("Услуга");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("Пользователь");

                entity.Property(e => e.WaitingDays)
                    .HasColumnName("waiting_days")
                    .HasComment("Дни ожидания");

                entity.HasMany(d => d.Products)
                    .WithMany(p => p.ContractTariffs)
                    .UsingEntity<Dictionary<string, object>>(
                        "RoProductTariff",
                        l => l.HasOne<Product>().WithMany().HasForeignKey("ProductId").HasConstraintName("fk_product"),
                        r => r.HasOne<ContractTariff>().WithMany().HasForeignKey("ContractTariffId").HasConstraintName("fk_contract_tariff"),
                        j =>
                        {
                            j.HasKey("ContractTariffId", "ProductId").HasName("pk_product_tariff");

                            j.ToTable("ro_product_tariff").HasAnnotation("Relational:Comment", "Таблица услуг продукта");

                            j.HasIndex(new[] { "ContractTariffId" }, "product_tariff_contract_tariff_id_idx");

                            j.HasIndex(new[] { "ProductId" }, "product_tariff_product_id_idx");

                            j.IndexerProperty<int>("ContractTariffId").HasColumnName("contract_tariff_id").HasComment("Услуга по договору");

                            j.IndexerProperty<int>("ProductId").HasColumnName("product_id").HasComment("Продукт");
                        });
            });

            modelBuilder.Entity<ContractTariffExtension>(entity =>
            {
                entity.HasKey(e => e.ExtensionId)
                    .HasName("pk_contract_tariff_extension");

                entity.ToTable("ro_contract_tariff_extension");

                entity.HasAnnotation("Relational:Comment", "Таблица расширений услуг продукта");

                entity.HasIndex(e => e.ContractTariffId, "contract_tariff_extension_contract_tariff_id_idx");

                entity.Property(e => e.ExtensionId)
                    .ValueGeneratedNever()
                    .HasColumnName("extension_id")
                    .HasComment("Расширение");

                entity.Property(e => e.ContractTariffId)
                    .HasColumnName("contract_tariff_id")
                    .HasComment("Главная услуга");

                entity.HasOne(d => d.ContractTariff)
                    .WithMany(p => p.ContractTariffExtensionContractTariffs)
                    .HasForeignKey(d => d.ContractTariffId)
                    .HasConstraintName("fk_contract_tariff");

                entity.HasOne(d => d.Extension)
                    .WithOne(p => p.ContractTariffExtensionExtension)
                    .HasForeignKey<ContractTariffExtension>(d => d.ExtensionId)
                    .HasConstraintName("fk_extension");
            });

            modelBuilder.Entity<Key>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("pk_key");

                entity.ToTable("ro_key");

                entity.HasAnnotation("Relational:Comment", "Таблица ключей");

                entity.HasIndex(e => e.CaId, "key_ca_id_idx");

                entity.HasIndex(e => e.CertRequestId, "key_cert_request_id_idx");

                entity.HasIndex(e => e.CertificateId, "key_certificate_id_idx");

                entity.HasIndex(e => e.ContainerId, "key_container_id_idx");

                entity.HasIndex(e => e.PersonId, "key_person_id_idx");

                entity.HasIndex(e => e.ProviderId, "key_provider_id_idx");

                entity.HasIndex(e => e.TemplateId, "key_template_id_idx");

                entity.HasIndex(e => e.VipnetUserId, "key_vipnet_user_id_idx");

                entity.HasIndex(e => e.PackId, "sk_pack_id")
                    .IsUnique();

                entity.HasIndex(e => e.PublicKey, "sk_public_key")
                    .IsUnique();

                entity.Property(e => e.KeyId)
                    .HasColumnName("key_id")
                    .HasComment("Идентификатор");

                entity.Property(e => e.CaId)
                    .HasColumnName("ca_id")
                    .HasComment("ЦС");

                entity.Property(e => e.CertRequestId)
                    .HasColumnName("cert_request_id")
                    .HasComment("Запрос на сертификат");

                entity.Property(e => e.CertTemplateId)
                    .HasColumnName("cert_template_id")
                    .HasComment("Шаблон сертификата");

                entity.Property(e => e.CertificateId)
                    .HasColumnName("certificate_id")
                    .HasComment("Сертификат");

                entity.Property(e => e.ContainerId)
                    .HasColumnName("container_id")
                    .HasComment("Контейнер");

                entity.Property(e => e.ContainerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("container_name")
                    .HasComment("Наименование контейнера");

                entity.Property(e => e.CreationTime)
                    .HasPrecision(0)
                    .HasColumnName("creation_time")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата создания");

                entity.Property(e => e.EndTime)
                    .HasPrecision(0)
                    .HasColumnName("end_time")
                    .HasComment("Дата окончания");

                entity.Property(e => e.Eхportable)
                    .IsRequired()
                    .HasColumnName("eхportable")
                    .HasDefaultValueSql("true")
                    .HasComment("Экспортируемый ключ");

                entity.Property(e => e.InitialTime)
                    .HasPrecision(0)
                    .HasColumnName("initial_time")
                    .HasComment("Дата начала");

                entity.Property(e => e.KeyPassword)
                    .HasMaxLength(20)
                    .HasColumnName("key_password")
                    .HasComment("Пароль");

                entity.Property(e => e.PackId)
                    .HasMaxLength(64)
                    .HasColumnName("pack_id")
                    .HasComment("Пакет");

                entity.Property(e => e.PasswordPhrase)
                    .HasMaxLength(100)
                    .HasColumnName("password_phrase")
                    .HasComment("Парольная фраза");

                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .HasComment("Физ. лицо");

                entity.Property(e => e.ProtectionClassId)
                    .HasColumnName("protection_class_id")
                    .HasComment("Класс защиты");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("1")
                    .HasComment("Криптопровайдер");

                entity.Property(e => e.PublicKey)
                    .HasMaxLength(256)
                    .HasColumnName("public_key")
                    .HasComment("Открытый ключ");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasComment("Шаблон УЦ");

                entity.Property(e => e.VipnetUserId)
                    .HasMaxLength(8)
                    .HasColumnName("vipnet_user_id")
                    .IsFixedLength()
                    .HasComment("Пользователь ViPNet");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasComment("Документооборот");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.Keys)
                    .HasForeignKey(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_certificate");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.OfficeId)
                    .HasName("pk_office");

                entity.ToTable("ro_office");

                entity.HasAnnotation("Relational:Comment", "Таблица офисов");

                entity.HasIndex(e => e.AgentId, "office_agent_id_idx");

                entity.HasIndex(e => e.CertTemplateId, "office_cert_template_id_idx");

                entity.HasIndex(e => e.CertificateId, "office_certificate_id_idx");

                entity.HasIndex(e => e.DefaultCaId, "office_default_ca_id_idx");

                entity.HasIndex(e => e.DefaultProviderId, "office_default_provider_id_idx");

                entity.HasIndex(e => e.DefaultSosId, "office_default_sos_id_idx");

                entity.HasIndex(e => e.OperatorIrucId, "office_operator_iruc_id_idx");

                entity.HasIndex(e => e.Ruid, "office_ruid");

                entity.HasIndex(e => e.OfficeGuid, "sk_office_guid")
                    .IsUnique();

                entity.HasIndex(e => new { e.AgentId, e.OfficeName }, "sk_office_name")
                    .IsUnique();

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasComment("Партнер");

                entity.Property(e => e.CertTemplateId)
                    .HasColumnName("cert_template_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CertificateId)
                    .HasColumnName("certificate_id")
                    .HasComment("Сертификат");

                entity.Property(e => e.CreationTime)
                    .HasPrecision(0)
                    .HasColumnName("creation_time")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата подключения");

                entity.Property(e => e.DefaultCaId)
                    .HasColumnName("default_ca_id")
                    .HasComment("ЦС");

                entity.Property(e => e.DefaultProviderId)
                    .HasColumnName("default_provider_id")
                    .HasDefaultValueSql("1")
                    .HasComment("Криптопровайдер");

                entity.Property(e => e.DefaultSosId)
                    .HasColumnName("default_sos_id")
                    .HasComment("СОС");

                entity.Property(e => e.OffTime)
                    .HasPrecision(0)
                    .HasColumnName("off_time")
                    .HasComment("Дата отключения");

                entity.Property(e => e.OfficeGuid)
                    .HasColumnName("office_guid")
                    .HasComment("ГУИД");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("office_name")
                    .HasComment("Наименование");

                entity.Property(e => e.OperatorIrucId)
                    .HasColumnName("operator_iruc_id")
                    .HasComment("Оператор ИРУЦ");

                entity.Property(e => e.Password)
                    .HasMaxLength(128)
                    .HasColumnName("password")
                    .HasComment("Пароль для работы с DSS");

                entity.Property(e => e.PfrSender)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("pfr_sender")
                    .HasDefaultValueSql("'Тест'::character varying");

                entity.Property(e => e.PfrSystemSender)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("pfr_system_sender")
                    .HasDefaultValueSql("'Тест'::character varying");

                entity.Property(e => e.Ruid)
                    .HasMaxLength(9)
                    .HasColumnName("ruid")
                    .IsFixedLength()
                    .HasComment("СУ");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("fk_agent");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_certificate");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("pk_product");

                entity.ToTable("ro_product");

                entity.HasAnnotation("Relational:Comment", "Таблица продуктов");

                entity.HasIndex(e => e.AbonentId, "product_abonent_id_idx");

                entity.HasIndex(e => e.AbonentLocationAddressId, "product_abonent_location_address_id_idx");

                entity.HasIndex(e => e.AbonentPostalAddressId, "product_abonent_postal_address_id_idx");

                entity.HasIndex(e => e.AbonentShortName, "product_abonent_short_name_idx");

                entity.HasIndex(e => e.AccrRepresentId, "product_accr_represent_id_idx");

                entity.HasIndex(e => e.CategoryId, "product_category_id_idx");

                entity.HasIndex(e => e.ContractId, "product_contract_id_idx");

                entity.HasIndex(e => e.LicFileId, "product_lic_file_id_idx");

                entity.HasIndex(e => e.OfficeId, "product_office_id_idx");

                entity.HasIndex(e => e.PacketId, "product_packet_id_idx");

                entity.HasIndex(e => e.ProductTypeId, "product_product_type_id_idx");

                entity.HasIndex(e => e.ProxyAgentId, "product_proxy_agent_id_idx");

                entity.HasIndex(e => e.RegFileId, "product_reg_file_id_idx");

                entity.HasIndex(e => e.SafeId, "product_safe_id_idx");

                entity.HasIndex(e => e.StepId, "product_step_id_idx");

                entity.HasIndex(e => e.StorageTypeId, "product_storage_type_id_idx");

                entity.HasIndex(e => e.UserId, "product_user_id_idx");

                entity.HasIndex(e => new { e.AbonentId, e.ProductId }, "sk_product")
                    .IsUnique();

                entity.HasIndex(e => e.ProductGuid, "sk_product_guid")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasComment("Идентификатор");

                entity.Property(e => e.AbonentEmail)
                    .HasMaxLength(100)
                    .HasColumnName("abonent_email")
                    .HasComment("Эл. почта");

                entity.Property(e => e.AbonentFullName)
                    .HasColumnType("character varying")
                    .HasColumnName("abonent_full_name")
                    .HasComment("Полное наименование");

                entity.Property(e => e.AbonentId)
                    .HasColumnName("abonent_id")
                    .HasComment("Абонент");

                entity.Property(e => e.AbonentKpFss)
                    .HasMaxLength(4)
                    .HasColumnName("abonent_kp_fss")
                    .HasComment("Код подразделения ФСС");

                entity.Property(e => e.AbonentLocationAddressId)
                    .HasColumnName("abonent_location_address_id")
                    .HasComment("Фактический адрес");

                entity.Property(e => e.AbonentPostalAddressId)
                    .HasColumnName("abonent_postal_address_id")
                    .HasComment("Юридический адрес");

                entity.Property(e => e.AbonentRnsFss)
                    .HasMaxLength(10)
                    .HasColumnName("abonent_rns_fss")
                    .HasComment("Рег. номер ФСС");

                entity.Property(e => e.AbonentRnsPfr)
                    .HasMaxLength(14)
                    .HasColumnName("abonent_rns_pfr")
                    .HasComment("Рег. номер ПФР");

                entity.Property(e => e.AbonentShortName)
                    .HasMaxLength(500)
                    .HasColumnName("abonent_short_name")
                    .HasComment("Краткое наименование");

                entity.Property(e => e.AbonentTypeId)
                    .HasColumnName("abonent_type_id")
                    .HasComment("Идентификатор типа абонента этого продукта");

                entity.Property(e => e.AccrRepresent)
                    .HasColumnName("accr_represent")
                    .HasComment("Зависимый");

                entity.Property(e => e.AccrRepresentId)
                    .HasColumnName("accr_represent_id")
                    .HasComment("УП");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasComment("Категория");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasComment("Договор");

                entity.Property(e => e.CreationTime)
                    .HasPrecision(0)
                    .HasColumnName("creation_time")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата создания");

                entity.Property(e => e.DateFixed)
                    .HasColumnName("date_fixed")
                    .HasComment("Дата окончания");

                entity.Property(e => e.FirstRate)
                    .HasColumnName("first_rate")
                    .HasComment("Крупнейший");

                entity.Property(e => e.HardCodeSos)
                    .HasColumnName("hard_code_sos")
                    .HasComment("Привязка к СОС");

                entity.Property(e => e.IsIts)
                    .HasColumnName("is_its")
                    .HasComment("Флаг ИТС");

                entity.Property(e => e.IsPartial)
                    .HasColumnName("is_partial")
                    .HasComment("Частичный рег-файл");

                entity.Property(e => e.LazyUpdate)
                    .HasColumnName("lazy_update")
                    .HasComment("Отложенное обновление");

                entity.Property(e => e.LicFileId)
                    .HasColumnName("lic_file_id")
                    .HasComment("Файл лицензии");

                entity.Property(e => e.MailLogin)
                    .HasMaxLength(50)
                    .HasColumnName("mail_login")
                    .HasComment("Почтовый логин");

                entity.Property(e => e.MailPassword)
                    .HasMaxLength(50)
                    .HasColumnName("mail_password")
                    .HasComment("Почтовый пароль");

                entity.Property(e => e.Message)
                    .HasColumnType("character varying")
                    .HasColumnName("message")
                    .HasComment("Сообщение");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(24)
                    .HasColumnName("mobile")
                    .HasComment("Мобильный телефон");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasComment("Офис");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(14)
                    .HasColumnName("okpo")
                    .HasComment("ОКПО");

                entity.Property(e => e.PacketId)
                    .HasColumnName("packet_id")
                    .HasComment("Пакет обновления");

                entity.Property(e => e.ProductGuid)
                    .HasColumnName("product_guid")
                    .HasComment("Наименование");

                entity.Property(e => e.ProductTypeId)
                    .HasColumnName("product_type_id")
                    .HasComment("Тип");

                entity.Property(e => e.ProgramVersion)
                    .HasMaxLength(150)
                    .HasColumnName("program_version")
                    .HasComment("Версия программы (конфигурации)");

                entity.Property(e => e.ProxyAgentId)
                    .HasColumnName("proxy_agent_id")
                    .HasComment("УП");

                entity.Property(e => e.Pseudonym)
                    .HasMaxLength(100)
                    .HasColumnName("pseudonym")
                    .HasComment("Псевдоним");

                entity.Property(e => e.RegFileId)
                    .HasColumnName("reg_file_id")
                    .HasComment("Рег-файл");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(255)
                    .HasColumnName("registration_number")
                    .HasComment("Рег. номер продукта");

                entity.Property(e => e.SafeId)
                    .HasColumnName("safe_id")
                    .HasComment("Конфиденциальные данные");

                entity.Property(e => e.SmsConfirmation)
                    .HasColumnName("sms_confirmation")
                    .HasComment("СМС подтверждение");

                entity.Property(e => e.StPfr)
                    .HasColumnName("st_pfr")
                    .HasComment("Тип РНС ПФР");

                entity.Property(e => e.StepId)
                    .HasColumnName("step_id")
                    .HasComment("Состояние");

                entity.Property(e => e.StorageTypeId)
                    .HasColumnName("storage_type_id")
                    .HasComment("Тип хранилища");

                entity.Property(e => e.TaxSystemId)
                    .HasColumnName("tax_system_id")
                    .HasComment("Идентификатор системы налогообложения");

                entity.Property(e => e.TransferPointId)
                    .HasColumnName("transfer_point_id")
                    .HasComment("Точка выдачи");

                entity.Property(e => e.UpdateDate)
                    .HasPrecision(0)
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата обновления рег-пакета");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("Пользователь");

                entity.HasOne(d => d.Abonent)
                    .WithMany(p => p.ProductAbonents)
                    .HasForeignKey(d => d.AbonentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_abonent");

                entity.HasOne(d => d.AccrRepresentNavigation)
                    .WithMany(p => p.ProductAccrRepresentNavigations)
                    .HasForeignKey(d => d.AccrRepresentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_accr_represent");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_office");
            });

            modelBuilder.Entity<ProductPerson>(entity =>
            {
                entity.HasKey(e => e.ProductPersonId)
                    .HasName("pk_product_person");

                entity.ToTable("ro_product_person");

                entity.HasAnnotation("Relational:Comment", "Таблица сотрудников продукта");

                entity.HasIndex(e => e.AbonentPersonId, "product_person_abonent_person_id_idx");

                entity.HasIndex(e => e.DssUserId, "product_person_dss_user_id_idx");

                entity.HasIndex(e => e.KeyId, "product_person_key_id_idx");

                entity.HasIndex(e => e.ProductId, "product_person_product_id_idx");

                entity.HasIndex(e => e.ProductTypeId, "product_person_product_type_id_idx");

                entity.HasIndex(e => e.RegFileTypeId, "product_person_reg_file_type_id_idx");

                entity.HasIndex(e => e.ReserveKeyId, "product_person_reserve_key_id_idx");

                entity.HasIndex(e => e.SignQualificationId, "product_person_sign_qualification_id_idx");

                entity.HasIndex(e => e.StepId, "product_person_step_id_idx");

                entity.Property(e => e.ProductPersonId)
                    .HasColumnName("product_person_id")
                    .HasComment("Идентификатор");

                entity.Property(e => e.AbonentPersonId)
                    .HasColumnName("abonent_person_id")
                    .HasComment("Сотрудник");

                entity.Property(e => e.CreationTime)
                    .HasPrecision(0)
                    .HasColumnName("creation_time")
                    .HasDefaultValueSql("now()")
                    .HasComment("Дата создания");

                entity.Property(e => e.DssUserId)
                    .HasColumnName("dss_user_id")
                    .HasComment("Идентификатор пользователя DSS в БД");

                entity.Property(e => e.Encrypt)
                    .HasColumnName("encrypt")
                    .HasComment("Шифровальщик");

                entity.Property(e => e.IonOnline)
                    .HasColumnName("ion_online")
                    .HasComment("Онлайн");

                entity.Property(e => e.IsAdministrator)
                    .HasColumnName("is_administrator")
                    .HasComment("Сотрудник имеет роль Администратор");

                entity.Property(e => e.IsTrusted)
                    .HasColumnName("is_trusted")
                    .HasComment("Это доверенное лицо");

                entity.Property(e => e.KeyId)
                    .HasColumnName("key_id")
                    .HasComment("Ключ");

                entity.Property(e => e.Message)
                    .HasColumnType("character varying")
                    .HasColumnName("message")
                    .HasComment("Сообщение");

                entity.Property(e => e.OffTime)
                    .HasPrecision(0)
                    .HasColumnName("off_time")
                    .HasComment("Дата отключения");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasComment("Продукт");

                entity.Property(e => e.ProductPersonGuid)
                    .HasColumnName("product_person_guid")
                    .HasDefaultValueSql("uuid_generate_v4()")
                    .HasComment("ГУИД владельца ЭЦП");

                entity.Property(e => e.ProductTypeId)
                    .HasColumnName("product_type_id")
                    .HasComment("Тип");

                entity.Property(e => e.RegFileTypeId)
                    .HasColumnName("reg_file_type_id")
                    .HasComment("Тип рег-файла");

                entity.Property(e => e.ReserveKeyId)
                    .HasColumnName("reserve_key_id")
                    .HasComment("Резервный ключ");

                entity.Property(e => e.SignQualificationId)
                    .HasColumnName("sign_qualification_id")
                    .HasComment("Квалификация подписи");

                entity.Property(e => e.Signer)
                    .HasColumnName("signer")
                    .HasComment("Подписант");

                entity.Property(e => e.StepId)
                    .HasColumnName("step_id")
                    .HasComment("Состояние");

                entity.Property(e => e.StorageTypeId)
                    .HasColumnName("storage_type_id")
                    .HasComment("Тип хранилища");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("Пользователь");

                entity.HasOne(d => d.Key)
                    .WithMany(p => p.ProductPersonKeys)
                    .HasForeignKey(d => d.KeyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_key");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPeople)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("fk_product");

                entity.HasOne(d => d.ReserveKey)
                    .WithMany(p => p.ProductPersonReserveKeys)
                    .HasForeignKey(d => d.ReserveKeyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_reserve_key");
            });

            modelBuilder.Entity<ProlongationShortDataSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ro_prolongation_short_data_summary");

                entity.Property(e => e.DisabledDispatchCount)
                    .HasColumnName("disabled_dispatch_count")
                    .HasComment("Отключена проверка отправок");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasComment("Просрочено");

                entity.Property(e => e.ExpiredInNextMonth)
                    .HasColumnName("expired_in_next_month")
                    .HasComment("Заканчивается в следующем месяце");

                entity.Property(e => e.ExpiredInThisMonth)
                    .HasColumnName("expired_in_this_month")
                    .HasComment("Заканчивается в этом месяце");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasComment("Идентификатор офиса");

                entity.Property(e => e.ProlongateImmediate)
                    .HasColumnName("prolongate_immediate")
                    .HasComment("Срочное продление");

                entity.Property(e => e.RiskGroup)
                    .HasColumnName("risk_group")
                    .HasComment("Группа риска");

                entity.Property(e => e.SummaryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("summary_id")
                    .HasComment("Идентификатор статистики по партенрам");

                entity.HasOne(d => d.Office)
                    .WithMany()
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("ro_prolongation_short_data_summary_fk");
            });

            modelBuilder.Entity<ProlongationShortDatum>(entity =>
            {
                entity.HasKey(e => e.ProlongationId)
                    .HasName("ro_prolongation_short_data_pkey");

                entity.ToTable("ro_prolongation_short_data");

                entity.HasAnnotation("Relational:Comment", "Таблица для вкладки \"Работа с продлениями\"");

                entity.HasIndex(e => e.CertificateInitialDate, "certificate_initial_date_idx");

                entity.HasIndex(e => e.AbonentId, "prolongation_short_data_abonent_id_idx");

                entity.HasIndex(e => e.CertificateEndDate, "prolongation_short_data_certificate_end_date_idx");

                entity.HasIndex(e => e.ContractId, "prolongation_short_data_contract_id_idx");

                entity.HasIndex(e => new { e.ContractId, e.ProductId }, "prolongation_short_data_contract_product_idx")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId, "prolongation_short_data_product_idx");

                entity.HasIndex(e => e.TariffEndDate, "prolongation_short_data_tariff_end_date_idx");

                entity.HasIndex(e => e.TariffInitialDate, "tariff_initial_date_idx");

                entity.Property(e => e.ProlongationId)
                    .HasColumnName("prolongation_id")
                    .HasComment("Идентификатор продления");

                entity.Property(e => e.AbonentId)
                    .HasColumnName("abonent_id")
                    .HasComment("Идентификатор абонента");

                entity.Property(e => e.CertificateEndDate)
                    .HasColumnName("certificate_end_date")
                    .HasComment("Дата окончания сертификата");

                entity.Property(e => e.CertificateInitialDate)
                    .HasColumnName("certificate_initial_date")
                    .HasComment("Дата начала сертификата");

                entity.Property(e => e.Comment)
                    .HasColumnType("character varying")
                    .HasColumnName("comment")
                    .HasComment("Комментарий");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasComment("Идентификатор договора");

                entity.Property(e => e.IgnoreDispatch)
                    .HasColumnName("ignore_dispatch")
                    .HasComment("Флаг определяет необходимость проверки наличия отправок абонента");

                entity.Property(e => e.NoDispatch)
                    .HasColumnName("no_dispatch")
                    .HasComment("Флаг определяет факт отсутствия отправок в ФНС/ПФР при наличии соответсвующих направлений");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasComment("Идентификатор продукта");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reason_id")
                    .HasComment("Причина непродления абонента");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(255)
                    .HasColumnName("registration_number")
                    .HasComment("Рег. номер продукта");

                entity.Property(e => e.TariffEndDate)
                    .HasColumnName("tariff_end_date")
                    .HasComment("Дата окончания тарифа");

                entity.Property(e => e.TariffInitialDate)
                    .HasColumnName("tariff_initial_date")
                    .HasComment("Дата начала тарифа");

                entity.Property(e => e.TotalSum)
                    .HasColumnName("total_sum")
                    .HasComment("Общая стоимость");

                entity.Property(e => e.TransferDate)
                    .HasColumnName("transfer_date")
                    .HasComment("Дата переноса");

                entity.HasOne(d => d.Abonent)
                    .WithMany(p => p.ProlongationShortData)
                    .HasForeignKey(d => d.AbonentId)
                    .HasConstraintName("ro_prolongation_short_data_abonent_fk");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProlongationShortData)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ro_prolongation_short_data_product_fk");
            });

            modelBuilder.Entity<TariffAttribute>(entity =>
            {
                entity.HasKey(e => e.TariffAttributeId)
                    .HasName("pk_tariff_attribute_id");

                entity.ToTable("ro_tariff_attribute");

                entity.HasAnnotation("Relational:Comment", "Таблица атрибутов тарифов");

                entity.HasIndex(e => e.AttributeId, "tariff_attribute_attribute_id_idx");

                entity.HasIndex(e => e.TariffId, "tariff_attribute_tariff_id_idx");

                entity.HasIndex(e => e.ValidityUnitId, "tariff_attribute_validity_unit_id_idx");

                entity.Property(e => e.TariffAttributeId).HasColumnName("tariff_attribute_id");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attribute_id")
                    .HasComment("Атрибут");

                entity.Property(e => e.IndexNumber)
                    .HasColumnName("index_number")
                    .HasComment("Порядковый номер");

                entity.Property(e => e.LimitId)
                    .HasColumnName("limit_id")
                    .HasComment("Ограничение");

                entity.Property(e => e.MaxIndex)
                    .HasColumnName("max_index")
                    .HasComment("Максимальный порядковый номер");

                entity.Property(e => e.MaxNumber)
                    .HasColumnName("max_number")
                    .HasComment("Максимальное количество");

                entity.Property(e => e.MinIndex)
                    .HasColumnName("min_index")
                    .HasComment("Минимальный порядковый номер");

                entity.Property(e => e.MinNumber)
                    .HasColumnName("min_number")
                    .HasComment("Минимальное количество");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasComment("Количество");

                entity.Property(e => e.TariffId)
                    .HasColumnName("tariff_id")
                    .HasComment("Тариф");

                entity.Property(e => e.Validity)
                    .HasColumnName("validity")
                    .HasComment("Срок действия");

                entity.Property(e => e.ValidityUnitId)
                    .HasColumnName("validity_unit_id")
                    .HasComment("Ед. времени срока");

                entity.Property(e => e.WaitingDays)
                    .HasColumnName("waiting_days")
                    .HasComment("Дни ожидания");
            });

            modelBuilder.HasSequence("ro_issuer_issuer_id_seq");

            modelBuilder.HasSequence("ro_log_type_log_type_id_seq").HasMax(2147483647);

            modelBuilder.HasSequence("ro_potential_abonent_trading_platform_id_seq");

            modelBuilder.HasSequence("ro_potential_abonent_trading_platform_type_id_seq");

            modelBuilder.HasSequence("ro_price_tax_price_id_seq");

            modelBuilder.HasSequence("ro_tariff_tariff_id_seq");

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

            modelBuilder.HasSequence("ro_issuer_issuer_id_seq");

            modelBuilder.HasSequence("ro_log_type_log_type_id_seq").HasMax(2147483647);

            modelBuilder.HasSequence("ro_potential_abonent_trading_platform_id_seq");

            modelBuilder.HasSequence("ro_potential_abonent_trading_platform_type_id_seq");

            modelBuilder.HasSequence("ro_price_tax_price_id_seq");

            modelBuilder.HasSequence("ro_tariff_tariff_id_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
