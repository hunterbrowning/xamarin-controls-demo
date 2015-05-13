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
	[Register ("ProgressView")]
	partial class ProgressView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton pdfbtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton showProgressBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (showProgressBtn != null) {
				showProgressBtn.Dispose ();
				showProgressBtn = null;
			}

			if (pdfbtn != null) {
				pdfbtn.Dispose ();
				pdfbtn = null;
			}
		}
	}
}
