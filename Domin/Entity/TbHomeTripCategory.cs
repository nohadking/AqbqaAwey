using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeTripCategory
    {
        [Key]
        public Guid IdTripCategories { get; set; }
   
        public string? Categories { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntrey { get; set; }
    }
}
