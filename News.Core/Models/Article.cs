using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace News.Core
{
    public class Article : BaseArticle
    {
        public IList<Image> Image { get; set; }
    }

    public class ArticleSummary : BaseArticle
    {
    }

    public abstract class BaseArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public IList<string> Category { get; set; }
        public string DisplayUrl { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime PublishedUtc { get; set; }
    }
}

