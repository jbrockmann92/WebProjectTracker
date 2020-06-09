﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrackingApp.Models;

namespace ProjectAPI.Models
{
    public class Receipt
    {
        //[Key]
        public int Id { get; set; }
        public string Store { get; set; }
        public float Total { get; set; }
        //[ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
