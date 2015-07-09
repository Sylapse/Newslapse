using System;
using Cirrious.MvvmCross.ViewModels;
using News.Core.Services;
using System.Collections.Generic;

namespace News.Core.ViewModels
{
    public class CategoryViewModel
        : MvxViewModel
    {
        private readonly IArticleService _articleService;

        public CategoryViewModel (
            IArticleService articleService)
        {
            _articleService = articleService;
        }

//        public async void Init()
//        {
//            var superCategory = await _articleService.GetSuperCategory ();
//            CategorySummaries = superCategory.CategorySummaries;
//        }

        private IList<CategorySummary> _categorySummaries = new List<CategorySummary>();
        public IList<CategorySummary> CategorySummaries {
            get { return _categorySummaries; }
            set { _categorySummaries = value; RaisePropertyChanged (() => CategorySummaries); }
        }
    }
}