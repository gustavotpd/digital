﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace digital.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());
			ImageCircle.Forms.Plugin.iOS.ImageCircleRenderer.Init();
			XFGloss.iOS.Library.Init();

			return base.FinishedLaunching(app, options);
		}
	}
}
