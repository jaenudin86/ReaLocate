namespace ReaLocate.Data.Models
{
    using Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Photo : BaseModel<int>
    {
        public int? RealEstateId { get; set; }

        public RealEstate RealEstate { get; set; }

        public string SourceUrl { get; set; }
    }
}