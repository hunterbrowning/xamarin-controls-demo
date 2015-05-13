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
	[Register ("ActivityIndicatorView")]
	partial class ActivityIndicatorView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton pdfBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton showActivityBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (showActivityBtn != null) {
				showActivityBtn.Dispose ();
				showActivityBtn = null;
			}

			if (pdfBtn != null) {
				pdfBtn.Dispose ();
				pdfBtn = null;
			}
		}
	}
}
