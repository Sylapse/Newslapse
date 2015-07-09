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

        public async void Init(CategorySummary categorySummary)
        {
            Title = categorySummary.Title;
            var category = await _articleService.GetCategory (categorySummary.Id);
            ArticleSummaries = category.ArticleSummaries;
        }

        private string _title;
        public string Title {
            get { return _title; }
            set { _title = value; RaisePropertyChanged (() => Title); }
        }

        private IList<ArticleSummary> _articleSummaries;
        public IList<ArticleSummary> ArticleSummaries {
            get { return _articleSummaries; }
            set { _articleSummaries = value; RaisePropertyChanged (() => ArticleSummaries); }
        }
    }
}