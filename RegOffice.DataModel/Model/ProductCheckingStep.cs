﻿using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний проверок по продуктам
    /// </summary>
    public partial class ProductCheckingStep
    {

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Проверка
        /// </summary>
        public int CheckingId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual ProductChecking Checking { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
