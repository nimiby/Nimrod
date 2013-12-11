using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Hello_MultiPage_iPhone
{
	public partial class HomeScreen : UIViewController
	{
		HelloWorldScreen helloWorldScreen;
		HelloUniverseScreen helloUniverseScreen;

		public HomeScreen () : base ("HomeScreen", null)
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
			
			// Perform any additional setup after loading the view, typically from a nib.

			btnHelloWorldScreen.TouchUpInside += (sender, e) => 
			{
				if (helloWorldScreen == null) {
					helloWorldScreen = new HelloWorldScreen();
				}

				NavigationController.PushViewController(helloWorldScreen, true);
			};

			btnHelloUniverseScreen.TouchUpInside += (sender, e) => 
			{
				if (helloUniverseScreen == null) {
					helloUniverseScreen = new HelloUniverseScreen();
				}

				NavigationController.PushViewController(helloUniverseScreen, true);
			};


		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			NavigationController.SetNavigationBarHidden (true, true);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			NavigationController.SetNavigationBarHidden(false, true);
		}
	}
}

