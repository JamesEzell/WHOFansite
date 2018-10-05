﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WHOfansite.Models
{
    public class SiteSubmissions
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a date")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Please enter a story(It IS why you're here after all)!")]
        public string Story { get; set; }
    }
}
