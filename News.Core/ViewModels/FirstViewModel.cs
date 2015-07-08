using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System;

namespace News.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private readonly IArticleService _articleService;

        public FirstViewModel (
            IArticleService articleService)
        {
            _articleService = articleService;
        }

		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}


        private MvxCommand _getCategories;
        public ICommand GetCategories {
            get {
                _getCategories = _getCategories ?? new MvxCommand(DoGetCategories);
                return _getCategories;
            }
        }

        private async void DoGetCategories()
        {
            var test = await _articleService.GetCategories ();
            var a = await _articleService.GetCategory(22);
        }
    }
}
    