using System;
using Cirrious.MvvmCross.Droid.Views;
using Android.App;
using Android.OS;
using Android.Widget;

namespace News.Droid.Views
{
    [Activity(Label = "Category")]
    public class CategoryView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.view_category);
            FindViewById<ListView> (Resource.Id.listView).EmptyView = FindViewById (Resource.Id.progressBar);
        }
    }
}

