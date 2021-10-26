using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourP.Entities.Concrete
{
    public class Ads
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CookingTime { get; set; }
        public int MaxCalory { get; set; }
        public int MinCalory { get; set; }
        public int Difficulty { get; set; }
        public Entry Entry { get; set; }
        public int EntryId { get; set; }
        public List<Content> Content { get; set; }
        public List<Steps> Steps { get; set; }
    }
}
