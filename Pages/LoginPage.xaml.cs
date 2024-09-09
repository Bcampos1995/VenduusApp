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
        // Navegue para a página de redefinição de senha ou exiba um alerta
        await DisplayAlert("Esqueceu sua senha", "Página de recuperação de senha não implementada.", "OK");
    }
}