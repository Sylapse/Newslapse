using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace News.Core
{
    public class Category : BaseCategory
    {
        public IList<ArticleSummary> Items { get; set; }
    }

    public class CategorySummary : BaseCategory
    {
    }

    public abstract class BaseCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DisplayUrl { get; set; }
    }
}

