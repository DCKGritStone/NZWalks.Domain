﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }= null;
        public string? Description { get; set; }=null;

        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; } 

        public Guid RegionId { get; set; }
        public Guid DifficultyId { get; set; }

        public Difficulty? Difficulty { get; set; }
        public Region? Region { get; set; }

    }
}
