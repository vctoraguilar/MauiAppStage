namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        Button _loginButton;
        VerticalStackLayout _layout;
        public MainPage()
        {
            this.BackgroundColor = Color.FromArgb("273169");
            _layout = new VerticalStackLayout
            {
                Margin = new Thickness(15, 15, 15, 15),
                Padding = new Thickness(30, 60, 30, 60),
                Children =
                {
                    new Image {Source="dotnet_bot.png",WidthRequest=100,HeightRequest=100},
                    new Label {Text="Inicia Sesión", FontSize = 30, TextColor=Color.FromRgb(255,255,255)},
                    new Label {Text="Nombre de Usuario", TextColor=Color.FromRgb(255,255,255)},
                    new Entry {TextColor=Color.FromRgb(200,200,200)},
                    new Label {Text="Contraseña", TextColor=Color.FromRgb(255,255,255)},
                    new Entry {TextColor=Color.FromRgb(200,200,200), IsPassword=true},
                }
            };
            _loginButton = new Button { Text = "Ingresar", TextColor=Color.FromRgb(255,255,255),BackgroundColor = Color.FromArgb("D466A3") };
            _layout.Children.Add(_loginButton);
            
            this.Content = _layout;

            _loginButton.Clicked += _loginButton_Clicked;
        }

        private void _loginButton_Clicked(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}
