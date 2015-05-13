using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ControlDemo_LMT
{
	public partial class ViewControllerTwo : UIViewController
	{
		public ViewControllerTwo () : base ("ViewControllerTwo", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			showConOneBtn.TouchUpInside += (object sender, EventArgs e) => {
				this.DismissViewController(true, null);
			};
		}
	}
}

