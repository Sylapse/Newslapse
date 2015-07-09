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
	[Register ("HomeView")]
	partial class HomeView
	{
		[Outlet]
		UIKit.UIActivityIndicatorView ActivityIndicator { get; set; }

		[Outlet]
		UIKit.UITableView TableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ActivityIndicator != null) {
				ActivityIndicator.Dispose ();
				ActivityIndicator = null;
			}

			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}
		}
	}
}
