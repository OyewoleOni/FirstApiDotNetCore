﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Models
{
    public class Value
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

    }
}
