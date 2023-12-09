namespace MauiApp1.Views;

public partial class TorneoDetalle : ContentView
{
	public TorneoDetalle()
	{
		InitializeComponent();
        enfrentamientoBtn.Clicked += EnfrentamientoBtn_Clicked;

    }
    private async void EnfrentamientoBtn_Clicked(object? sender, EventArgs e)
    {
        //Application.Current.MainPage = new Enfrentamiento();
        var AbrirEnfrentamiento=new Enfrentamiento();
        await Navigation.PushAsync(new NavigationPage(AbrirEnfrentamiento));
    }
}