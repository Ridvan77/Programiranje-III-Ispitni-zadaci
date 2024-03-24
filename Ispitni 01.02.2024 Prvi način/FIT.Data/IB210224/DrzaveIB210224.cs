﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB210224
{
    public class DrzaveIB210224
    {
        public int Id { get; set; }
        public string NazivDrzave { get; set; }
        public bool Status { get; set; }
        public byte[] Zastava { get; set; }
        public override string ToString()
        {
            return NazivDrzave;
        }

        [NotMapped]
        public int brojGradova {get; set; }
    }
}
