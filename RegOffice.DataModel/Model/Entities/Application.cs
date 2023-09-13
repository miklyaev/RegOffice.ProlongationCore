using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Application
    {
        public Application()
        {
            ApplicationSettings = new HashSet<ApplicationSetting>();
            ApplicationSteps = new HashSet<ApplicationStep>();
            LogV222s = new HashSet<LogV222>();
            LogV223s = new HashSet<LogV223>();
            LogV2s = new HashSet<LogV2>();
            Logs = new HashSet<Log>();
            OperationLogs = new HashSet<OperationLog>();
            ProcessingProducts = new HashSet<ProcessingProduct>();
            Tokens = new HashSet<Token>();
            Transitions = new HashSet<Transition>();
        }

        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? OffTime { get; set; }
        public int StepId { get; set; }

        public virtual Step Step { get; set; }
        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual ICollection<ApplicationStep> ApplicationSteps { get; set; }
        public virtual ICollection<LogV222> LogV222s { get; set; }
        public virtual ICollection<LogV223> LogV223s { get; set; }
        public virtual ICollection<LogV2> LogV2s { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<OperationLog> OperationLogs { get; set; }
        public virtual ICollection<ProcessingProduct> ProcessingProducts { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
