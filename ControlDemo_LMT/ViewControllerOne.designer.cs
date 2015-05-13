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
	[Register ("ViewControllerOne")]
	partial class ViewControllerOne
	{
		[Outlet]
		MonoTouch.UIKit.UIButton pdfBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton showConTwoBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (showConTwoBtn != null) {
				showConTwoBtn.Dispose ();
				showConTwoBtn = null;
			}

			if (pdfBtn != null) {
				pdfBtn.Dispose ();
				pdfBtn = null;
			}
		}
	}
}
