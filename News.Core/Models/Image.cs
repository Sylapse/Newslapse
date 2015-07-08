using System;
using System.Runtime.Serialization;

namespace News.Core
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DisplayUrl { get; set; }
        [DataMember]
        public DateTime CreatedUtc { get; set; }
        [DataMember]
        public DateTime PublishedUtc { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Url { get; set; }
        [DataMember]
        public string AlternateText { get; set; }
        [DataMember]
        public int Width { get; set; }
        [DataMember]
        public int Height { get ; set; }
    }
}

