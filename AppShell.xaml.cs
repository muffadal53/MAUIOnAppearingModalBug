namespace BugMAUIModalPage;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        RegisterRoutes();

    }

    private void RegisterRoutes()
    {
        Routing.RegisterRoute("parentContent", typeof(ParentContentPage));
        Routing.RegisterRoute("childContent", typeof(ChildContentPage));
    }
}
