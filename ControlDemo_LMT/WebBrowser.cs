using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ControlDemo_LMT
{
	public partial class WebBrowser : UIViewController
	{
		PDFCodeView _pdfView;
		string _pdfFile = "WebBrowser.pdf";

		public WebBrowser () : base ("WebBrowser", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			urlFld.ShouldReturn = (textField) => {
				textField.ResignFirstResponder ();
				string url = textField.Text;
				if (!url.StartsWith ("http"))
					url = String.Format ("http://{0}", url);
				NSUrl nsurl = new NSUrl (url);
				NSUrlRequest req = new NSUrlRequest (nsurl);
				webView.LoadRequest (req);
				return true;
			};
			backBtn.TouchUpInside += delegate {
				webView.GoBack();
			};
			fwdBtn.TouchUpInside += delegate {
				webView.GoForward();
			};
			refreshBtn.TouchUpInside += delegate {
				webView.Reload();
			};

			pdfBtn.TouchUpInside += delegate {
				_pdfView = new PDFCodeView(_pdfFile);
				this.PresentViewController(_pdfView, true, null);
			};
		}
	}
}

