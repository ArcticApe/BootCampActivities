using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exercise9.Models
{
    public partial class WatchCatalog
    {

        public int WatchId { get; set; }
        [Required]
        public string ShortDesc { get; set; }
        public string FullDesc { get; set; }
        public string WatchName { get; set; }
        public int? ProductNumber { get; set; }
        [Required]
        public int? Price { get; set; }
        public int? WatchHeight { get; set; }
        public int? WatchWeight { get; set; }
        public int? WatchDiameter { get; set; }
        public int? WatchThickness { get; set; }
        public string Caliber { get; set; }
        public string Movement { get; set; }
        public string Jewel { get; set; }
        public string Chronograph { get; set; }
        public string CaseMaterial { get; set; }
        public string StrapMaterial { get; set; }
    }
}
