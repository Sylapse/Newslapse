using System;
using Android.App;
using Cirrious.MvvmCross.Droid.Views;
using Android.OS;
using Android.Widget;

namespace News.Droid
{
    [Activity(Label = "Home")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.view_home);
            FindViewById<ListView> (Resource.Id.listView).EmptyView = FindViewById (Resource.Id.progressBar);
        }
    }
}