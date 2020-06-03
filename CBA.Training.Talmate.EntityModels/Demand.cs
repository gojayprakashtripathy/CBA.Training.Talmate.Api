using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CBA.Training.Talmate.EntityModels
{
    public class Demand
    {
        [Key]        
        public int DemandId { get; set; }
        public string PrimarySkills { get; set; }
        public string SecondarySkills { get; set; }
        public string Location { get; set; }
        public DateTime? Start_By_Date { get; set; }
        public int Experience { get; set; }
    }
}
