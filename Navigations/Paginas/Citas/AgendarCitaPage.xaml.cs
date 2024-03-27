using Dominio;

namespace Navigations.Paginas;

public partial class AgendarCitaPage : ContentPage
{
    private Cita cita;
    public AgendarCitaPage()
	{
		InitializeComponent();

	}
    private async void Button_Clicked(object sender, EventArgs e)
    {

        // Analizar EntryFecha.Text en un objeto DateOnly (asumiendo un formato válido)
        DateOnly fecha;
        try
        {

            var x = DatePickeFecha.Date;

            fecha = DateOnly.FromDateTime(x);
        }
        catch (FormatException)
        {

            await DisplayAlert("Error", "Formato de fecha no válido", "OK");
            return;
        }


        var seed = Environment.TickCount;
        var random = new Random(seed);


        // Crea un objeto Persona
        cita = new Cita
        {
            // Suponiendo que Persona.Fecha es una cadena por ahora
            Numero = random.Next(1000,10000),
            Fecha = fecha,
            Especialidad = picker.SelectedItem.ToString(),
            Medico = Item.SelectedItem.ToString()
        };

        // Comprobar si se creó la persona
        if (cita != null && cita.Fecha != null)
        {
            await Navigation.PushAsync(new CitaCreadaPage(cita));
        }
    }
}