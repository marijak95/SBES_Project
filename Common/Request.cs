﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public bool Approved { get; set; }
    }
}
