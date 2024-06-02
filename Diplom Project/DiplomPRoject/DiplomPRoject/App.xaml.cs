using Microsoft.Maui.ApplicationModel;

namespace DiplomPRoject;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
	}
}
