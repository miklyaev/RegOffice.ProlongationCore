﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class NewsReviews
    {
        public int NewsReviewId { get; set; }
        public int NewsId { get; set; }
        public int UserId { get; set; }
        public string ReviewText { get; set; }

        public virtual News News { get; set; }
        public virtual User User { get; set; }
    }
}
