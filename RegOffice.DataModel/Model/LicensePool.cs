using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица пулов лицензий
    /// </summary>
    public partial class LicensePool
    {
        public LicensePool()
        {
            LicensePoolSteps = new HashSet<LicensePoolStep>();
            Contracts = new HashSet<Contract>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int LicenseId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int LicenseTypeId { get; set; }

        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// ПИН код
        /// </summary>
        public string PinCode { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual LicenseType LicenseType { get; set; }
        public virtual Step Step { get; set; }
        public virtual LicenseDetail LicenseDetail { get; set; }
        public virtual ICollection<LicensePoolStep> LicensePoolSteps { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
