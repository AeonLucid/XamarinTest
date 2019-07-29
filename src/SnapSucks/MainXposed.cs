using Android.Util;
using Xposed;
using Xposed.Callbacks;

namespace SnapSucks
{
    public class MainXposed : Java.Lang.Object, IXposedHookLoadPackage
    {
        public void HandleLoadPackage(XC_LoadPackage.LoadPackageParam p0)
        {
            Log.Info("SnapSucks", "Why tho.");
        }
    }
}