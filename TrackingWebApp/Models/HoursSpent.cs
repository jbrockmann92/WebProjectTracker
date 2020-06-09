using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrackingApp.Models;

namespace ProjectAPI.Models
{
    public class HoursSpent
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Hours { get; set; }
        //[ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
