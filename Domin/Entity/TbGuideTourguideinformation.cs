using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbGuideTourguideinformation
    {
        [Key]
        public Guid IdTourguideinformation { get; set; }
        public string? TourGuideName { get; set; }
        public string? JobTitle { get; set; }
        public string? TourGuidePhoto { get; set; }
        public string? Abstract { get; set; }
        public string? ExplorerTeamLead { get; set; }
        public string? DirectDirection { get; set; }
        public string? Savemoneytime { get; set; }
        public bool? BestTouristGuide { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
