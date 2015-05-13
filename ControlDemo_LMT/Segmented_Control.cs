using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace ControlDemo_LMT
{
	public partial class Segmented_Control : UIViewController
	{
		UISegmentedControl _segmentedControl;

		public Segmented_Control () : base ("Segmented_Control", null)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_segmentedControl = new UISegmentedControl (new object[] { "One", "Two", "Three", "Four" });
			_segmentedControl.Frame = new RectangleF (10, 10, View.Frame.Width - 20, 50);

			this.View.AddSubview (_segmentedControl);

		}
	}
}

