using System;
using CoreAnimation;
using UIKit;

namespace JD.iPhone
{
	public partial class BaseVC : UIViewController
	{
		public CAGradientLayer newGradient;
		public BaseVC(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			newGradient = new CAGradientLayer();
			newGradient.Colors = new CoreGraphics.CGColor[]
			{
				UIColor.FromRGB(29,131,216).CGColor,
				UIColor.FromRGB(66,151,213).CGColor
			};
			newGradient.Locations = new Foundation.NSNumber[]
			{
				0f,1f
				};

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

