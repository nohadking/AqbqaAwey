using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeFooterDatum
    {
        [Key]
        public Guid IdFooterData { get; set; }
        public string? LogoCom { get; set; }
        public string? CompanyProfile { get; set; }
        public string? PoboxZipCode { get; set; }
        public string? Titles { get; set; }
        public string? EmailComp { get; set; }
        public string? WebsiteCo { get; set; }
        public string? Facebooklink { get; set; }
        public string? TwitterLink { get; set; }
        public string? Instagramlink { get; set; }
        public string? Linkyou { get; set; }
        public DateTime? Entrytimeanddate { get; set; }
        public string? DataEnyry { get; set; }
    }
}
