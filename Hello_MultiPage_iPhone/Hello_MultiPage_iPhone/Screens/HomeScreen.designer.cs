// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Hello_MultiPage_iPhone
{
	[Register ("HomeScreen")]
	partial class HomeScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnHelloUniverseScreen { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnHelloWorldScreen { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnHelloWorldScreen != null) {
				btnHelloWorldScreen.Dispose ();
				btnHelloWorldScreen = null;
			}

			if (btnHelloUniverseScreen != null) {
				btnHelloUniverseScreen.Dispose ();
				btnHelloUniverseScreen = null;
			}
		}
	}
}
