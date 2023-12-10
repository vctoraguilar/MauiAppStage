using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;
namespace MauiApp1.Views;

public partial class Login : ContentPage
{
    Button loginButton;
    Button registroButton;
    Grid layout;

    [Obsolete]
    public Login()
    {
        InitializeComponent();
        this.BackgroundColor = Color.FromArgb("273169");

        //// Lista de videos
        //List<string> videos = new List<string>
        //{
        //    "video_a.mp4",
        //    "video_b.mp4",
        //    "video_c.mp4" 
            
        //};

        //// Genera un número aleatorio
        //Random random = new Random();
        //int index = random.Next(videos.Count);

        var videoPlayer = new MediaElement
        {
            Source = "Images/video_a.mp4", //videos[index], // Selecciona un video al azar de la lista
            ShouldAutoPlay = true,
            ShouldLoopPlayback = true
        };

        var overlay = new BoxView
        {
            BackgroundColor = Color.FromArgb("273169"), // Cambia esto al color que desees 
            Opacity = 0.5 // Ajusta esto a la opacidad que desees
            
        };

        loginButton = new Button { Text = "Ingresar", TextColor = Color.FromRgb(255, 255, 255), BackgroundColor = Color.FromArgb("D466A3"), Margin = new Thickness(0, 30, 0, 0), WidthRequest = 150 };
        //registroButton = new Button { Text = "Regístrate", FontSize = 12, TextColor = Color.FromArgb("D466A3"), BackgroundColor = Color.FromArgb("273169"), Margin = new Thickness(0, 0, 0, 0) };

        var registroLabel = new Label
        {
            Text = " Regístrate",
            FontSize = 12,
            TextColor = Color.FromArgb("D466A3"),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.End
        };

        registroLabel.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(() =>
            {
                Application.Current.MainPage = new Registro();
            })
        });

        var registroLayout = new HorizontalStackLayout
        {
            new Label { Text = "Si no tienes una cuenta,", FontSize=12, TextColor = Color.FromRgb(255, 255, 255), Margin = new Thickness(0, 30, 0, 0), VerticalTextAlignment=TextAlignment.Center},
                registroLabel
            //registroButton
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
                new Label {Text="Contraseña", TextColor=Color.FromRgb(255,255,255), Margin = new Thickness(0, 20, 0, 0)},
                new Entry {TextColor=Color.FromRgb(200,200,200), IsPassword=true},
                loginButton,
                registroLayout
            }
        };

                //contentLayout.Children.Add(loginButton);
                //contentLayout.Children.Add(registroButton);

        layout = new Grid
        {
            Children = { videoPlayer, overlay, contentLayout }
        };

        this.Content = layout;

        loginButton.Clicked += loginButton_Clicked;

        //registroButton.Clicked += registroButton_Clicked;
    }

    //private void registroButton_Clicked(object? sender, EventArgs e)
    //{
    //    Application.Current.MainPage = new Registro();
    //}

    private void loginButton_Clicked(object? sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }
}