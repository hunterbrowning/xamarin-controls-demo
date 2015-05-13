using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ControlDemo_LMT
{
	public partial class TheSwitchControl : UIViewController
	{
		PDFCodeView _pdfView;
		string _pdfFile = "TheSwitchControl.pdf";

		public TheSwitchControl () : base ("TheSwitchControl", null)
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
			theSwitch.ValueChanged += delegate {
				switchLbl.Text = theSwitch.On.ToString();
			};

			pdfBtn.TouchUpInside += delegate {
				_pdfView = new PDFCodeView(_pdfFile);
				this.PresentViewController(_pdfView, true, null);
			};
		}
	}
}

