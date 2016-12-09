using System;
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
	public partial class ExportVC : UIViewController
	{
		public ExportVC(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NSMutableArray tableArray = new NSMutableArray();
			tableArray.Add(new NSMutableSet("Licenses", "3"));
			tableArray.Add(new NSMutableSet("Licenses", "3"));
			table.Source = new ExportTableSource(tableArray);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

