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
	[Register ("PDFCodeView")]
	partial class PDFCodeView
	{
		[Outlet]
		MonoTouch.UIKit.UIToolbar toolBar { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView webViewDisplay { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (webViewDisplay != null) {
				webViewDisplay.Dispose ();
				webViewDisplay = null;
			}

			if (toolBar != null) {
				toolBar.Dispose ();
				toolBar = null;
			}
		}
	}
}
