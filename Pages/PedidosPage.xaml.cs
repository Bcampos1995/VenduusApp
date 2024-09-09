namespace VenduusApp;

public partial class PedidosPage : ContentPage
{
	public PedidosPage()
	{
		InitializeComponent();
	}

    private async void OnIncluirButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new IncluirPedidoPage());
    }
}