using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public partial class Merchandise
    {
        public Merchandise()
        {
            AgentMerchandises = new HashSet<AgentMerchandise>();
            BulkSkziLicenseUploadTasks = new HashSet<BulkSkziLicenseUploadTask>();
            MerchandiseBills = new HashSet<MerchandiseBill>();
            SkziLicenses = new HashSet<SkziLicense>();
        }


        /// <summary>
        /// Ид в базе 1С
        /// </summary>
        public string MerchandiseSid { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Полное наименование
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Код единицы измерения
        /// </summary>
        public int? MeasureUnitCode { get; set; }

        /// <summary>
        /// Краткое наименование единицы измерения
        /// </summary>
        public string UnitShortName { get; set; }

        /// <summary>
        /// Полное наименование единицы измерения
        /// </summary>
        public string UnitFullName { get; set; }
        public int MerchandiseId { get; set; }

        /// <summary>
        /// Минимальное количество компаний
        /// </summary>
        public int? MinCount { get; set; }

        /// <summary>
        /// Максимальное количество компаний
        /// </summary>
        public int? MaxCount { get; set; }
        public decimal Price { get; set; }
        public decimal NdsPercent { get; set; }

        /// <summary>
        /// Вес(кг)
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int? MerchandiseTypeId { get; set; }

        /// <summary>
        /// Размер вознаграждения
        /// </summary>
        public int Reward { get; set; }
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Вознаграждение для обычного партнера
        /// </summary>
        public decimal? RewardOrdinary { get; set; }

        /// <summary>
        /// Цена для ЦП
        /// </summary>
        public decimal? ScPrice { get; set; }

        /// <summary>
        /// Вознаграждение для ЦП
        /// </summary>
        public decimal? ScReward { get; set; }

        public virtual MerchandiseType MerchandiseType { get; set; }
        public virtual ICollection<AgentMerchandise> AgentMerchandises { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTasks { get; set; }
        public virtual ICollection<MerchandiseBill> MerchandiseBills { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
    }
}
