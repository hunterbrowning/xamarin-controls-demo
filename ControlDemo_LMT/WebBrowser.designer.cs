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
	[Register ("WebBrowser")]
	partial class WebBrowser
	{
		[Outlet]
		MonoTouch.UIKit.UIButton backBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton fwdBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton pdfBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton refreshBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField urlFld { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView webView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (backBtn != null) {
				backBtn.Dispose ();
				backBtn = null;
			}

			if (fwdBtn != null) {
				fwdBtn.Dispose ();
				fwdBtn = null;
			}

			if (refreshBtn != null) {
				refreshBtn.Dispose ();
				refreshBtn = null;
			}

			if (urlFld != null) {
				urlFld.Dispose ();
				urlFld = null;
			}

			if (webView != null) {
				webView.Dispose ();
				webView = null;
			}

			if (pdfBtn != null) {
				pdfBtn.Dispose ();
				pdfBtn = null;
			}
		}
	}
}
