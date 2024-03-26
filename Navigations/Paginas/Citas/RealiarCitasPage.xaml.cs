using Dominio;

namespace Navigations.Paginas;

public partial class RealiarCitasPage : ContentPage
{
    private Persona persona;
    public RealiarCitasPage()
	{
		InitializeComponent();

	}
    private async void Button_Clicked(object sender, EventArgs e)
    {

        // Analizar EntryFecha.Text en un objeto DateOnly (asumiendo un formato válido)
        DateOnly fecha;
        try
        {
            fecha = DateOnly.Parse(EntryFecha.Text);
        }
        catch (FormatException)
        {

            await DisplayAlert("Error", "Formato de fecha no válido", "OK");
            return;
        }

        // Crea un objeto Persona
        persona = new Persona
        {
            // Suponiendo que Persona.Fecha es una cadena por ahora
            Fecha = fecha,
            Especialidad = picker.SelectedItem.ToString(),
            Medico = Item.SelectedItem.ToString()
        };

        // Comprobar si se creó la persona
        if (persona != null && persona.Fecha != null)
        {
            await Navigation.PushAsync(new CitaCreadaPage(persona));
        }
    }
}