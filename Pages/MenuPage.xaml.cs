namespace VenduusApp;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

    private async void OnPrincipalButtonClicked(object sender, EventArgs e)
    {
        // Lógica para abrir a página principal
    }

    private async void OnPedidosButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PedidosPage());
    }

    private async void OnSincronizarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SincronizarPage());
    }
}