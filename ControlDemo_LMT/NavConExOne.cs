using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ControlDemo_LMT
{
	public partial class NavConExOne : UIViewController
	{
		NavConExTwo ncet = new NavConExTwo();
		PDFCodeView _pdfView;
		string _pdfFile = "NavConExOne.pdf";

		public NavConExOne () : base ("NavConExOne", null)
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
			
			navToSecondBtn.TouchUpInside += (object sender, EventArgs e) => {
				NavigationController.PushViewController(ncet, true);
			};
			pdfBtn.TouchUpInside += delegate {
				_pdfView = new PDFCodeView(_pdfFile);
				this.PresentViewController(_pdfView, true, null);
			};
		}
	}
}

