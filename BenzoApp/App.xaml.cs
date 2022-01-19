using BenzoApp.Pages;

namespace BenzoApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		if (Device.Idiom == TargetIdiom.Phone)
			Shell.Current.CurrentItem = PhoneTabs;

		Routing.RegisterRoute("settings", typeof(SettingsPage));
	}

	void TapGestureRecongnizer_Tapped(System.Object sender, System.EventArgs eventArgs)
    {
		Shell.Current.GoToAsync("///settings");
    }
}
