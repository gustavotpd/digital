using digital.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidMethods))]
namespace digital.Droid
{
	public class AndroidMethods : IAndroidMethods
	{
		public void CloseApp()
		{
			Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
		}
	}
}