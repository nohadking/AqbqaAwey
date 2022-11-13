using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeDtripsSchedule
    {
        [Key]
        public Guid IDtripsSchedule { get; set; }
        public string? ProgramName { get; set; }
        public Guid IdTripCategories { get; set; }
        [ForeignKey("IdTripCategories")]
        public TbHomeTripCategory TbHomeTripCategory  { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? MainPicture { get; set; }
        public Guid IdcategoriesBuckect { get; set; }
        [ForeignKey("IdcategoriesBuckect")]
        public TbHomeCategorieSbuckect tbHomeCategorieSbuckect { get; set; }
        public string? Address { get; set; }
        public string? PriceIncludes { get; set; }
        public string? PriceDoesNotInclude { get; set; }
       
        public string? DaysHours { get; set; }
        public string? Price { get; set; }
        public string? PriceAfterDiscount { get; set; }
        public string? CleanlinessRatio { get; set; }
        public string? FacilitiesRatio { get; set; }
        public string? MoneyRatio { get; set; }
        public string? ServiCeratio { get; set; }
        public string? LocationRatio { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
