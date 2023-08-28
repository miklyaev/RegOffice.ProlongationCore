using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class OfdPrefix
    {
        public OfdPrefix()
        {
            OfdPins = new HashSet<OfdPin>();
        }


        /// <summary>
        /// Ид.
        /// </summary>
        public int PrefixId { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Ид. агента
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Длина генерируемого кода
        /// </summary>
        public int PinLength { get; set; }

        /// <summary>
        /// Время отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
