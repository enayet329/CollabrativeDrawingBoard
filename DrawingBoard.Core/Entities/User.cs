﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Nickname { get; set; }
    }
}
