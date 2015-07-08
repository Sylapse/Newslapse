using System;
using System.Collections.Generic;

namespace News.Core
{
    public class SuperCategory
    {
        public int Id { get; set; }
        public string DisplayUrl { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime PublishedUtc { get; set; }
        public string Title { get; set; }
        public IList<Category> Terms { get; set; }
    }
}

