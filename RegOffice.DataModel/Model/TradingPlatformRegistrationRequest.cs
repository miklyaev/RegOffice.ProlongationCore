using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица запросов на регистрацию сертификата в торговой площадке
    /// </summary>
    public partial class TradingPlatformRegistrationRequest
    {

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Идентификатор запроса в торговой площадке
        /// </summary>
        public string ExternalRequestId { get; set; }

        /// <summary>
        /// Идентификатор связи атрибута тарифа и торговой площадки
        /// </summary>
        public int TradingPlatformTariffAttributeId { get; set; }

        /// <summary>
        /// Идентификатор регистрируемого продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Идентификатор регистрируемого ключа
        /// </summary>
        public int KeyId { get; set; }

        /// <summary>
        /// Статус регистрации
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Ошибка регистрации сертификата
        /// </summary>
        public string Error { get; set; }

        public virtual Key Key { get; set; }
        public virtual Product Product { get; set; }
        public virtual Step Step { get; set; }
        public virtual TradingPlatformTariffAttribute TradingPlatformTariffAttribute { get; set; }
    }
}
