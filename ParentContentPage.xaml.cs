namespace BugMAUIModalPage;

public partial class ParentContentPage : ContentPage
{
	public ParentContentPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("childContent");
    }

    protected override void OnAppearing()
    {
        DisplayAlert("ParentContentPage","OnAppearing of Parent Page","OK");
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        DisplayAlert("ParentContentPage", "OnDisappearing of Parent Page", "OK");
        base.OnDisappearing();
    }

}