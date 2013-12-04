using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DataAccessLayer.Entities
{
    public class LectureHall
    {
        public int LectureHallID { get; set; }

        [Required]
        [Display(Name = "Hall Name")]
        public string Name { get; set; }

        public int Floor { get; set; }
    }
}