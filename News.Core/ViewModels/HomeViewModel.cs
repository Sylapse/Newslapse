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
        }

        public async void Init()
        {
            var superCategory = await _articleService.GetSuperCategory ();
            CategorySummaries = superCategory.CategorySummaries;
        }

        private IList<CategorySummary> _categorySummaries = new List<CategorySummary>();
        public IList<CategorySummary> CategorySummaries {
            get { return _categorySummaries; }
            set { _categorySummaries = value; RaisePropertyChanged (() => CategorySummaries); }
        }

        private MvxCommand<CategorySummary> _itemSelected;
        public ICommand ItemSelected {
            get {
                _itemSelected = _itemSelected ?? new MvxCommand<CategorySummary>(DoSelectItem);
                return _itemSelected;
            }
        }

        private void DoSelectItem(CategorySummary item)
        {
            ShowViewModel<CategoryViewModel>(item);
        }
    }
}