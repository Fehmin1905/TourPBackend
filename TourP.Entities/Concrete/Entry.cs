using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourP.Entities.Concrete
{
    public class Entry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public int AdsId { get; set; }
        public Ads Ads { get; set; }
    }
}
