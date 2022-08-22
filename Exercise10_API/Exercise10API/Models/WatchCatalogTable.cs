using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exercise10API.Models
{
    public partial class WatchCatalogTable
    {
        public int WatchId { get; set; }
        public string ShortDesc { get; set; }
        public string FullDesc { get; set; }
        public string WatchName { get; set; }
        public string ProductNumber { get; set; }
        public string Price { get; set; }
        public string WatchHeight { get; set; }
        public string WatchWeight { get; set; }
        public string WatchDiameter { get; set; }
        public string WatchThickness { get; set; }
        public string Caliber { get; set; }
        public string Movement { get; set; }
        public string Jewel { get; set; }
        public string Chronograph { get; set; }
        public string CaseMaterial { get; set; }
        public string StrapMaterial { get; set; }
    }
}
