using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;


namespace ControlDemo_LMT
{
	public partial class PagingController : UIViewController
	{
		UIScrollView _scroll;
		List<UIView> _pages;

		int _numPages = 4;
		float _padding = 10;
		float _pageheight = 400;
		float _pageWidth = 300;

		PDFCodeView _pdfView;
		string _pdfFile = "PagingController.pdf";

		public PagingController () : base ("PagingController", null)
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
			
			View.BackgroundColor = UIColor.Blue;
			_pages = new List<UIView> ();

			_scroll = new UIScrollView {
				Frame = View.Frame,
				PagingEnabled = true,
				ContentSize = new SizeF (_numPages * _pageWidth + _padding + 2 * _padding * (_numPages - 1), View.Frame.Height),
				DirectionalLockEnabled = true
			};

			View.AddSubview (_scroll);

			for (int i = 0; i < _numPages; i++) {
				UIView v = new UIView ();
				v.Add (new UILabel {
					Frame = new RectangleF (100, 50, 100, 25),
					Text = String.Format ("Page {0}", i + 1),
					BackgroundColor = UIColor.White
				});

				_pages.Add (v);
				v.BackgroundColor = UIColor.Green;

				v.Frame = new RectangleF (
					i * +_pageWidth + _padding + (2 * _padding * i), 0, _pageWidth, _pageheight);

				_scroll.AddSubview (v);

			}
			/*
			_pager = new UIPageControl ();
			//_pager = new UIPageControl ();
			_pager.Pages = _numPages;
			_pager.Frame = new RectangleF (0, 420, View.Frame.Width, 50);

			View.AddSubview (_pager);
			_scroll.Scrolled += delegate {
				_pager.CurrentPage = (int)Math.Round(_scroll.ContentOffset.X/_pageWidth);
			};*/
			pdfBtn.TouchUpInside += delegate {
				_pdfView = new PDFCodeView(_pdfFile);
				this.PresentViewController(_pdfView, true, null);
			};
		}
	}
}

