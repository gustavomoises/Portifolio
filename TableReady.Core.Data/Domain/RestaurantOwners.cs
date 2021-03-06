﻿//Author: Gustavo Moises (Developer)
//Date: 8/7/2020
//Thead Project PROJ—207-OOS
using System;
using System.Collections.Generic;

namespace TableReady.Core.Data.Domain
{
    public partial class RestaurantOwners
    {
        public int RestaurantId { get; set; }
        public int OwnerId { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Active { get; set; }
        public bool? Request { get; set; }
        public string RequestStatus { get; set; }

        public virtual Owners Owner { get; set; }
        public virtual Restaurants Restaurant { get; set; }
    }
}
