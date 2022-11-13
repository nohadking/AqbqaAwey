using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeTopDestination
    {
        [Key]
        public Guid IdTopDestinations { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Title3 { get; set; }
        public string? Description { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntrey { get; set; }
    }
}
