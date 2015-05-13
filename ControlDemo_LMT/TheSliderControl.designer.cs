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
	[Register ("TheSliderControl")]
	partial class TheSliderControl
	{
		[Outlet]
		MonoTouch.UIKit.UIButton pdfBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel slidLbl { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider theSlider { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (slidLbl != null) {
				slidLbl.Dispose ();
				slidLbl = null;
			}

			if (theSlider != null) {
				theSlider.Dispose ();
				theSlider = null;
			}

			if (pdfBtn != null) {
				pdfBtn.Dispose ();
				pdfBtn = null;
			}
		}
	}
}
