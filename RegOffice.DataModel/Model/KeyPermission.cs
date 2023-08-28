using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class KeyPermission
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int KeyPermissionId { get; set; }

        /// <summary>
        /// Ключ владельца ЭП
        /// </summary>
        public int PersonKeyId { get; set; }

        /// <summary>
        /// Разрешение
        /// </summary>
        public int PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual ProductPersonKey PersonKey { get; set; }
    }
}
