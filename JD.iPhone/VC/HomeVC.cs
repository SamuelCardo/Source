using System;
using CoreAnimation;
using Foundation;
using UIKit;
using Xamarin;

namespace JD.iPhone
{
	public class TableSource : UITableViewSource
	{
		NSMutableArray categoryArray;
		public TableSource(NSMutableArray catArray)
		{
			categoryArray = new NSMutableArray();
			categoryArray = catArray;
		}
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			CategoryCell cell = (JD.iPhone.CategoryCell)tableView.DequeueReusableCell("categoryCell", indexPath);

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
	public partial class HomeVC : UIViewController
	{
		public HomeVC(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var newGradient = new CAGradientLayer();
			newGradient.Colors = new CoreGraphics.CGColor[]
			{
				UIColor.FromRGB(29,131,216).CGColor,
				UIColor.FromRGB(66,151,213).CGColor
			};
			newGradient.Locations = new Foundation.NSNumber[]
			{
				.5f,1f
				};
			newGradient.Frame = gradientView.Layer.Bounds;
			gradientView.Layer.AddSublayer(newGradient);
			gradientView.Layer.MasksToBounds = true;

			gradientView.AddSubview(profileView);
			gradientView.AddSubview(navView);
			//Dummy data
			NSMutableArray tableArray = new NSMutableArray();
			tableArray.Add(new NSMutableSet("Licenses", "3"));
			tableArray.Add(new NSMutableSet("Licenses", "3"));
			this.table.Source = new TableSource(tableArray);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

