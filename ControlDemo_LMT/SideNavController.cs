using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FlyoutNavigation;
using MonoTouch.Dialog;

namespace ControlDemo_LMT
{
	public partial class SideNavController : UIViewController
	{
		/*
		ActivityIndicatorView aiv = new ActivityIndicatorView ();
		TheSegmentedControl tsc = new TheSegmentedControl();
		TheSwitchControl switchCon = new TheSwitchControl();*/
		UINavigationController navCon;
		public SideNavController (UINavigationController nav) : base ("SideNavController", null)
		{
			this.navCon = nav;
			navCon.NavigationBarHidden = true;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			var navigation = new FlyoutNavigationController {
				// Create the navigation menu

				NavigationRoot = new RootElement ("Navigation") {
					new Section ("Pages") {
						new StringElement ("Activity Indicator"),
						new StringElement ("Segmented Controller"),
						new StringElement ("Switch"),
					}
				},
				// Supply view controllers corresponding to menu items:
				ViewControllers = new UIViewController [] {
					new ActivityIndicatorView(),
					new TheSegmentedControl(),
					new TheSwitchControl(),
				},
			};
			// Show the navigation view
			navigation.ToggleMenu ();
			View.AddSubview (navigation.View);
		}
	}
}

