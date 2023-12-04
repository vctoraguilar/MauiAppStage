using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;
namespace MauiApp1.Views;

public partial class Login : ContentPage
{
    Button loginButton;
    Grid layout;

    [Obsolete]
    public Login()
    {
        InitializeComponent();
        this.BackgroundColor = Color.FromArgb("273169");

        // Lista de videos
        List<string> videos = new List<string>
        {
            "video_a.mp4",
            "video_b.mp4",
            "video_c.mp4" 
            // Asegúrate de que los videos estén en la carpeta de recursos de tu proyecto
        };

        // Genera un número aleatorio
        Random random = new Random();
        int index = random.Next(videos.Count);

        var videoPlayer = new MediaElement
        {
            Source = videos[index], // Selecciona un video al azar de la lista
            ShouldAutoPlay = true,
            ShouldLoopPlayback = true
        };

        var overlay = new BoxView
        {
            BackgroundColor = Color.FromArgb("273169"), // Cambia esto al color que desees
            Opacity = 0.5 // Ajusta esto a la opacidad que desees
            
        };

        var contentLayout = new VerticalStackLayout
        {
            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 60, 30, 60),
            Children =
            {
                new Image {Source="completo_logo.png",WidthRequest=120,HeightRequest=120},
                
                new Label {Text="Usuario", TextColor=Color.FromRgb(255,255,255), Margin = new Thickness(0, 40, 0, 0)},
                new Entry {TextColor=Color.FromRgb(200,200,200)},
                new Label {Text="Contraseña", TextColor=Color.FromRgb(255,255,255)},
                new Entry {TextColor=Color.FromRgb(200,200,200), IsPassword=true},
            }
        };

        loginButton = new Button { Text = "Ingresar", TextColor = Color.FromRgb(255, 255, 255), BackgroundColor = Color.FromArgb("D466A3"), Margin = new Thickness(0, 30, 0, 0) };
        contentLayout.Children.Add(loginButton);

        layout = new Grid
        {
            Children = { videoPlayer, overlay, contentLayout }
        };

        this.Content = layout;

        loginButton.Clicked += loginButton_Clicked;
    }
    private async void loginButton_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}