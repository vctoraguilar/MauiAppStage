namespace MauiApp1
{
    public partial class MainPage : TabbedPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            Children.Add(new Views.Torneo { IconImageSource="trophy_96px.png" });
            Children.Add(new Views.Equipo { IconImageSource = "people_96px.png" });
            Children.Add(new Views.Ajustes { IconImageSource = "settings_96px.png" });
        }

        
    }

}
