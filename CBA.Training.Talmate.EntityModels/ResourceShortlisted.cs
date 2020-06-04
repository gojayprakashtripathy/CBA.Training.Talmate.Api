﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CBA.Training.Talmate.EntityModels
{
   public class ResourceShortlisted
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimarySkills { get; set; }
        public string SecondarySkills { get; set; }
        public string Location { get; set; }
        public int Experience { get; set; }

        public bool TrainingRecommendation { get; set; }

    }
}
