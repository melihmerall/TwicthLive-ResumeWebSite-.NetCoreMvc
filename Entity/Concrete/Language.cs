﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public string Level { get; set; }
    }
}
