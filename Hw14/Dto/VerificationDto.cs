﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw14.Dto
{
    public class VerificationDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int VerificationCode { get; set; }
        public DateTime DateVerificationCode { get; set; }
    }
}
