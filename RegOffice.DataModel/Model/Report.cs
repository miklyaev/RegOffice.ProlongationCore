using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class Report
    {

        /// <summary>
        /// Ид
        /// </summary>
        public int ReportId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Партнёр
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Кол. активных абонентов
        /// </summary>
        public int? ActiveCount { get; set; }

        /// <summary>
        /// Кол. непродлённых абонентов за год
        /// </summary>
        public int? YearLostCount { get; set; }

        /// <summary>
        /// Прирост за текущий период
        /// </summary>
        public int? IncCount { get; set; }

        /// <summary>
        /// Прирост в прошлом месяце
        /// </summary>
        public int? PrevMonthIncCount { get; set; }

        /// <summary>
        /// К продлению за период
        /// </summary>
        public int? ToProlInPeriodCount { get; set; }

        /// <summary>
        /// Отвал за период
        /// </summary>
        public int? LostInPeriodCount { get; set; }

        /// <summary>
        /// К продлению за период в прошлом году
        /// </summary>
        public int? LastYearToProlInPeriodCount { get; set; }

        /// <summary>
        /// Отвал за период в прошлом году
        /// </summary>
        public int? LastYearLostInPeriod { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Кол. к продлению за год
        /// </summary>
        public int? YearToProlCount { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Месяц
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Кол. активных абонентов в прошлом квартале
        /// </summary>
        public int? PrevQuarterActiveCount { get; set; }

        /// <summary>
        /// Кол. непродлённых абонентов в прошлом году
        /// </summary>
        public int? LastYearLostCount { get; set; }

        /// <summary>
        /// К продлению за год в прошлом году
        /// </summary>
        public int? LastYearToProlCount { get; set; }

        /// <summary>
        /// Прирост в предыдущем квартале
        /// </summary>
        public int? PrevQuarterIncCount { get; set; }

        /// <summary>
        /// К продлению в прошлом квартале
        /// </summary>
        public int? PrevQuarterToProl { get; set; }

        /// <summary>
        /// Отвал за прошлый квартал
        /// </summary>
        public int? PrevQuarterLost { get; set; }

        /// <summary>
        /// К продлению в прошлом месяце
        /// </summary>
        public int? PrevMonthToProl { get; set; }

        /// <summary>
        /// Отвал в прошлом месяце
        /// </summary>
        public int? PrevMonthLost { get; set; }

        /// <summary>
        /// К продлению в текущем квартале
        /// </summary>
        public int? QuarterToProl { get; set; }

        /// <summary>
        /// Отвал в текущем квартале
        /// </summary>
        public int? QuarterLost { get; set; }

        /// <summary>
        /// Кол. активных в прошлом году
        /// </summary>
        public int? PrevYearActiveCount { get; set; }

        /// <summary>
        /// Прирост за текущий квартал
        /// </summary>
        public int? QuarterIncCount { get; set; }

        /// <summary>
        /// Кол. активных абонентов на конец прошлого года
        /// </summary>
        public int? PrevYearEndActiveCount { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Step Step { get; set; }
    }
}
