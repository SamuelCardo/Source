using System;
using CoreAnimation;
using Foundation;
using UIKit;

namespace JD.iPhone
{
	public class ExportTableSource : UITableViewSource
	{
		NSMutableArray categoryArray;
		public ExportTableSource(NSMutableArray catArray)
		{
			categoryArray = new NSMutableArray();
			categoryArray = catArray;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			ExportCell cell = (JD.iPhone.ExportCell)tableView.DequeueReusableCell("closedCell", indexPath);
			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			if (categoryArray != null)
				return (System.nint)categoryArray.Count;
			else
				return 0;
			
		}
	}
	public partial class ExportVC : BaseVC
	{
		public ExportVC(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//Navbar

			NSMutableArray tableArray = new NSMutableArray();
			tableArray.Add(new NSMutableSet("Licenses", "3"));
			tableArray.Add(new NSMutableSet("Licenses", "3"));
			table.Source = new ExportTableSource(tableArray);
		}
		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();
			newGradient.Frame = gradientView.Bounds;
			gradientView.Layer.InsertSublayer(newGradient,0);
			gradientView.Layer.MasksToBounds = true;

			navBarView.Layer.ShadowColor = UIColor.FromRGB(255, 0, 0).CGColor;
			navBarView.Layer.ShadowOpacity = 1f;
			navBarView.Layer.ShadowRadius = 3;
			navBarView.Layer.ShadowOffset = new CoreGraphics.CGSize(0, 3);
			navBarView.Layer.MasksToBounds = true;
			gradientView.AddSubview(navBarView);
		}
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

