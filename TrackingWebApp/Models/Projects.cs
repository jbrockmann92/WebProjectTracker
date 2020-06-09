using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackingApp.Models;
using ProjectAPI.Models;

namespace TrackingApp.Models
{
    public class Project
    {
        //[Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public float Mileage { get; set; }
        public float Budget { get; set; }
        public float BudgetUsed { get; set; }
        public List<Expense> Expenses { get; set; } //Remember to change these to lists in the API as well
        public List<HoursSpent> HoursSpent { get; set; }
        public List<Receipt> Receipts { get; set; }
        public List<Note> Notes { get; set; }
    }
}