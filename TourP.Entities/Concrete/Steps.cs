using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourP.Entities.Concrete
{
    public class Steps
    {
        public int Id { get; set; }
        public string StepTitle { get; set; }
        public string StepDescription { get; set; }
        public Ads Ads { get; set; }
        public int AdsId { get; set; }
    }
}
