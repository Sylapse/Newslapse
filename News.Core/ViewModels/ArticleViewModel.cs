using System;
using News.Core.Services;
using Cirrious.MvvmCross.ViewModels;

namespace News.Core.ViewModels
{
    public class ArticleViewModel
        : MvxViewModel
    {
        private readonly IArticleService _articleService;

        public ArticleViewModel (
            IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async void Init(ArticleSummary articleSummary)
        {
            Title = articleSummary.Title;
        }

        private string _title;
        public string Title {
            get { return _title; }
            set { _title = value; RaisePropertyChanged (() => Title); }
        }
    }
}