using CommunityToolkit.Maui.Views;

namespace MauiApp1.Views;

public partial class Registro : ContentPage
{
	
	
	public Registro()
	{
		InitializeComponent();
        registroButton.Clicked += new EventHandler(registroButton_Clicked);
	}
    private void registroButton_Clicked(object? sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }

}