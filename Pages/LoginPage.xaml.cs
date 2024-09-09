namespace VenduusApp.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EmpresaPage());
    }

    private async void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        // Navegue para a p�gina de redefini��o de senha ou exiba um alerta
        await DisplayAlert("Esqueceu sua senha", "P�gina de recupera��o de senha n�o implementada.", "OK");
    }
}