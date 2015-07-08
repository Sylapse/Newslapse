using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace News.Core
{
    [DataContract]
    public class SuperCategory
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string DisplayUrl { get; set; }
        [DataMember]
        public DateTime CreatedUtc { get; set; }
        [DataMember]
        public DateTime PublishedUtc { get; set; }
        [DataMember(Name = "Terms")]
        public IList<CategorySummary> CategorySummaries { get; set; }
    }
}

