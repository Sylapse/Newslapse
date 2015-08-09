using System;
using News.Core.Services;
using Cirrious.MvvmCross.ViewModels;
using System.Linq;

namespace News.Core.ViewModels
{
    public class ArticleViewModel : MvxViewModel
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
            var article = await _articleService.GetArticle (articleSummary.Id);
            Body = article.Body;
            var image = article.Image.FirstOrDefault ();
            if (image != null)
                ImageUrl = string.Format ("{0}{1}", WebService.BaseUrl, image.Url);
        }

        private string _title;
        public string Title {
            get { return _title; }
            set { _title = value; RaisePropertyChanged (() => Title); }
        }

        private string _body;
        public string Body {
            get { return _body; }
            set { _body = value; RaisePropertyChanged (() => Body); }
        }

        private string _imageUrl;
        public string ImageUrl {
            get { return _imageUrl; }
            set { _imageUrl = value; RaisePropertyChanged (() => ImageUrl); }
        }
    }
}