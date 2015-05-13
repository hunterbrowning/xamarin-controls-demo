using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ControlDemo_LMT
{
	public partial class TestScreen : UIViewController
	{
		public TestScreen () : base ("TestScreen", null)
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
			Console.WriteLine ("Test Loaded");
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

