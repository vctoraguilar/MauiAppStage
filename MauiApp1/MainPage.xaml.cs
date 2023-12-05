using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using ToolbarPlacement = Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.ToolbarPlacement;

namespace MauiApp1
{
    public partial class MainPage : Microsoft.Maui.Controls.TabbedPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            Children.Add(new Views.Torneo { IconImageSource = "trophy_96px.png" });
            Children.Add(new Views.Equipo { IconImageSource = "people_96px.png" });
            Children.Add(new Views.Ajustes { IconImageSource = "settings_96px.png" });

            this.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
                .SetToolbarPlacement(ToolbarPlacement.Bottom);

            BarBackgroundColor = Color.FromArgb("D466A3");
            BarTextColor = Colors.White;
        }

        
    }

}
