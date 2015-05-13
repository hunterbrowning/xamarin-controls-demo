// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace ControlDemo_LMT
{
	[Register ("TheSegmentedControl")]
	partial class TheSegmentedControl
	{
		[Outlet]
		MonoTouch.UIKit.UIButton pdfBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel selectedLbl { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISegmentedControl theSegCon { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (selectedLbl != null) {
				selectedLbl.Dispose ();
				selectedLbl = null;
			}

			if (theSegCon != null) {
				theSegCon.Dispose ();
				theSegCon = null;
			}

			if (pdfBtn != null) {
				pdfBtn.Dispose ();
				pdfBtn = null;
			}
		}
	}
}
