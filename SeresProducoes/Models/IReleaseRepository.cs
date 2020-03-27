﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public interface IReleaseRepository
    {
        IEnumerable<Release> GetAllReleases();
    }
}
