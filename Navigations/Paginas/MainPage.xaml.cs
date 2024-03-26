

namespace Navigations.Paginas
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
           InitializeComponent();


            var authState = SecureStorage.Default.GetAsync("AuthState").Result;

            if (authState is not null) {

                 Shell.Current.GoToAsync($"//Page1").GetAwaiter();
            }




        }

        protected override void OnAppearing()
        {


            base.OnAppearing();


            EntryUsuario.Text = String.Empty;
            EntryContraseña.Text = String.Empty;


        }



        private async void Button_ClickedAsync(object sender, EventArgs e)
        {

            // await Shell.Current.GoToAsync($"//Menu");

            await SecureStorage.Default.SetAsync("AuthState", "true");

            await Shell.Current.GoToAsync($"//Page1");

            //            await Navigation.PushAsync(new Page1());
        }
    }

}
