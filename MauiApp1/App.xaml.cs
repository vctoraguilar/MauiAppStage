using MauiApp1.Views;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();



            var loginPage = new Login();

            // Oculta la barra de navegación en la página de inicio de sesión
            NavigationPage.SetHasNavigationBar(loginPage, false);

            // Establece la página de inicio de sesión como la página principal
            MainPage = new NavigationPage(loginPage);

            //MainPage = new AppShell();
        }
       
    }
}
