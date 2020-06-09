using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrackingApp.Models;

namespace TrackingApp.Models
{
    public class Expense
    {
        //[Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public float Cost { get; set; }
        //[ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
