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
        UIKit.UIView gradientView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView navView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView profileView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView table { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (gradientView != null) {
                gradientView.Dispose ();
                gradientView = null;
            }

            if (navView != null) {
                navView.Dispose ();
                navView = null;
            }

            if (profileView != null) {
                profileView.Dispose ();
                profileView = null;
            }

            if (table != null) {
                table.Dispose ();
                table = null;
            }
        }
    }
}