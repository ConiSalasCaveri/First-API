﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public class CityDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<TuristicPointDto> TuristicPoints { get; set; } =
            new List<TuristicPointDto>();
    }
}
