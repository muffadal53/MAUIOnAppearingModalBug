namespace BugMAUIModalPage;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnSecondPageButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("parentContent");
    }
}

