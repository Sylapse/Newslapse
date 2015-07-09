using System;
using Cirrious.MvvmCross.Droid.Views;
using Android.App;
using Android.OS;
using Android.Widget;
using News.Core.ViewModels;
using System.ComponentModel;

namespace News.Droid.Views
{
    [Activity]
    public class ArticleView : MvxActivity<ArticleViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Title = ViewModel.Title;
            SetContentView(Resource.Layout.view_article);
        }
    }
}

