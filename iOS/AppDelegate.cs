using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace PPKicks.iOS {
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate {
		public override bool FinishedLaunching(UIApplication app, NSDictionary options) {
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());
			UITabBar.Appearance.SelectedImageTintColor = UIColor.FromRGB(118, 53, 235);


			return base.FinishedLaunching(app, options);
		}
	}
}
