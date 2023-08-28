using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ОКОПФ
    /// </summary>
    public partial class Okopf
    {
        public Okopf()
        {
            Abonents = new HashSet<Abonent>();
            RegRequests = new HashSet<RegRequest>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int OkopfId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string OkopfName { get; set; }
        public string OkopfShortName { get; set; }

        /// <summary>
        /// Код ОК 028-99
        /// </summary>
        public string Code99 { get; set; }

        /// <summary>
        /// Код ОК 028-2012
        /// </summary>
        public string Code2012 { get; set; }

        /// <summary>
        /// Бюджетное учреждение
        /// </summary>
        public bool Budget { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual Step Step { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
