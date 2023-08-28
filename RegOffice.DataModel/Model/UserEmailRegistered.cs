using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Временная таблица для подтверждения наличия e-mail у пользователя
    /// </summary>
    public partial class UserEmailRegistered
    {

        /// <summary>
        /// идентификатор пользователя с подтверждённым e-mail
        /// </summary>
        public int UserId { get; set; }
    }
}
