using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ControlDemo_LMT
{
	public partial class ViewControllerOne : UIViewController
	{
		ViewControllerTwo vcTwo;
		PDFCodeView _pdfView;
		string _pdfFile = "ViewControllerOne.pdf";

		public ViewControllerOne () : base ("ViewControllerOne", null)
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
			showConTwoBtn.TouchUpInside += (object sender, EventArgs e) => {
				vcTwo = new ViewControllerTwo();

				this.PresentViewController(vcTwo, true, null);
			};
//			showConTwoBtn.TouchUpInside += HandleTouchUpInside;

			pdfBtn.TouchUpInside += delegate {
				_pdfView = new PDFCodeView(_pdfFile);
				this.PresentViewController(_pdfView, true, null);
			};
		}

		void HandleTouchUpInside (object sender, EventArgs e)
		{
			// code to execute someting here if handle method used on btn
		}
	}
}

