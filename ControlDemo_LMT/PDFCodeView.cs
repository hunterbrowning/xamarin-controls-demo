using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.IO;

namespace ControlDemo_LMT
{
	public partial class PDFCodeView : UIViewController
	{
		string _passedFileName;
		public PDFCodeView (string pn) : base ("PDFCodeView", null)
		{
			_passedFileName = pn;
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
			
			string localPDFURL = Path.Combine (NSBundle.MainBundle.BundlePath, _passedFileName);

			webViewDisplay.LoadRequest (new NSUrlRequest (new NSUrl(localPDFURL, false)));
			webViewDisplay.ScalesPageToFit = true;

			toolBar.Items[0].Clicked += delegate {
				this.DismissViewController(true, null);
			};
		}
	}
}

