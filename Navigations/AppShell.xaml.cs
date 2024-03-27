using Navigations.Paginas;

namespace Navigations
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //        Routing.RegisterRoute("Menu", typeof(Page1));

            Routing.RegisterRoute("LoginPage", typeof(MainPage));
            Routing.RegisterRoute("Page1", typeof(MenuPage));
            Routing.RegisterRoute("Page2", typeof(AgendarCitaPage));
            Routing.RegisterRoute("Page3", typeof(CitaCanceladaPage));
        }
    }
}
