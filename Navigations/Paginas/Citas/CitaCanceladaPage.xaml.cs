using Dominio;
namespace Navigations.Paginas;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}

    private  async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }
}