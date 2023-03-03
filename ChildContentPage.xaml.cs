namespace BugMAUIModalPage;

public partial class ChildContentPage : ContentPage
{
    public static readonly BindableProperty CanCancelProperty = BindableProperty.Create(nameof(CanCancel), typeof(bool), typeof(ChildContentPage), true);
    public static readonly BindableProperty CancelCommandProperty = BindableProperty.Create(nameof(CancelCommand), typeof(Command), typeof(ChildContentPage), new Command(async () => await Shell.Current.Navigation.PopModalAsync()));

    public ChildContentPage()
    {
        BindingContext = this;
        InitializeComponent();
    }

    public bool CanCancel
    {
        get => (bool)GetValue(CanCancelProperty);
        set => SetValue(CanCancelProperty, value);
    }

    public Command CancelCommand
    {
        get => (Command)GetValue(CancelCommandProperty);
        set => SetValue(CancelCommandProperty, value);
    }
}