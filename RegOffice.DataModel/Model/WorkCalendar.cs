using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class WorkCalendar
    {

        /// <summary>
        /// Рабочий день
        /// </summary>
        public DateOnly WorkDay { get; set; }

        /// <summary>
        /// Признак праздничного дня
        /// </summary>
        public bool IsHoliday { get; set; }
    }
}
