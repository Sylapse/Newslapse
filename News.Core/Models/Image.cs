using System;
using System.Runtime.Serialization;

namespace News.Core
{
    public class Image
    {
        public int Id { get; set; }
        public string DisplayUrl { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime PublishedUtc { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string AlternateText { get; set; }
        public int Width { get; set; }
        public int Height { get ; set; }
    }
}

