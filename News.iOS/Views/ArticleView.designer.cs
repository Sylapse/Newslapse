// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace News.iOS.Views
{
	[Register ("ArticleView")]
	partial class ArticleView
	{
		[Outlet]
		UIKit.UIActivityIndicatorView ActivityIndicator { get; set; }

		[Outlet]
		UIKit.UIImageView ImageView { get; set; }

		[Outlet]
		UIKit.UIScrollView ScrollView { get; set; }

		[Outlet]
		UIKit.UITextView TextView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ScrollView != null) {
				ScrollView.Dispose ();
				ScrollView = null;
			}

			if (ActivityIndicator != null) {
				ActivityIndicator.Dispose ();
				ActivityIndicator = null;
			}

			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (TextView != null) {
				TextView.Dispose ();
				TextView = null;
			}
		}
	}
}
