﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventShow.Models
{
   public class NoteCreate
    {
        [Required]
        public int ShowID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
