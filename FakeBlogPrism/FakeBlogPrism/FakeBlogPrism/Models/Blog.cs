using System;

namespace FakeBlogPrism.Models
{
    public class Blog
    {
        public string BlogDescription { get; set; }
        public string BlogTitle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
