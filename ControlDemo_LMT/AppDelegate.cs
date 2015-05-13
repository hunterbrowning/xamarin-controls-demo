using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.SlideoutNavigation;
using MonoTouch.Dialog;

namespace ControlDemo_LMT
{

	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{

		UIWindow window;
		public SlideoutNavigationController Menu { get; private set; }
		// This is the main entry point of the application.

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			Menu = new SlideoutNavigationController ();
			Menu.SlideHeight = 9999f;
			Menu.TopView = new AboutView ();
			Menu.MenuViewLeft = new SlideControllerLeft ();
			Menu.MenuViewRight = new SlideControllerRight ();
			Menu.SlideWidth = 260f; // allows you to determine how much of the menu is vissible
			Menu.SlideSpeed = 1; // how many seconds you want the slide transition to take


			window.RootViewController = Menu;
			window.MakeKeyAndVisible ();

			return true;
		}
	}
	public class SlideControllerLeft : DialogViewController
	{
		public SlideControllerLeft () : base(UITableViewStyle.Plain,new RootElement(""))
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			NavigationItem.LeftBarButtonItem = this.EditButtonItem;

			Root.Add (new Section () {
				new StyledStringElement ("Home", () => {
					NavigationController.PushViewController (new AboutView (), true);
					Console.WriteLine ("YOU HIT IT BROTHA");
				}),
				new StyledStringElement ("Activity Indicicator", () => {
					NavigationController.PushViewController (new ActivityIndicatorView (), true);
				}),
				new StyledStringElement ("Navigation", () => {
					NavigationController.PushViewController (new NavConExOne (), true);
				}),
				new StyledStringElement ("Paging", () => {
					NavigationController.PushViewController (new PagingController (), true);
				}),
				new StyledStringElement ("Progress View", () => {
					NavigationController.PushViewController (new ProgressView (), true);
				}),
				new StyledStringElement ("Segmented Control", () => {
					NavigationController.PushViewController (new TheSegmentedControl (), true);
				}),
				new StyledStringElement ("Slider Control", () => {
					NavigationController.PushViewController (new TheSliderControl (), true);
				}),
				new StyledStringElement ("Switch Control", () => {
					NavigationController.PushViewController (new TheSwitchControl (), true);
				}),
				new StyledStringElement ("Custom Animation", () => {
					NavigationController.PushViewController (new ViewControllerOne (), true);
				}),
				new StyledStringElement ("Web View", () => {
					NavigationController.PushViewController (new WebBrowser (), true);
				})
			});
		}

	}
	public class SlideControllerRight : DialogViewController
	{
		public SlideControllerRight ()
			: base(UITableViewStyle.Plain,new RootElement(""))
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// accessing properties from the AppDelegate
			var del = UIApplication.SharedApplication.Delegate as AppDelegate;

			BooleanElement leftMenuEnabled = new BooleanElement ("Left menu enabled", del.Menu.LeftMenuEnabled);
			leftMenuEnabled.ValueChanged += (sender, e) => {
				del.Menu.LeftMenuEnabled = leftMenuEnabled.Value;
			};

			Root.Add (new Section () {
				new StyledStringElement("Home", () => { NavigationController.PushViewController(new AboutView(), true); }),
				leftMenuEnabled
			});
		}
	}
}

