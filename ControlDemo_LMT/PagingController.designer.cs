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
	[Register ("PagingController")]
	partial class PagingController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton pdfBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (pdfBtn != null) {
				pdfBtn.Dispose ();
				pdfBtn = null;
			}
		}
	}
}
