using Dominio;
namespace Navigations.Paginas;

public partial class CitaCanceladaPage : ContentPage
{
	public CitaCanceladaPage()
	{
		InitializeComponent();
	}

    private  async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());

    }
}