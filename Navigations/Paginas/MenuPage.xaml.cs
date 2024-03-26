using Dominio;
namespace Navigations.Paginas;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
        MainPage = new NavigationPage(new MainPage());


        var authState = SecureStorage.Default.GetAsync("AuthState").Result;

        if (authState is null)
        {

            Shell.Current.GoToAsync($"//MainPage").GetAwaiter();
        }

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();


        var authState = SecureStorage.Default.GetAsync("AuthState").Result;

        if (authState is null)
        {

            Shell.Current.GoToAsync($"//MainPage").GetAwaiter();
        }
    }


    public NavigationPage MainPage { get; }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RealiarCitasPage());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        SecureStorage.Default.Remove("AuthState");

       // await Navigation.PushAsync(new MainPage());

        Shell.Current.GoToAsync($"//MainPage").GetAwaiter();
    }
}