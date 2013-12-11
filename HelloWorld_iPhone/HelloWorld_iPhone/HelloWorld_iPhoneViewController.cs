using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld_iPhone
{
	public partial class HelloWorld_iPhoneViewController : UIViewController
	{
		private int numberOfTimesClicked = 0;

		public HelloWorld_iPhoneViewController () : base ("HelloWorld_iPhoneViewController", null)
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

			this.btnClickMe.TouchUpInside += (sender, e) => 
			{
				numberOfTimesClicked++;

				lblOutput.Text = string.Format("Clicked {0} times!", numberOfTimesClicked);
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void actnButtonClick (NSObject sender)
		{
			lblOutput.Text = string.Format("Buttin [{0}] was clicked!", ((UIButton)sender).CurrentTitle);
		}
	}
}

