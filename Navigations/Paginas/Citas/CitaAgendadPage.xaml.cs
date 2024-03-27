using Dominio;

namespace Navigations.Paginas;

public partial class CitaCreadaPage : ContentPage
{
    private Cita cita;
    public CitaCreadaPage(Cita cita)
	{
		InitializeComponent();
        this.cita = cita;
       
    }
    // Permite el comportamiento de manera inmediata antes de que la pagina sea visible
    protected override void OnAppearing() 
    {
        base.OnAppearing();

        // Mostrar los datos de persona
        EntryDia.Text = cita.Fecha.ToString();
        EntryEspecialidad.Text = cita.Especialidad;
        EntryMedico.Text = cita.Medico;
        EntryNumero.Text = cita.Numero.ToString().PadLeft(10,'0');
    }

    private  async void Button_Clicked(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync($"//Page1").GetAwaiter();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//Page3").GetAwaiter();

    }
}
