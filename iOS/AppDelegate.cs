using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Telerik.XamarinForms.PrimitivesRenderer.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.iOS.SideDrawerRenderer))]

namespace CatchEm.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new SideDrawerRenderer();
            global::Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

