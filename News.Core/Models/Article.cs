using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace News.Core
{
    [DataContract]
    public class Article : BaseArticle
    {
        [DataMember(Name = "Image")]
        public IList<Image> Images { get; set; }
    }

    [DataContract]
    public class ArticleSummary : BaseArticle
    {
    }

    [DataContract]
    public abstract class BaseArticle
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public IList<string> Category { get; set; }
        [DataMember]
        public string DisplayUrl { get; set; }
        [DataMember]
        public DateTime CreatedUtc { get; set; }
        [DataMember]
        public DateTime PublishedUtc { get; set; }
    }
}

