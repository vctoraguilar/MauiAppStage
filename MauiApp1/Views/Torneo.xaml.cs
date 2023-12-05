
namespace MauiApp1.Views;

public partial class Torneo : ContentPage
{
    public const double FontSize = 18;
	public Torneo()
	{
		InitializeComponent();
        CrearBtn.Clicked += CrearBtn_Clicked;
        enfrentamientoBtn.Clicked += EnfrentamientoBtn_Clicked;

    }

    private void EnfrentamientoBtn_Clicked(object? sender, EventArgs e)
    {
        Application.Current.MainPage = new Enfrentamiento();
    }

    private void CrearBtn_Clicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return Torneo.FontSize;
    }
}
