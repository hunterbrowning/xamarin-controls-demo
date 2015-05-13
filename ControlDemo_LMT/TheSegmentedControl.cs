using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ControlDemo_LMT
{
	public partial class TheSegmentedControl : UIViewController
	{
		PDFCodeView _pdfView;
		string _pdfFile = "TheSegmentedControl.pdf";

		public TheSegmentedControl () : base ("TheSegmentedControl", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			theSegCon.TintColor = UIColor.Green;
			theSegCon.SelectedSegment = 0;
			theSegCon.ValueChanged += (o, e) => {SetLabelText(theSegCon.SelectedSegment);};

			pdfBtn.TouchUpInside += delegate {
				_pdfView = new PDFCodeView(_pdfFile);
				this.PresentViewController(_pdfView, true, null);
			};
		}

		public void SetLabelText(int index)
		{
			selectedLbl.Text = theSegCon.TitleAt (index);
		}
	}
}

