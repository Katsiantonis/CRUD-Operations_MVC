using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentBrief.Models
{
    public class Trainer
    {

        public int Id { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string Subject { get; set; }
    }
}