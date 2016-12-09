// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace JD.iPhone
{
    [Register ("HomeVC")]
    partial class HomeVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel alertCount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton bellButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView gradientView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel navTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView navView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView profileView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton searchButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView table { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (alertCount != null) {
                alertCount.Dispose ();
                alertCount = null;
            }

            if (bellButton != null) {
                bellButton.Dispose ();
                bellButton = null;
            }

            if (gradientView != null) {
                gradientView.Dispose ();
                gradientView = null;
            }

            if (navTitle != null) {
                navTitle.Dispose ();
                navTitle = null;
            }

            if (navView != null) {
                navView.Dispose ();
                navView = null;
            }

            if (profileView != null) {
                profileView.Dispose ();
                profileView = null;
            }

            if (searchButton != null) {
                searchButton.Dispose ();
                searchButton = null;
            }

            if (table != null) {
                table.Dispose ();
                table = null;
            }
        }
    }
}