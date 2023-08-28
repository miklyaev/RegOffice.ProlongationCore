using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица приложений
    /// </summary>
    public partial class Application
    {
        public Application()
        {
            ApplicationSettings = new HashSet<ApplicationSetting>();
            ApplicationSteps = new HashSet<ApplicationStep>();
            LogV222s = new HashSet<LogV222>();
            LogV2s = new HashSet<LogV2>();
            Logs = new HashSet<Log>();
            OperationLogs = new HashSet<OperationLog>();
            ProcessingProducts = new HashSet<ProcessingProduct>();
            Tokens = new HashSet<Token>();
            Transitions = new HashSet<Transition>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual Step Step { get; set; }
        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual ICollection<ApplicationStep> ApplicationSteps { get; set; }
        public virtual ICollection<LogV222> LogV222s { get; set; }
        public virtual ICollection<LogV2> LogV2s { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<OperationLog> OperationLogs { get; set; }
        public virtual ICollection<ProcessingProduct> ProcessingProducts { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
