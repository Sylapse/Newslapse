using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using News.Core.Services;
using System.Collections.Generic;

namespace News.Core.ViewModels
{
    public class HomeViewModel
        : MvxViewModel
    {
        private readonly IArticleService _articleService;

        public HomeViewModel (
            IArticleService articleService)
        {
            _articleService = articleService;
            Init ();
        }

        private async void Init()
        {
            var superCategory = await _articleService.GetSuperCategory ();
            CategorySummaries = superCategory.CategorySummaries;
        }

        private IList<CategorySummary> _categorySummaries = new List<CategorySummary>();
        public IList<CategorySummary> CategorySummaries {
            get { return _categorySummaries; }
            set { _categorySummaries = value; RaisePropertyChanged (() => CategorySummaries); }
        }
    }
}