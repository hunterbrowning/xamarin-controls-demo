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
	[Register ("TheSwitchControl")]
	partial class TheSwitchControl
	{
		[Outlet]
		MonoTouch.UIKit.UIButton pdfBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel switchLbl { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch theSwitch { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (switchLbl != null) {
				switchLbl.Dispose ();
				switchLbl = null;
			}

			if (theSwitch != null) {
				theSwitch.Dispose ();
				theSwitch = null;
			}

			if (pdfBtn != null) {
				pdfBtn.Dispose ();
				pdfBtn = null;
			}
		}
	}
}
