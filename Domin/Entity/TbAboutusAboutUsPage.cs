using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbAboutusAboutUsPage
    {
        [Key]
        public Guid IdAboutUsPage { get; set; }
        [Required(ErrorMessageResourceType =typeof(Ressoures.Resource1),ErrorMessageResourceName ="PictureAboutUs")]
        public string? PictureAboutUs { get; set; }
        [Required(ErrorMessageResourceType = typeof(Ressoures.Resource1), ErrorMessageResourceName = "Titele")]
        public string? Titele { get; set; }
        public string? Description { get; set; }
        public string? FindTravelProfessional { get; set; }
        public string? GoodReviewByClient { get; set; }
        public string? WantToDo { get; set; }
        public string? ShareTravelLocation { get; set; }
        public string? ShareTravelProvence { get; set; }
        public string? ExcellentGuides { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
